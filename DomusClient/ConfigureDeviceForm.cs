using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
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

            timerCom.Enabled = true;

            insertLog("Incializando comunicação serial...");
            arduinoCom.createConnection();//cria a porta serial para comunicação com o arduino

            insertLog("Watcher Inciado.");
            conectWatch.Enabled = true;//inicia o watcher da conexão
        }

        private void ConfigureDeviceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            arduinoCom.closeConnection();
        }

        private void atualizaListaCOMs()//atualiza as portas COM disponiveis
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            string[] teste = SerialPort.GetPortNames();

            //se a quantidade de portas mudou
            if (cb_coms.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (cb_coms.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            cb_coms.Items.Clear();
            int counter = 0;

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                cb_coms.Items.Add(s);
                counter++;
            }

            //seleciona a primeira posição da lista
            if (counter != 0)//se a lista não estiver vazia
                cb_coms.SelectedIndex = 0;
            else//se a lista estiver vazia
                cb_coms.Items.Add("");
            cb_coms.SelectedIndex = 0;

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
                        tb_deviceIp.Text = temp[6] + "." + temp[7] + "." + temp[8] + "." + temp[9];

                        byte[] tempBytes = { Convert.ToByte(temp[10]), Convert.ToByte(temp[11]), Convert.ToByte(temp[12]), Convert.ToByte(temp[13]), Convert.ToByte(temp[14]), Convert.ToByte(temp[15]) };

                        tb_mac.Text = BitConverter.ToString(tempBytes);

                        tb_mac.ForeColor = Color.Black;

                        tg_isDHCP.Checked = temp[5] == "1";
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

        private void connectionWatcher(object sender, EventArgs e)//monitora o status da conexão com o arduino
        {
            if (arduinoCom.isConnected() && !lastState)//quando o arduino se connectar, reporta
            {
                lastState = arduinoCom.isConnected();//atualiza o ultimo estado do arduino
                conectWatch.Interval = 1000;//intervalo do watcher em ms
            }
            else if (arduinoCom.isConnected() == false && lastState)//se o arduino se desconectar reporta
            {
                insertLog("Dispositivo desconectado :(");
                lastState = arduinoCom.isConnected();//atualiza o ultimo estado do arduino
                conectWatch.Interval = 5000;//intervalo do watcher em ms

                Invoke(new Action(() =>
                {
                    bt_apply.Enabled = false;
                    bt_connect.Enabled = true;
                    cb_coms.Enabled = true;
                    timerCom.Enabled = true;
                }));
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

        private void timerCOM_Tick(object sender, EventArgs e)//a cada x milisegundos executa a função
        {
            atualizaListaCOMs();
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            bt_connect.Enabled = false;
            cb_coms.Enabled = false;

            if (!arduinoCom.openConnection(cb_coms.Items[cb_coms.SelectedIndex].ToString(), 9600))
            {
                bt_connect.Enabled = true;
                cb_coms.Enabled = true;

                insertLog("Erro ao se conectar ao dispositivo.");
            }
            else
            {
                insertLog("Cumprimentando dispositivo...");

                if (arduinoCom.handshake())
                {
                    insertLog("Dispositivo Conectado!");

                    getInfoThread = new Thread(GetDeviceInfos);
                    getInfoThread.Start();

                    bt_apply.Enabled = true;
                    timerCom.Enabled = false;
                }
                else
                {
                    insertLog("Erro ao cumprimentar dispositivo.");

                    arduinoCom.closeConnection();

                    bt_connect.Enabled = true;
                    cb_coms.Enabled = true;
                }
            }
        }
    }
}
