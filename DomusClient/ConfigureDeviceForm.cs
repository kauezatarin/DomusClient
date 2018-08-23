using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DomusSharedClasses;

namespace DomusClient
{
    public partial class ConfigureDeviceForm : MetroForm
    {
        private Device device;

        public ConfigureDeviceForm(Device device)
        {
            InitializeComponent();

            this.device = device;
        }

        private void ConfigureDeviceForm_Load(object sender, EventArgs e)
        {
            tb_uid.Text = device.deviceId;
            tb_serverIp.Text = Properties.Settings.Default.serverIp;
            tb_porta.Text = Properties.Settings.Default.serverDevicePort.ToString();

            tb_uid.ForeColor = Color.Black;
        }

        private byte[] getMacBytes(string MAC)
        {
            byte[] macBytes = new byte[6];
            string[] macString = MAC.Split('-');

            for(int i=0; i<6; i++)
            {
                macString[i] = "0x" + macString[i];

                macBytes[i] = Convert.ToByte(macString[i], 16);
            }

            return macBytes;
        }

        public string GenerateMACAddress()
        {
            var sBuilder = new StringBuilder();
            var r = new Random();
            int number;
            byte b;
            for (int i = 0; i < 6; i++)
            {
                number = r.Next(0, 255);
                b = Convert.ToByte(number);
                if (i == 0)
                {
                    b = setBit(b, 6); //--> set locally administered
                    b = unsetBit(b, 7); // --> set unicast 
                }
                sBuilder.Append(number.ToString("X2"));

                if (i < 5)
                    sBuilder.Append("-");
            }
            return sBuilder.ToString().ToUpper();
        }

        private byte setBit(byte b, int BitNumber)
        {
            if (BitNumber < 8 && BitNumber > -1)
            {
                return (byte)(b | (byte)(0x01 << BitNumber));
            }
            else
            {
                throw new InvalidOperationException(
                    "The value for BitNumber " + BitNumber + " is not in the permited interval (BitNumber = (min)0 - (max)7)");
            }
        }

        private byte unsetBit(byte b, int BitNumber)
        {
            if (BitNumber < 8 && BitNumber > -1)
            {
                return (byte)(b | (byte)(0x00 << BitNumber));
            }
            else
            {
                throw new InvalidOperationException(
                    "The value for BitNumber " + BitNumber + " is not in the permited interval (BitNumber = (min)0 - (max)7)");
            }
        }

        private void tg_isDHCP_CheckedChanged(object sender, EventArgs e)
        {
            tb_deviceIp.Enabled = !tg_isDHCP.Checked;
        }

        private void tb_mac_Leave(object sender, EventArgs e)
        {
            string temp = tb_mac.Text;

            if (temp.Length == 12)
            {
                temp = temp.Insert(2, "-");
                temp = temp.Insert(5, "-");
                temp = temp.Insert(8, "-");
                temp = temp.Insert(11, "-");
                temp = temp.Insert(14, "-");

                tb_mac.Text = temp;
                tb_mac.ForeColor = Color.Black;
            }
            else if (temp.Length == 17)
            {
                //validar MAC AQUI

                tb_mac.ForeColor = Color.Black;
            }
            else
            {
                tb_mac.ForeColor = Color.Red;
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_newMac_Click(object sender, EventArgs e)
        {
            tb_mac.Text = GenerateMACAddress();
        }
    }
}
