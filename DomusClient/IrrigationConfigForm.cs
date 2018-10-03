using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DomusSharedClasses;
using MetroFramework;

namespace DomusClient
{
    public partial class IrrigationConfigForm : MetroForm
    {
        private Thread _workerThread;
        private EditIrrigationSchedule _editIrrigationSchedule;
        private IrrigationConfig _irrigationConfig;

        public IrrigationConfigForm()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        private void IrrigationConfigForm_Load(object sender, EventArgs e)
        {
            _workerThread = new Thread(LoadConfigsThread);
            _workerThread.Start();

            StartSpinner();
        }

        private void LoadConfigsThread()
        {
            Thread workerThread;

            workerThread = new Thread(PopulateGridThread);
            workerThread.Start();

            workerThread.Join();

            workerThread = new Thread(PopulateConfigsThread);
            workerThread.Start();

            workerThread.Join();

            ResetSpinner();
        }

        private void PopulateConfigsThread()
        {
            try
            {
                ServerHandler.ServerWrite(ServerHandler.Stream, "GetIrrigationConfig");

                SetSpinnerValue(3);

                _irrigationConfig = (IrrigationConfig)ServerHandler.ServerReadSerilized(ServerHandler.Stream, 30000);

                Invoke(new Action(() =>
                {
                    np_maxHumidity.Value = Convert.ToDecimal(_irrigationConfig.MaxSoilHumidity);
                    np_maxTemperature.Value = Convert.ToDecimal(_irrigationConfig.MaxAirTemperature);
                    np_minTemperature.Value = Convert.ToDecimal(_irrigationConfig.MinAirTemperature);
                    tg_forecast.Checked = _irrigationConfig.UseForecast;

                }));

                SetSpinnerValue(4);

            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, "Não foi possivel recuperar os dados.\r\n" + exception.Message,
                    "Domus Client - Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    150);
            }
        }

        private void PopulateGridThread()
        {
            List<IrrigationSchedule> irrigationSchedules;

            SetSpinnerValue(1);

            try
            {
                ServerHandler.ServerWrite(ServerHandler.Stream, "ListIrrigationSchedules");

                irrigationSchedules = (List<IrrigationSchedule>)ServerHandler.ServerReadSerilized(ServerHandler.Stream, 30000);

                Invoke(new Action(() =>
                {
                    dtg_schedules.DataSource = irrigationSchedules;

                    //modifica o nome das colunas
                    dtg_schedules.Columns[0].HeaderText = "Id";
                    dtg_schedules.Columns[1].HeaderText = "Nome";
                    dtg_schedules.Columns[2].HeaderText = "Horário";
                    dtg_schedules.Columns[3].HeaderText = "Irrigar por (seg.)";
                    dtg_schedules.Columns[4].HeaderText = "Domingo";
                    dtg_schedules.Columns[5].HeaderText = "Segunda";
                    dtg_schedules.Columns[6].HeaderText = "Terça";
                    dtg_schedules.Columns[7].HeaderText = "Quarta";
                    dtg_schedules.Columns[8].HeaderText = "Quinta";
                    dtg_schedules.Columns[9].HeaderText = "Sexta";
                    dtg_schedules.Columns[10].HeaderText = "Sábado";
                    dtg_schedules.Columns[11].HeaderText = "Ativo?";

                    //altera o formato de exibbição do horário
                    dtg_schedules.Columns[2].DefaultCellStyle.Format = "HH:mm:ss";

                    dtg_schedules.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
                }));

                SetSpinnerValue(2);

            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, "Não foi possivel recuperar os dados.\r\n" + exception.Message,
                    "Domus Client - Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    150);
            }

        }

        private void PopulateGrid()
        {
            _workerThread = new Thread(PopulateGridThread);
            _workerThread.Start();
        }

