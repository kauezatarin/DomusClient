using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DomusSharedClasses;
using MetroFramework;

namespace DomusClient
{
    public partial class LoginForm : MetroForm
    {
        private TcpClient server;
        private Thread loginManager;

        public LoginForm(TcpClient server)
        {
            InitializeComponent();

            this.server = server;
        }

        private async void loginRoutine()
        {
            NetworkStream stream;
            Byte[] bytes = new Byte[1024];
            string data;
            int i;
            bool retry = false;
            bool success = false;
            bool receivingSerial = false;

            Invoke(new Action(() =>
            {
                pb_spinner.Value = 0;
                pb_spinner.Minimum = 0;
                pb_spinner.Maximum = 3;
                pb_spinner.Visible = true;
                bt_login.Enabled = false;
            }));

            try
            {
                stream = server.GetStream();
            }
            catch
            {
                try
                {
                    server.Connect("localhost",9090);

                    stream = server.GetStream();

                    //MODIFICAR
                }
                catch
                {
                    MetroMessageBox.Show(this, "A conexão com o servidor foi perdida",
                        "Conexão Perdida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        100);

                    resetSpinner();

                    return;
                }
            }

            if (!ServerWrite(stream, "<Login>" + tb_user.Text + ";" + tb_passwd.Text + "<Login>", 10000))
            {
                MetroMessageBox.Show(this, "A conexão com o servidor foi perdida",
                    "Conexão Perdida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    100);

                resetSpinner();

                return;
            }

            while (server.Connected && retry == false)
            {
                data = null;

                stream = server.GetStream();

                if (stream.DataAvailable) //se houver dados a serem lidos
                {
                    try
                    {
                        // Loop to receive all the data sent by the client
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            // Translate data bytes to a ASCII string.
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);

                            if (data == "sucessfullLogin")
                            {
                                //solicita as informações do usuário
                                ServerWrite(stream, "<SendUser>", 10000);

                                setSpinnerValue(1);

                                receivingSerial = true;
                            }
                            else if (data == "wrongLogin")
                            {
                                MetroMessageBox.Show(this, "Login incorreto.",
                                    "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    100);
                                retry = true;

                                resetSpinner();

                                break;
                            }

                            if (receivingSerial)
                            {
                                setSpinnerValue(2);

                                Application.OpenForms.OfType<MainForm>().First().user = (User) await ServerReadSerilizedAssync(stream, 30000);

                                receivingSerial = false;
                                success = true;

                                setSpinnerValue(3);

                                Invoke(new Action(() =>
                                {
                                    this.Hide();
                                }));
                            }

                            if (stream.DataAvailable == false)//impede o lock da função
                                break;
                        }
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "Não foi possivel realizar o login.\r\n Verifique a conexão com o servidor e tente novamente.",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            100);

                        resetSpinner();

                        return;
                    }
                }
                if (success)
                    break;
            }

            retry = false;//reseta a varaivel para poder retentar
        }

        //Função que envia mensagens ao cliente conectado
        private static bool ServerWrite(NetworkStream stream, String message, int timeout = -1)
        {
            try
            {
                stream.WriteTimeout = timeout;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
                stream.Write(msg, 0, msg.Length);
                stream.WriteTimeout = -1;

                return true;
            }
            catch
            {
                stream.WriteTimeout = -1;
                return false;
            }
        }

        private async Task<object> ServerReadSerilizedAssync(NetworkStream stream, int timeout = -1)
        {
            byte[] readMsgLen = new byte[4];
            int dataLen;
            byte[] readMsgData;
            BinaryFormatter bf1 = new BinaryFormatter();
            MemoryStream ms;

            //seta o timeout de leitura dos dados para 30 segundos
            stream.ReadTimeout = timeout;

            //le o tamanho dos dados que serão recebidos
            stream.Read(readMsgLen, 0, 4);
            dataLen = BitConverter.ToInt32(readMsgLen, 0);
            readMsgData = new byte[dataLen];

            //le os dados que estão sendo recebidos
            stream.Read(readMsgData, 0, dataLen);

            ms = new MemoryStream(readMsgData);
            ms.Position = 0;

            //converte os dados recebidos para um objeto
            object objeto = bf1.Deserialize(ms);

            //seta o timeout para o valor padrão (infinito)
            stream.ReadTimeout = -1;
            
            return objeto;
        }

        private void resetSpinner()
        {
            if (pb_spinner.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pb_spinner.Value = 0;
                    pb_spinner.Visible = false;
                    bt_login.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                bt_login.Enabled = false;
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

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            ServerWrite(server.GetStream(), "<exit>");
            this.Hide();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            loginManager = new Thread(() => loginRoutine());
            loginManager.Start();
        }

    }
}
