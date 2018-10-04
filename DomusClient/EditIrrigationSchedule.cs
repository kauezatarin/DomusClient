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
using DomusSharedClasses;
using MetroFramework;
using MetroFramework.Forms;

namespace DomusClient
{
    public partial class EditIrrigationSchedule : MetroForm
    {
        private IrrigationSchedule _irrigationSchedule;
        private bool _isEditing = true;
        private Thread _workerThread;

        public EditIrrigationSchedule(IrrigationSchedule schedule = null)
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;

            cb_timeScale.SelectedIndex = 1;

            if (schedule == null)
            {
                _irrigationSchedule = new IrrigationSchedule(-1, "default", new DateTime(2018,10,03,12,00,00), 600, false, false, false,
                    false, false, false, false, true);

                _isEditing = false;
            }
            else
            {
                _irrigationSchedule = schedule;

                this.Text = "Editar Agendamento";
            }
        }

        private void EditIrrigationSchedule_Load(object sender, EventArgs e)
        {
            tb_name.Text = _irrigationSchedule.ScheduleName;
            dt_hour.Value = _irrigationSchedule.ScheduleTime;

            if (_irrigationSchedule.RunFor > 60)
            {
                np_duration.Value = Convert.ToDecimal(_irrigationSchedule.RunFor/60);
                cb_timeScale.SelectedIndex = 1;
            }
            else
            {
                np_duration.Value = Convert.ToDecimal(_irrigationSchedule.RunFor);
                cb_timeScale.SelectedIndex = 0;
            }

            tg_active.Checked = _irrigationSchedule.Active;
            tg_sunday.Checked = _irrigationSchedule.Sunday;
            tg_monday.Checked = _irrigationSchedule.Monday;
            tg_tuesday.Checked = _irrigationSchedule.Tuesday;
            tg_wednesday.Checked = _irrigationSchedule.Wednesday;
            tg_thursday.Checked = _irrigationSchedule.Thursday;
            tg_friday.Checked = _irrigationSchedule.Friday;
            tg_saturday.Checked = _irrigationSchedule.Saturday;
        }
        
        private void SaveThread()
        {
            try
            {
                StartSpinner();

                SetSpinnerValue(1);

                //caso esteja no modo de edição
                if (_isEditing)
                {
                    SetSpinnerValue(2);

                    ServerHandler.ServerWrite(ServerHandler.Stream, "UpdateIrrigationSchedule", 10000);

                    if (ServerHandler.ServerRead(ServerHandler.Stream, 10000) == "SendSchedule")
                        ServerHandler.ServerWriteSerialized(ServerHandler.Stream, _irrigationSchedule, 10000);
                    else
                    {
                        throw new Exception("Resposta inesperada.");
                    }

                    string response = ServerHandler.ServerRead(ServerHandler.Stream, 10000);

                    if (response == "ScheduleUpdated")
                    {
                        MetroMessageBox.Show(this, "Agendamento atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
                    }
                    else if (response == "FailToUpdate")
                    {
                        MetroMessageBox.Show(this, "Não foi possivel atualizar o agendamento.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
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
                //caso esteja no modo de cadastro
                else
                {
                    SetSpinnerValue(2);

                    ServerHandler.ServerWrite(ServerHandler.Stream, "AddIrrigationSchedule", 10000);

                    if (ServerHandler.ServerRead(ServerHandler.Stream, 10000) == "sendNewSchedule")
                        ServerHandler.ServerWriteSerialized(ServerHandler.Stream, _irrigationSchedule, 10000);
                    else
                    {
                        throw new Exception("Resposta inesperada.");
                    }

                    string response = ServerHandler.ServerRead(ServerHandler.Stream, 10000);

                    if (response == "ScheduleAdded")
                    {
                        MetroMessageBox.Show(this, "Irrigação agendada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
                    }
                    else if (response == "FailToAdd")
                    {
                        MetroMessageBox.Show(this, "Não foi possivel agendar a irrigação.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
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

                ResetSpinner();

                Application.OpenForms.OfType<IrrigationConfigForm>().First().PopulateGrid();

                Invoke(new Action(() =>
                {
                    Application.OpenForms.OfType<EditIrrigationSchedule>().First().Close();
                }));
            }
            catch (Exception e)
            {
                ResetSpinner();

                MetroMessageBox.Show(this, "Erro ao aplicar alterações. \r\n" + e.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
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
                    bt_save.Enabled = false;
                    tb_name.Enabled = false;
                    dt_hour.Enabled = false;
                    np_duration.Enabled = false;
                    cb_timeScale.Enabled = false;
                    tg_active.Enabled = false;
                    tg_sunday.Enabled = false;
                    tg_monday.Enabled = false;
                    tg_tuesday.Enabled = false;
                    tg_wednesday.Enabled = false;
                    tg_thursday.Enabled = false;
                    tg_friday.Enabled = false;
                    tg_saturday.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                pb_spinner.Enabled = true;
                bt_save.Enabled = false;
                tb_name.Enabled = false;
                dt_hour.Enabled = false;
                np_duration.Enabled = false;
                cb_timeScale.Enabled = false;
                tg_active.Enabled = false;
                tg_sunday.Enabled = false;
                tg_monday.Enabled = false;
                tg_tuesday.Enabled = false;
                tg_wednesday.Enabled = false;
                tg_thursday.Enabled = false;
                tg_friday.Enabled = false;
                tg_saturday.Enabled = false;
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
                    bt_save.Enabled = true;
                    tb_name.Enabled = true;
                    dt_hour.Enabled = true;
                    np_duration.Enabled = true;
                    cb_timeScale.Enabled = true;
                    tg_active.Enabled = true;
                    tg_sunday.Enabled = true;
                    tg_monday.Enabled = true;
                    tg_tuesday.Enabled = true;
                    tg_wednesday.Enabled = true;
                    tg_thursday.Enabled = true;
                    tg_friday.Enabled = true;
                    tg_saturday.Enabled = true;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                pb_spinner.Enabled = false;
                bt_save.Enabled = true;
                tb_name.Enabled = true;
                dt_hour.Enabled = true;
                np_duration.Enabled = true;
                cb_timeScale.Enabled = true;
                tg_active.Enabled = true;
                tg_sunday.Enabled = true;
                tg_monday.Enabled = true;
                tg_tuesday.Enabled = true;
                tg_wednesday.Enabled = true;
                tg_thursday.Enabled = true;
                tg_friday.Enabled = true;
                tg_saturday.Enabled = true;
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

        private void bt_save_Click(object sender, EventArgs e)
        {
            StartSpinner();

            _irrigationSchedule.Active = tg_active.Checked;
            _irrigationSchedule.Sunday = tg_sunday.Checked;
            _irrigationSchedule.Monday = tg_monday.Checked;
            _irrigationSchedule.Tuesday = tg_tuesday.Checked;
            _irrigationSchedule.Wednesday = tg_wednesday.Checked;
            _irrigationSchedule.Thursday = tg_thursday.Checked;
            _irrigationSchedule.Friday = tg_friday.Checked;
            _irrigationSchedule.Saturday = tg_saturday.Checked;

            if (cb_timeScale.SelectedIndex == 0)
                _irrigationSchedule.RunFor = Convert.ToInt32(np_duration.Value);
            else
            {
                _irrigationSchedule.RunFor = Convert.ToInt32(np_duration.Value) * 60;
            }

            _irrigationSchedule.ScheduleName = tb_name.Text;
            _irrigationSchedule.ScheduleTime = dt_hour.Value;

            this._workerThread = new Thread(SaveThread);
            this._workerThread.Start();
        }
    }
}
