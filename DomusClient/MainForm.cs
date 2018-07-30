using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace DomusClient
{
    public partial class MainForm : MetroForm
    {
        private TcpClient server;
        private LoginForm loginForm;
        private NetworkStream stream;

        public MainForm()
        {
            InitializeComponent();
        }

        private TcpClient Connect(String ip, int port = 9090)
        {
            TcpClient client = new TcpClient();

            try
            {
                client.Connect(ip, port);
            }
            catch (Exception e)
            {
                throw e;
            }

            return client;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                server = Connect("127.0.0.1", 9090);

                stream = server.GetStream();

                /*string data;
                int i;
                Byte[] bytes = new Byte[1024];

                while (server.Connected)
                {
                    data = null;

                    // Get a stream object for reading and writing
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

                                

                                if (stream.DataAvailable == false)//impede o lock da função
                                    break;
                            }
                        }
                        catch (Exception)
                        {
                            //implementar escessão
                        }
                    }

                }*/

            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possivel conectar ao servidor.\r\n" + exception.Message, "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();
            }

            loginForm = new LoginForm(server);

            loginForm.ShowDialog();

            if (!loginForm.success)//se o login falhar encerra o programa
                this.Close();
            else
            {
                loginForm.Dispose();
            }
        }

        //Função que envia mensagens ao cliente conectado
        private static bool ServerWrite(NetworkStream stream, String message)
        {
            try
            {
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
                stream.Write(msg, 0, msg.Length);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                server.Close();
                server.Dispose();
            }
            catch (Exception)
            {

            }

        }
    }
}
