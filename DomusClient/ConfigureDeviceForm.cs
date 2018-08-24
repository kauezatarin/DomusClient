using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DomusSharedClasses;

namespace DomusClient
{
    public partial class ConfigureDeviceForm : MetroForm
    {
        private Device device;
        private SerialDataHandler arduinoCom;
        private Thread searchArduino;
        private bool lastState = false;//armazena o ultimo estado da conexão (watcher)
        private Thread getInfoThread;

        public ConfigureDeviceForm(Device device)
        {
            InitializeComponent();

            this.device = device;

            arduinoCom = new SerialDataHandler();
        }

        private void ConfigureDeviceForm_Load(object sender, EventArgs e)
        {
            tb_uid.Text = device.deviceId;
            tb_serverIp.Text = Properties.Settings.Default.serverIp;
            tb_porta.Text = Properties.Settings.Default.serverDevicePort.ToString();

            tb_uid.ForeColor = Color.Black;

            insertLog("Incializando comunicação serial...");
            arduinoCom.createConnection();//cria a porta serial para comunicação com o arduino

            insertLog("Procurando pelo controlador...");
            searchArduino = new Thread(threadConection);
            searchArduino.Start();//inicia a procura pelo arduino em uma thread separada
            getInfoThread = new Thread(GetDeviceInfos);
            getInfoThread.Start();

            insertLog("Watcher Inciado.");
            conectWatch.Enabled = true;//inicia o watcher da conexão
        }

        private void ConfigureDeviceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            arduinoCom.closeConnection();
        }

        private void GetDeviceInfos()
        {
            while (true)
            {
                if (arduinoCom.isConnected())
                {
                    insertLog("Lendo informações do dispositivo...");
                    string[] temp = arduinoCom.getConfig().Split(';');

                    Invoke(new Action(() =>
                    {
                        tb_deviceIp.Text = temp[0] + "." + temp[1] + "." + temp[2] + "." + temp[3];

                        byte[] tempBytes = { Convert.ToByte(temp[6]), Convert.ToByte(temp[7]), Convert.ToByte(temp[8]), Convert.ToByte(temp[9]), Convert.ToByte(temp[10]), Convert.ToByte(temp[11]) };

                        tb_mac.Text = BitConverter.ToString(tempBytes);
                    }));

                    insertLog("Configurações obtidas.");

                    break;
                }
                else
                {
                    Thread.Sleep(3000);   
                }
            }
        }

        private void insertLog(string evento)//insere um registro ao LOG
        {
            if (tb_log.InvokeRequired)
            {
                Invoke(new Action(() => { tb_log.AppendText(Environment.NewLine + DateTime.Now + "  " + evento); }));
            }
            else
            {
                tb_log.AppendText(Environment.NewLine + DateTime.Now + "  " + evento);
            }

        }

        private void threadConection()
        {
            arduinoCom.autoConnection(9600);//inicia a procura e conexão automatica com o arduino
        }

        private void connectionWatcher(object sender, EventArgs e)//monitora o status da conexão com o arduino
        {
            if (arduinoCom.isConnected() && !lastState)//quando o arduino se connectar, reporta
            {
                insertLog("LED Controller Conectado! (" + arduinoCom.actualCOMPtor() + ")");
                lastState = arduinoCom.isConnected();//atualiza o ultimo estado do arduino
                conectWatch.Interval = 1000;//intervalo do watcher em ms
            }
            else if (arduinoCom.isConnected() == false && lastState)//se o arduino se desconectar reporta
            {
                insertLog("LED Controller desconectado :(");
                lastState = arduinoCom.isConnected();//atualiza o ultimo estado do arduino
                conectWatch.Interval = 5000;//intervalo do watcher em ms
            }
            else if (arduinoCom.isConnected() == false && searchArduino.IsAlive == false)//realiza a pesquisa automatica caso o arduino não seja encontrado
            {
                searchArduino = new Thread(threadConection);
                searchArduino.Start();
            }
        }

        private bool ValidateMac(string mac)
        {
            Regex r = new Regex("^([0-9a-fA-F]{2}(?:[-]?[0-9a-fA-F]{2}){5})$");

            return r.IsMatch(mac);
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

        private string GenerateMACAddress()
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
                tb_mac.ForeColor = ValidateMac(tb_mac.Text) ? Color.Black : Color.Red;
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

            tb_mac.ForeColor = Color.Black;
        }
    }
}
