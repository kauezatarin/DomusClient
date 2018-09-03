using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DomusClient
{
    public class SerialDataHandler
    {
        private SerialPort _serialPort = null;//porta serial
        private List<string> _rxString = new List<string>();//string recebida pela serial
        private bool _ardcuinoConnected = false;
        private Thread _waitRx;
        private string _actualCom = "";

        public bool CreateConnection()//cria a instancia da porta serial
        {
            try
            {
                _serialPort = new SerialPort();
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
                _serialPort.NewLine = "\r\n";
                _serialPort.DiscardInBuffer();
                _serialPort.DiscardOutBuffer();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool OpenConnection(string portName, int baudRate)//inicia a conexão com o arduino
        {
            if (_serialPort != null && _serialPort.IsOpen == false)//se a conexão estive fechada
            {
                try
                {
                    _serialPort.PortName = portName;
                    _serialPort.BaudRate = baudRate;

                    _serialPort.Open();

                    Thread.Sleep(1000);//da um tempo para o arduino reiniciar caso ocorra

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public void CloseConnection()//encerra a conexão (a instancia continua existindo)
        {
            if (_serialPort != null && _serialPort.IsOpen == true)  // se porta aberta
            {
                _ardcuinoConnected = false;
                _serialPort.Close();         //fecha a porta
            }
            else if (_serialPort != null && _serialPort.IsOpen == false)//se a porta estiver fachada, apenas assinala
                _ardcuinoConnected = false;
        }

        public string GetConfig()//le as configurações do controlador
        {
            string conf = "";
            _rxString.Clear();

            SendCommand("1");//solicita as informações para o arduino

            _waitRx = new Thread(IsRxEmpty);

            _waitRx.Start();

            _waitRx.Join(15000);//aguarda o arduino responder

            conf = _rxString[0];
            _rxString.RemoveAt(0);

            if (SeparatorCount(conf) < 17)
            {
                _waitRx = new Thread(IsRxEmpty);

                _waitRx.Start();

                _waitRx.Join(15000);//aguarda o arduino responder

                foreach (string s in _rxString)
                {
                    conf += s;
                }
            }

            return conf;
        }

        public bool Handshake()
        {
            try
            {
                string response = "";
                _rxString.Clear();

                SendCommand("0");

                _waitRx = new Thread(IsRxEmpty);

                _waitRx.Start();

                _waitRx.Join(15000);//aguarda o arduino responder

                response = _rxString[0];

                _ardcuinoConnected = response == "domus";

                return _ardcuinoConnected;
            }
            catch
            {
                return false;
            }
        }

        public bool GetSuccess()
        {
            try
            {
                string response = "";
                _rxString.Clear();

                _waitRx = new Thread(IsRxEmpty);

                _waitRx.Start();

                _waitRx.Join(15000);//aguarda o arduino responder

                response = _rxString[0];

                _ardcuinoConnected = response == "ok";

                return _ardcuinoConnected;
            }
            catch
            {
                return false;
            }
        }

        private int SeparatorCount(string data)
        {
            string[] array = data.Split(';');

            return array.Length;
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)//serial port
        {
            _rxString.Add(_serialPort.ReadLine());//le o dado disponível na serial
        }

        public void SendCommand(string str)//envia os comandos pela serial
        {
            if (_serialPort != null)//se a porta já estiver criada
            {
                if (_serialPort.IsOpen == true)//porta está aberta
                {
                    _serialPort.Write(str);  //envia o texto presente na variavel str
                }
                else
                {
                    IsDisconnected(); //detecta que o dispositivo foi desconectado
                }
            }
        }

        public bool IsConnected()//informa se o arduino está conectado
        {
            if (_serialPort.IsOpen == false && _ardcuinoConnected == true)//verifica a autenticidade da informação
            {
                _ardcuinoConnected = false;

                return _ardcuinoConnected;
            }
            else//se as informações baterem
            {
                return _ardcuinoConnected;
            }

        }

        private void IsDisconnected()//se o dispositivo for desconectado
        {
            try
            {
                _serialPort.Close();
                _ardcuinoConnected = false;
            }
            catch
            {
                return;
            }
        }

        private void IsRxEmpty()
        {
            while (true)
            {
                if (_rxString.Count == 0)
                {
                    Thread.Sleep(1000);
                }
                else
                {
                    Thread.Sleep(1000);
                    break;
                }
            }
        }

        private string[] GetComAvailable()//retorna uma lista com todas as postas COM
        {
            return SerialPort.GetPortNames();
        }

        public string ActualComPtor()//retorna a COM onde o arduino está
        {
            return _actualCom;
        }
    }
}
