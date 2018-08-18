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
    public partial class EditDevicesForm : MetroForm
    {
        private Device device;
        private Thread workerThread;

        public EditDevicesForm()
        {
            InitializeComponent();

            this.Text = "Novo Dispositivo";

            tb_Uid.Text = Guid.NewGuid().ToString("N");
        }

        public EditDevicesForm(Device device)
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;

            this.device = device;

            PopulateForm();
        }

        private void PopulateForm()
        {

        }

        private void startSpinner()
        {
            if (pb_spinner.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pb_spinner.Value = 0;
                    pb_spinner.Visible = true;
                    pb_spinner.Enabled = true;
                    bt_save.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                pb_spinner.Enabled = true;
                bt_save.Enabled = false;
            }
        }

        private void resetSpinner()
        {
            if (pb_spinner.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pb_spinner.Value = 0;
                    pb_spinner.Visible = false;
                    pb_spinner.Enabled = false;
                    bt_save.Enabled = true;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                pb_spinner.Enabled = false;
                bt_save.Enabled = true;
            }
        }

        private void setSpinnerValue(int value)
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

        private void SaveThread()
        {
            try
            {
                startSpinner();

                setSpinnerValue(1);

                //caso esteja no modo de edição
                if (device != null)
                {
                    if (!ValidateForm())
                    {
                        MetroMessageBox.Show(this, "Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
                        resetSpinner();

                        return;
                    }

                    setSpinnerValue(2);

                    device = new Device();

                    ServerHandler.ServerWrite(ServerHandler.stream, "UpdateDevice", 10000);

                    if (ServerHandler.ServerRead(ServerHandler.stream, 10000) == "sendDevice")
                        ServerHandler.ServerWriteSerialized(ServerHandler.stream, device, 10000);
                    else
                    {
                        throw new Exception("Resposta inesperada.");
                    }

                    string response = ServerHandler.ServerRead(ServerHandler.stream, 10000);

                    if (response == "DeviceUpdated")
                    {
                        MetroMessageBox.Show(this, "Dispositivo atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
                    }
                    else if (response == "FailToUpdate")
                    {
                        MetroMessageBox.Show(this, "Não foi possivel atualizar o Dispositivo.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
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
                    if (!ValidateForm())
                    {
                        MetroMessageBox.Show(this, "Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
                        resetSpinner();

                        return;
                    }

                    setSpinnerValue(2);

                    device = new Device();

                    ServerHandler.ServerWrite(ServerHandler.stream, "AddDevice", 10000);

                    if (ServerHandler.ServerRead(ServerHandler.stream, 10000) == "sendNewDevice")
                        ServerHandler.ServerWriteSerialized(ServerHandler.stream, device, 10000);
                    else
                    {
                        throw new Exception("Resposta inesperada.");
                    }

                    string response = ServerHandler.ServerRead(ServerHandler.stream, 10000);

                    if (response == "DeviceAdded")
                    {
                        MetroMessageBox.Show(this, "Device cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
                    }
                    else if (response == "FailToAdd")
                    {
                        MetroMessageBox.Show(this, "Não foi possivel cadastrar o dispositivo.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                    }
                    else if (response == "noPermission")
                    {
                        MetroMessageBox.Show(this, "Você não tem permissão.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                    }
                    else if (response == "DeviceAlreadyExists")
                    {
                        MetroMessageBox.Show(this, "Este UID já está sendo utilizado.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Erro inesperado.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                    }
                }

                resetSpinner();

                Application.OpenForms.OfType<ManageUsersForm>().First().PopulateGrid();

                Invoke(new Action(() =>
                {
                    Application.OpenForms.OfType<EditUserForm>().First().Close();
                }));
            }
            catch (Exception e)
            {
                resetSpinner();

                MetroMessageBox.Show(this, "Erro ao aplicar alterações. \r\n" + e.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        private bool ValidateForm()
        {
            
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            this.workerThread = new Thread(SaveThread);
            this.workerThread.Start();
        }
    }
}
