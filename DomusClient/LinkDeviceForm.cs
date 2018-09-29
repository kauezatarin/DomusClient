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
                    listb_ports.SetSelected(_service.DevicePortNumber, true);
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
    }
}