        private void DeleteScheduleThread()
        {
            try
            {
                SetSpinnerValue(1);

                IrrigationSchedule temp = dtg_schedules.CurrentRow.DataBoundItem as IrrigationSchedule;
                DialogResult result = MetroMessageBox.Show(this, "Gostaria de deletar o agendamento " + temp.ScheduleName + "?\r\nNão será possivel reverter a alteração.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);

                if (result == DialogResult.No)
                {
                    ResetSpinner();
                    return;
                }

                ServerHandler.ServerWrite(ServerHandler.Stream, "DeleteIrrigationSchedule;" + temp.ScheduleId, 3000);

                string response = ServerHandler.ServerRead(ServerHandler.Stream, 10000);

                if (response == "ScheduleDeleted")
                    MetroMessageBox.Show(this, "Agendamento deletado com sucesso.", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Question, 150);
                else if (response == "FailToDelete")
                    MetroMessageBox.Show(this, "Erro ao deletar agendamento.", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, 150);
                else
                {
                    MetroMessageBox.Show(this, "Erro inesperado.", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, 150);
                }

                ResetSpinner();

                PopulateGrid();
            }
            catch (Exception e)
            {
                ResetSpinner();

                MetroMessageBox.Show(this, "Erro ao aplicar alterações. \r\n" + e.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, 150);
            }
        }

        private void SaveIrrigationConfigsThread()
        {
            SetSpinnerValue(1);

            try
            {
                Invoke(new Action(() =>
                {
                    _irrigationConfig.MinAirTemperature = Convert.ToInt32(np_minTemperature.Value);
                    _irrigationConfig.MaxAirTemperature = Convert.ToInt32(np_maxTemperature.Value);
                    _irrigationConfig.MaxSoilHumidity = Convert.ToInt32(np_maxHumidity.Value);
                    _irrigationConfig.UseForecast = tg_forecast.Checked;
                }));

                ServerHandler.ServerWrite(ServerHandler.Stream, "SaveIrrigationConfig", 3000);

                if (ServerHandler.ServerRead(ServerHandler.Stream, 10000) == "SendConfig")
                {
                    ServerHandler.ServerWriteSerialized(ServerHandler.Stream, _irrigationConfig, 10000);
                    SetSpinnerValue(2);
                }
                else
                {
                    throw new Exception("Resposta inesperada.");
                }

                SetSpinnerValue(3);

                string response = ServerHandler.ServerRead(ServerHandler.Stream, 10000);

                if (response == "ConfigSaved")
                {
                    MetroMessageBox.Show(this, "Configuração aplicada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
                }
                else if (response == "FailToSave")
                {
                    MetroMessageBox.Show(this, "Não foi possivel aplicar as configurações.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                }
                else if (response == "noPermission")
                {
                    MetroMessageBox.Show(this, "Você não tem permissão.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                }
                else
                {
                    MetroMessageBox.Show(this, "Erro inesperado.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                }
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, "Erro inesperado.\r\n" + e.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }

            ResetSpinner();
        }

        private void StartSpinner()
        {
            if (pb_spinner.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pb_spinner.Value = 0;
                    pb_spinner.Visible = true;
                    pb_spinner.Enabled = true;
                    bt_newSchedule.Enabled = false;
                    bt_edit.Enabled = false;
                    bt_delet.Enabled = false;
                    bt_save.Enabled = false;
                    np_maxHumidity.Enabled = false;
                    np_maxTemperature.Enabled = false;
                    np_minTemperature.Enabled = false;
                    tg_forecast.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                pb_spinner.Enabled = true;
                bt_newSchedule.Enabled = false;
                bt_edit.Enabled = false;
                bt_delet.Enabled = false;
                bt_save.Enabled = false;
                np_maxHumidity.Enabled = false;
                np_maxTemperature.Enabled = false;
                np_minTemperature.Enabled = false;
                tg_forecast.Enabled = false;
            }
        }

        private void ResetSpinner()
        {
            if (pb_spinner.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pb_spinner.Value = 0;
                    pb_spinner.Visible = false;
                    pb_spinner.Enabled = false;
                    bt_newSchedule.Enabled = true;
                    bt_edit.Enabled = true;
                    bt_delet.Enabled = true;
                    bt_save.Enabled = true;
                    np_maxHumidity.Enabled = true;
                    np_maxTemperature.Enabled = true;
                    np_minTemperature.Enabled = true;
                    tg_forecast.Enabled = true;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                pb_spinner.Enabled = false;
                bt_newSchedule.Enabled = true;
                bt_edit.Enabled = true;
                bt_delet.Enabled = true;
                bt_save.Enabled = true;
                np_maxHumidity.Enabled = true;
                np_maxTemperature.Enabled = true;
                np_minTemperature.Enabled = true;
                tg_forecast.Enabled = true;
            }
        }

        private void SetSpinnerValue(int value)
        {
            if (pb_spinner.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pb_spinner.Value = value;
                }));
            }
            else
            {
                pb_spinner.Value = value;
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_delet_Click(object sender, EventArgs e)
        {
            StartSpinner();

            _workerThread = new Thread(DeleteScheduleThread);

            _workerThread.Start();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            StartSpinner();

            _workerThread = new Thread(SaveIrrigationConfigsThread);

            _workerThread.Start();
        }

        private void bt_newSchedule_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<EditIrrigationSchedule>().Any())//verifica se ja existe uma aba aberta
            {
                _editIrrigationSchedule = new EditIrrigationSchedule();//cria o form
                int x = this.Left + (this.Width / 2) - (_editIrrigationSchedule.Width / 2);
                int y = this.Top + (this.Height / 2) - (_editIrrigationSchedule.Height / 2);

                _editIrrigationSchedule.Location = new Point(x, y);//seta a posição do formulario filho

                _editIrrigationSchedule.Show();//mostra o formulario
            }
            else
            {
                MetroMessageBox.Show(this, "Só é possivel realizar uma operação por vez.",
                    "Domus Client - Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    150);

                _editIrrigationSchedule.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<EditIrrigationSchedule>().Any())//verifica se ja existe uma aba aberta
            {
                _editIrrigationSchedule = new EditIrrigationSchedule(dtg_schedules.CurrentRow.DataBoundItem as IrrigationSchedule);//cria o form
                int x = this.Left + (this.Width / 2) - (_editIrrigationSchedule.Width / 2);
                int y = this.Top + (this.Height / 2) - (_editIrrigationSchedule.Height / 2);

                _editIrrigationSchedule.Location = new Point(x, y);//seta a posição do formulario filho

                _editIrrigationSchedule.Show();//mostra o formulario
            }
            else
            {
                MetroMessageBox.Show(this, "Só é possivel realizar uma operação por vez.",
                    "Domus Client - Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    150);

                _editIrrigationSchedule.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }
    }
}
