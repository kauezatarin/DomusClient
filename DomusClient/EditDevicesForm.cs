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
            tb_Uid.Text = device.deviceId;
            tb_devicename.Text = device.deviceName == "NULL" ? "" : device.deviceName;

            tb_data1Name.Text = device.data1_name == "NULL" ? "" : device.data1_name;
            tb_data2Name.Text = device.data2_name == "NULL" ? "" : device.data2_name;
            tb_data3Name.Text = device.data3_name == "NULL" ? "" : device.data3_name;
            tb_data4Name.Text = device.data4_name == "NULL" ? "" : device.data4_name;

            tg_data1Active.Checked = device.data1_active;
            tg_data2Active.Checked = device.data2_active;
            tg_data3Active.Checked = device.data3_active;
            tg_data4Active.Checked = device.data4_active;
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
                    setSpinnerValue(2);

                    device = new Device(tb_devicename.Text,1,device.createdAt,device.lastActivity,device.deviceId,
                        tg_data1Active.Checked, 
                        tg_data2Active.Checked, 
                        tg_data3Active.Checked, 
                        tg_data4Active.Checked,
                        tb_data1Name.Text,
                        tb_data2Name.Text,
                        tb_data3Name.Text,
                        tb_data4Name.Text);

                    ServerHandler.ServerWrite(ServerHandler.stream, "UpdateDevice", 10000);

                    if (ServerHandler.ServerRead(ServerHandler.stream, 10000) == "SendDevice")
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
                    setSpinnerValue(2);

                    device = new Device(tb_devicename.Text, 1, DateTime.Now.ToString(), DateTime.Now.ToString(), tb_Uid.Text,
                        tg_data1Active.Checked,
                        tg_data2Active.Checked,
                        tg_data3Active.Checked,
                        tg_data4Active.Checked,
                        tb_data1Name.Text,
                        tb_data2Name.Text,
                        tb_data3Name.Text,
                        tb_data4Name.Text);

                    ServerHandler.ServerWrite(ServerHandler.stream, "AddDevice", 10000);

                    if (ServerHandler.ServerRead(ServerHandler.stream, 10000) == "sendNewDevice")
                        ServerHandler.ServerWriteSerialized(ServerHandler.stream, device, 10000);
                    else
                    {
                        device = null;
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

                Application.OpenForms.OfType<ManageDevicesForm>().First().PopulateGrid();

                Invoke(new Action(() =>
                {
                    Application.OpenForms.OfType<EditDevicesForm>().First().Close();
                }));
            }
            catch (Exception e)
            {
                resetSpinner();

                MetroMessageBox.Show(this, "Erro ao aplicar alterações. \r\n" + e.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
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
