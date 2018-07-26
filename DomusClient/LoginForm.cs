using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomusClient
{
    public partial class LoginForm : Form
    {
        private TcpClient server;
        public bool success = false;//após o login deve ser true

        public LoginForm(TcpClient server)
        {
            InitializeComponent();

            this.server = server;
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            NetworkStream stream;
            Byte[] bytes = new Byte[1024];
            string data;
            int i;
            bool retry = false;

            stream = server.GetStream();

            ServerWrite(stream, "<Login>" + tb_user.Text + ";" + tb_passwd.Text + "<Login>");

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
                                success = true;
                                this.Close();
                                break;
                            }
                            else if (data == "wrongLogin")
                            {
                                MessageBox.Show("Login incorreto.", "Login", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                                retry = true;
                                break;
                            }


                            if (stream.DataAvailable == false)//impede o lock da função
                                break;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                if (success == true)
                    break;
            }

            retry = false;//reseta a varaivel para poder retentar
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            ServerWrite(server.GetStream(),"<exit>");
            this.Close();
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
            catch (Exception)
            {
                return false;
            }
        }
    }
}
