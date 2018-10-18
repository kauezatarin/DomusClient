using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DomusSharedClasses;
using MetroFramework;

namespace DomusClient
{
    public partial class ConfigureDeviceForm : MetroForm
    {
        private Device _device;
        private SerialDataHandler _arduinoCom;
        private bool _lastState = false;//armazena o ultimo estado da conexão (watcher)
        private Thread _getInfoThread;

        public ConfigureDeviceForm(Device device)
        {
            InitializeComponent();

            this._device = device;

            _arduinoCom = new SerialDataHandler();
        }

        private void ConfigureDeviceForm_Load(object sender, EventArgs e)
        {
            tb_uid.Text = _device.DeviceId;
            tb_serverIp.Text = Properties.Settings.Default.serverIp;
            tb_porta.Text = Properties.Settings.Default.serverDevicePort.ToString();

            tb_uid.ForeColor = Color.Black;

            timerCom.Enabled = true;

            InsertLog("Incializando comunicação serial...");
            _arduinoCom.CreateConnection();//cria a porta serial para comunicação com o arduino

            InsertLog("Watcher Inciado.");
            connectWatch.Enabled = true;//inicia o watcher da conexão
        }

        private void ConfigureDeviceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _arduinoCom.CloseConnection();
        }

        private void AtualizaListaCoMs()//atualiza as portas COM disponiveis
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
                if (_arduinoCom.IsConnected())
                {
                    InsertLog("Lendo informações do dispositivo...");
                    string[] temp = _arduinoCom.GetConfig().Split(';');

                    if (temp.Count() == 1)
                    {
                        InsertLog("Erro ao obter as configurações.");

                        _arduinoCom.CloseConnection();

                        return;
                    }

                    Invoke(new Action(() =>
                    {
                        tb_deviceIp.Text = temp[6] + "." + temp[7] + "." + temp[8] + "." + temp[9];

                        byte[] tempBytes = { Convert.ToByte(temp[10]), Convert.ToByte(temp[11]), Convert.ToByte(temp[12]), Convert.ToByte(temp[13]), Convert.ToByte(temp[14]), Convert.ToByte(temp[15]) };

                        tb_mac.Text = BitConverter.ToString(tempBytes);

                        tb_mac.ForeColor = Color.Black;

                        tg_isDHCP.Checked = temp[5] == "1";
                    }));

                    InsertLog("Configurações obtidas.");

                    break;
                }
                else
                {
                    Thread.Sleep(3000);   
                }
            }
        }

        private void InsertLog(string evento)//insere um registro ao LOG
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

        private void ConnectionWatcher(object sender, EventArgs e)//monitora o status da conexão com o arduino
        {
            if (_arduinoCom.IsConnected() && !_lastState)//quando o arduino se connectar, reporta
            {
                _lastState = _arduinoCom.IsConnected();//atualiza o ultimo estado do arduino
                connectWatch.Interval = 1000;//intervalo do watcher em ms
            }
            else if (_arduinoCom.IsConnected() == false && _lastState)//se o arduino se desconectar reporta
            {
                InsertLog("Dispositivo desconectado :(");
                _lastState = _arduinoCom.IsConnected();//atualiza o ultimo estado do arduino
                connectWatch.Interval = 5000;//intervalo do watcher em ms

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

        private byte[] GetMacBytes(string mac)
        {
            byte[] macBytes = new byte[6];
            string[] macString = mac.Split('-');

            for(int i=0; i<6; i++)
            {
                macString[i] = "0x" + macString[i];

                macBytes[i] = Convert.ToByte(macString[i], 16);
            }

            return macBytes;
        }

        private string GenerateMacAddress()
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
                    b = SetBit(b, 6); //--> set locally administered
                    b = UnsetBit(b, 7); // --> set unicast 
                }
                sBuilder.Append(number.ToString("X2"));

                if (i < 5)
                    sBuilder.Append("-");
            }
            return sBuilder.ToString().ToUpper();
        }

        private byte SetBit(byte b, int bitNumber)
        {
            if (bitNumber < 8 && bitNumber > -1)
            {
                return (byte)(b | (byte)(0x01 << bitNumber));
            }
            else
            {
                throw new InvalidOperationException(
                    "The value for BitNumber " + bitNumber + " is not in the permited interval (BitNumber = (min)0 - (max)7)");
            }
        }

        private byte UnsetBit(byte b, int bitNumber)
        {
            if (bitNumber < 8 && bitNumber > -1)
            {
                return (byte)(b | (byte)(0x00 << bitNumber));
            }
            else
            {
                throw new InvalidOperationException(
                    "The value for BitNumber " + bitNumber + " is not in the permited interval (BitNumber = (min)0 - (max)7)");
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
            tb_mac.Text = GenerateMacAddress();

            tb_mac.ForeColor = Color.Black;
        }

        private void timerCOM_Tick(object sender, EventArgs e)//a cada x milisegundos executa a função
        {
            AtualizaListaCoMs();
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            bt_connect.Enabled = false;
            cb_coms.Enabled = false;

            if (cb_coms.Items.Count == 0)
            {
                MetroMessageBox.Show(this,"Selecione um dispositivo primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);

                bt_connect.Enabled = true;
                cb_coms.Enabled = true;
                return;
            }

            if (!_arduinoCom.OpenConnection(cb_coms.Items[cb_coms.SelectedIndex].ToString(), 9600))
            {
                bt_connect.Enabled = true;
                cb_coms.Enabled = true;

                InsertLog("Erro ao se conectar ao dispositivo.");
            }
            else
            {
                InsertLog("Cumprimentando dispositivo...");

                if (_arduinoCom.Handshake())
                {
                    InsertLog("Dispositivo Conectado!");

                    _getInfoThread = new Thread(GetDeviceInfos);
                    _getInfoThread.Start();

                    bt_apply.Enabled = true;
                    timerCom.Enabled = false;
                }
                else
                {
                    InsertLog("Erro ao cumprimentar dispositivo.");

                    _arduinoCom.CloseConnection();

                    bt_connect.Enabled = true;
                    cb_coms.Enabled = true;
                }
            }
        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            string outData = "";
            byte[] mac = GetMacBytes(tb_mac.Text);

            outData += 2 + ";";
            outData += tb_serverIp.Text == "localhost" ? "127;0;0;1" : tb_serverIp.Text.Replace(".",";");
            outData += ";" + tb_porta.Text;
            outData += ";" + Convert.ToInt32(tg_isDHCP.Checked);
            outData += ";" + tb_deviceIp.Text.Replace(".",";");
            outData += ";" + mac[0] + ";" + mac[1] + ";" + mac[2] + ";" + mac[3] + ";" + mac[4] + ";" + mac[5];
            outData += ";" + tb_uid.Text;

            _arduinoCom.SendCommand(outData);

            if (_arduinoCom.GetSuccess())
            {
                MetroMessageBox.Show(this, "Configurações aplicadas.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
                this.Close();
            }
            else
                MetroMessageBox.Show(this, "Não foi possivel obter uma resposta do dispositivo.\r\nAs configurações podem não ter sido aplicadas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);


        }
    }
}
