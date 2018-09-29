using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using MetroFramework.Forms;
using DomusSharedClasses;
using MetroFramework;

namespace DomusClient
{
    public partial class LinkDeviceForm : MetroForm
    {
        private Service _service;
        private Thread _workerThread;
        private List<Device> _devices;

        public LinkDeviceForm(Service service)
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;

            _service = service;
        }

        private void LinkDeviceForm_Load(object sender, EventArgs e)
        {
            StartSpinner();

            lb_serviceName.Text = _service.ServiceName;

            _workerThread = new Thread(InitializeLists);

            _workerThread.Start();
        }

        private void InitializeLists()
        {

            SetSpinnerValue(1);

            try
            {
                ServerHandler.ServerWrite(ServerHandler.Stream, "ListDevices");

                _devices = (List<Device>)ServerHandler.ServerReadSerilized(ServerHandler.Stream, 30000);

                Invoke(new Action(() =>
                {
                    listb_devices.Items.Add("-");

                    foreach (Device device in _devices)
                    {
                        listb_devices.Items.Add(device.DeviceName);
                    }

                    if (_service.DeviceId != "NULL")
                    {
                        try
                        {
                            int deviceIndex = _devices.FindIndex(Device => Device.DeviceId == _service.DeviceId) + 1;

                            listb_devices.SetSelected(deviceIndex,true);
                        }
                        catch
                        {
                            listb_devices.SetSelected(0, true);
                        }
                    }
                    else
                    {
                        listb_devices.SetSelected(0, true);
                    }

                }));

                Thread.Sleep(500);

                Invoke(new  Action(() =>
                {
                    if (_service.DeviceId != "NULL")
                    {
                        try
                        {
                            listb_ports.SetSelected(_service.DevicePortNumber, true);
                        }
                        catch
                        {
                            listb_ports.SetSelected(0, false);
                        }
                    }
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
                    listb_devices.Enabled = false;
                    listb_ports.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                pb_spinner.Enabled = true;
                bt_save.Enabled = false;
                listb_devices.Enabled = false;
                listb_ports.Enabled = false;
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
                    listb_devices.Enabled = true;
                    listb_ports.Enabled = true;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                pb_spinner.Enabled = false;
                bt_save.Enabled = true;
                listb_devices.Enabled = true;
                listb_ports.Enabled = true;
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

        private void listb_devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listb_devices.SelectedIndex == 0)
            {
                listb_ports.Items.Clear();
                return;
            }

            Device device = _devices.Find(Device => Device.DeviceName == listb_devices.SelectedItem as string);

            listb_ports.Items.Clear();

            if (device.Data1Active)
                listb_ports.Items.Add(device.Data1Name);

            if (device.Data2Active)
                listb_ports.Items.Add(device.Data2Name);

            if (device.Data3Active)
                listb_ports.Items.Add(device.Data3Name);

            if (device.Data4Active)
                listb_ports.Items.Add(device.Data4Name);
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            StartSpinner();

            string deviceName = listb_devices.SelectedItem as string;
            string portName = listb_ports.SelectedItem as string;

            _workerThread = new Thread(() => SaveThread(deviceName, portName));
            _workerThread.Start();
        }

        private void SaveThread(string deviceName, string devicePortName)
        {
            try
            {
                StartSpinner();

                SetSpinnerValue(1);

                if (deviceName == "-")
                {

                    _service.DeviceId = "NULL";
                    _service.DevicePortNumber = -1;

                    ServerHandler.ServerWrite(ServerHandler.Stream, "UpdateLink", 10000);

                    if (ServerHandler.ServerRead(ServerHandler.Stream, 10000) == "SendService")
                        ServerHandler.ServerWriteSerialized(ServerHandler.Stream, _service, 10000);
                    else
                    {
                        throw new Exception("Resposta inesperada.");
                    }

                    string response = ServerHandler.ServerRead(ServerHandler.Stream, 10000);

                    if (response == "LinkUpdated")
                    {
                        MetroMessageBox.Show(this, "Link atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
                    }
                    else if (response == "FailToUpdate")
                    {
                        MetroMessageBox.Show(this, "Não foi possivel atualizar o Link.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
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
                else
                {
                    if (_service.IsSensor && devicePortName == null)
                    {
                        MetroMessageBox.Show(this, "É obrigatório a seleção de uma porta para sensores.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);

                        ResetSpinner();

                        return;
                    }

                    _service.DeviceId = _devices.Find(device => device.DeviceName == deviceName).DeviceId;

                    #region Discover Device Port

                    if (_service.IsSensor == false)
                        _service.DevicePortNumber = -1;

                    else if (_devices.Find(device => device.DeviceId == _service.DeviceId).Data1Name == devicePortName)
                        _service.DevicePortNumber = 0;

                    else if (_devices.Find(device => device.DeviceId == _service.DeviceId).Data2Name == devicePortName)
                        _service.DevicePortNumber = 1;

                    else if (_devices.Find(device => device.DeviceId == _service.DeviceId).Data3Name == devicePortName)
                        _service.DevicePortNumber = 2;

                    else if (_devices.Find(device => device.DeviceId == _service.DeviceId).Data4Name == devicePortName)
                        _service.DevicePortNumber = 3;

                    #endregion

                    ServerHandler.ServerWrite(ServerHandler.Stream, "UpdateLink", 10000);

                    if (ServerHandler.ServerRead(ServerHandler.Stream, 10000) == "SendService")
                        ServerHandler.ServerWriteSerialized(ServerHandler.Stream, _service, 10000);
                    else
                    {
                        throw new Exception("Resposta inesperada.");
                    }

                    string response = ServerHandler.ServerRead(ServerHandler.Stream, 10000);

                    if (response == "LinkUpdated")
                    {
                        MetroMessageBox.Show(this, "Link atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
                    }
                    else if (response == "FailToUpdate")
                    {
                        MetroMessageBox.Show(this, "Não foi possivel atualizar o Link.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
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

                Application.OpenForms.OfType<ManageLinksForm>().First().PopulateGrid();

                Invoke(new Action(() =>
                {
                    Application.OpenForms.OfType<LinkDeviceForm>().First().Close();
                }));
            }
            catch (Exception e)
            {
                ResetSpinner();

                MetroMessageBox.Show(this, "Erro ao aplicar alterações. \r\n" + e.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }
    }
}
