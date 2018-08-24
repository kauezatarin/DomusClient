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
        private SerialPort serialPort = null;//porta serial
        private List<string> RxString = new List<string>();//string recebida pela serial
        private bool isHandshaking = false;
        private bool ardcuinoConnected = false;
        private Thread waitRx;
        private string actualCOM = "";

        public bool createConnection()//cria a instancia da porta serial
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceived);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool openConnection(string portName, int baudRate)//inicia a conexão com o arduino
        {
            if (serialPort != null && serialPort.IsOpen == false)//se a conexão estive fechada
            {
                try
                {
                    serialPort.PortName = portName;
                    serialPort.BaudRate = baudRate;

                    serialPort.Open();

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

        public void closeConnection()//encerra a conexão (a instancia continua existindo)
        {
            if (serialPort != null && serialPort.IsOpen == true)  // se porta aberta
            {
                ardcuinoConnected = false;
                serialPort.Close();         //fecha a porta
            }
            else if (serialPort != null && serialPort.IsOpen == false)//se a porta estiver fachada, apenas assinala
                ardcuinoConnected = false;
        }

        public string getConfig()//le as configurações do controlador
        {
            string conf = "";
            RxString.Clear();

            sendCommand("1");//solicita as informações para o arduino

            waitRx = new Thread(isRxEmpty);

            waitRx.Start();

            waitRx.Join();//aguarda o arduino responder

            conf = RxString[0];

            if (separatorCount(conf) < 17)
            {
                waitRx = new Thread(isRxEmpty);

                waitRx.Start();

                waitRx.Join();//aguarda o arduino responder

                conf += RxString[1];
            }

            return conf;
        }

        public bool autoConnection(int baudRate) //procura o arduino e conecta automaticamente com ele
        {
            string[] coms = getComAvailable();
            int lenght = SerialPort.GetPortNames().Length;

            foreach (string com in getComAvailable()) //caso a verificação anterior falhe, tenta localizar o arduino novamente
            {
                if (openConnection(com, baudRate) == true) //se a conexão for estabelecida
                {
                    serialPort.DtrEnable = true;
                    serialPort.DtrEnable = false;

                    Thread.Sleep(10000);

                    isHandshaking = true;
                    sendCommand("0"); //envia o handshake

                    Thread.Sleep(2000); //dá 2 segundos para o arduio responder

                    if (RxString.Contains("domus") == true) //verifica se o handshake funcionou
                    {
                        isHandshaking = false;
                        ardcuinoConnected = true;
                        return true;
                    }
                    else
                    {
                        closeConnection();
                    }

                    isHandshaking = false;
                }
            }

            return false;
        }

        private int separatorCount(string data)
        {
            string[] array = data.Split(';');

            return array.Length;
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)//serial port
        {
            RxString.Add(serialPort.ReadExisting());              //le o dado disponível na serial
        }

        public void sendCommand(string str)//envia os comandos pela serial
        {
            if (serialPort != null)//se a porta já estiver criada
            {
                if (serialPort.IsOpen == true)//porta está aberta
                {
                    serialPort.Write(str);  //envia o texto presente na variavel str
                }
                else
                {
                    isDisconnected(); //detecta que o dispositivo foi desconectado
                }
            }
        }

        public bool isConnected()//informa se o arduino está conectado
        {
            if (serialPort.IsOpen == false && ardcuinoConnected == true)//verifica a autenticidade da informação
            {
                ardcuinoConnected = false;

                return ardcuinoConnected;
            }
            else//se as informações baterem
            {
                return ardcuinoConnected;
            }

        }

        private void isDisconnected()//se o dispositivo for desconectado
        {
            try
            {
                serialPort.Close();
                ardcuinoConnected = false;
            }
            catch
            {
                return;
            }
        }

        private void isRxEmpty()
        {
            int i = 0;

            while (i < 10)
            {
                if (RxString.Count == 0)
                {
                    i++;
                    Thread.Sleep(1000);
                }
                else
                    break;

            }
        }

        private string[] getComAvailable()//retorna uma lista com todas as postas COM
        {
            return SerialPort.GetPortNames();
        }

        public string actualCOMPtor()//retorna a COM onde o arduino está
        {
            return actualCOM;
        }
    }
}
