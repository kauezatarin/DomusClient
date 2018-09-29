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
        private Device _device;
        private Thread _workerThread;
        private ManageLinksForm _manageLinksForm;

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

            this._device = device;

            PopulateForm();
        }

        private void PopulateForm()
        {
            tb_Uid.Text = _device.DeviceId;
            tb_devicename.Text = _device.DeviceName == "NULL" ? "" : _device.DeviceName;

            tb_data1Name.Text = _device.Data1Name == "NULL" ? "" : _device.Data1Name;
            tb_data2Name.Text = _device.Data2Name == "NULL" ? "" : _device.Data2Name;
            tb_data3Name.Text = _device.Data3Name == "NULL" ? "" : _device.Data3Name;
            tb_data4Name.Text = _device.Data4Name == "NULL" ? "" : _device.Data4Name;

            tg_data1Active.Checked = _device.Data1Active;
            tg_data2Active.Checked = _device.Data2Active;
            tg_data3Active.Checked = _device.Data3Active;
            tg_data4Active.Checked = _device.Data4Active;
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

        private void SaveThread()
        {
            try
            {
                StartSpinner();

                SetSpinnerValue(1);

                //caso esteja no modo de edição
                if (_device != null)
                {
                    SetSpinnerValue(2);

                    _device = new Device(tb_devicename.Text,1,_device.CreatedAt,_device.LastActivity,_device.DeviceId,
                        tg_data1Active.Checked, 
                        tg_data2Active.Checked, 
                        tg_data3Active.Checked, 
                        tg_data4Active.Checked,
                        tb_data1Name.Text,
                        tb_data2Name.Text,
                        tb_data3Name.Text,
                        tb_data4Name.Text);

                    ServerHandler.ServerWrite(ServerHandler.Stream, "UpdateDevice", 10000);

                    if (ServerHandler.ServerRead(ServerHandler.Stream, 10000) == "SendDevice")
                        ServerHandler.ServerWriteSerialized(ServerHandler.Stream, _device, 10000);
                    else
                    {
                        throw new Exception("Resposta inesperada.");
                    }

                    string response = ServerHandler.ServerRead(ServerHandler.Stream, 10000);

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
                    SetSpinnerValue(2);

                    _device = new Device(tb_devicename.Text, 1, DateTime.Now.ToString(), DateTime.Now.ToString(), tb_Uid.Text,
                        tg_data1Active.Checked,
                        tg_data2Active.Checked,
                        tg_data3Active.Checked,
                        tg_data4Active.Checked,
                        tb_data1Name.Text,
                        tb_data2Name.Text,
                        tb_data3Name.Text,
                        tb_data4Name.Text);

                    ServerHandler.ServerWrite(ServerHandler.Stream, "AddDevice", 10000);

                    if (ServerHandler.ServerRead(ServerHandler.Stream, 10000) == "sendNewDevice")
                        ServerHandler.ServerWriteSerialized(ServerHandler.Stream, _device, 10000);
                    else
                    {
                        _device = null;
                        throw new Exception("Resposta inesperada.");
                    }

                    string response = ServerHandler.ServerRead(ServerHandler.Stream, 10000);

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

                ResetSpinner();

                Application.OpenForms.OfType<ManageDevicesForm>().First().PopulateGrid();

                Invoke(new Action(() =>
                {
                    Application.OpenForms.OfType<EditDevicesForm>().First().Close();
                }));
            }
            catch (Exception e)
            {
                ResetSpinner();

                MetroMessageBox.Show(this, "Erro ao aplicar alterações. \r\n" + e.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            this._workerThread = new Thread(SaveThread);
            this._workerThread.Start();
        }

        private void bt_createLink_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<LinkDeviceForm>().Any())//verifica se ja existe uma aba aberta
            {
                _manageLinksForm = new ManageLinksForm();//cria o form
                int x = this.Left + (this.Width / 2) - (_manageLinksForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (_manageLinksForm.Height / 2);

                _manageLinksForm.Location = new Point(x, y);//seta a posição do formulario filho

                _manageLinksForm.Show();//mostra o formulario
            }
            else
            {
                _manageLinksForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }
    }
}
