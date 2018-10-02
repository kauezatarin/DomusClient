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

        public IrrigationConfigForm()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        private void IrrigationConfigForm_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            _workerThread = new Thread(PopulateGridThread);
            _workerThread.Start();

            StartSpinner();
        }

        private void PopulateGridThread()
        {
            List<IrrigationSchedule> irrigationSchedules;

            SetSpinnerValue(1);

            try
            {
                ServerHandler.ServerWrite(ServerHandler.Stream, "ListIrrigationTimes");

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

                    dtg_schedules.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
                }));

            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, "Não foi possivel recuperar os dados.\r\n" + exception.Message,
                    "Domus Client - Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    150);
            }

            ResetSpinner();
        }

        private void DeleteDeviceThread()
        {
            try
            {
                StartSpinner();
                SetSpinnerValue(1);

                Device temp = dtg_schedules.CurrentRow.DataBoundItem as Device;
                DialogResult result = MetroMessageBox.Show(this, "Gostaria de deletar o dispositivo " + temp.DeviceId + "?\r\nNão será possivel reverter a alteração.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);

                if (result == DialogResult.No)
                {
                    ResetSpinner();
                    return;
                }

                ServerHandler.ServerWrite(ServerHandler.Stream, "DeleteDevice;" + temp.DeviceId, 3000);

                string response = ServerHandler.ServerRead(ServerHandler.Stream, 10000);

                if (response == "DeviceDeleted")
                    MetroMessageBox.Show(this, "Dispositivo deletado com sucesso.", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Question, 150);
                else if (response == "FailToDelete")
                    MetroMessageBox.Show(this, "Erro ao deletar dispositivo.", "Erro", MessageBoxButtons.OK,
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
    }
}
