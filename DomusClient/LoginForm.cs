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

        public LoginForm(TcpClient server)
        {
            InitializeComponent();

            this.server = server;
        }

        private async void bt_login_ClickAsync(object sender, EventArgs e)
        {
            NetworkStream stream;
            Byte[] bytes = new Byte[1024];
            string data;
            int i;
            bool retry = false;
            bool success = false;
            bool receivingSerial = false;

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
                                //solicita as informações do usuário
                                ServerWrite(stream, "<SendUser>");

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
                                break;
                            }

                            if (receivingSerial)
                            { 
                                Application.OpenForms.OfType<MainForm>().First().user = (User) await ServerReadSerilizedAssync(stream);

                                receivingSerial = false;
                                success = true;
                                this.Hide();
                            }

                            if (stream.DataAvailable == false)//impede o lock da função
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                if (success)
                    break;
            }

            retry = false;//reseta a varaivel para poder retentar
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            ServerWrite(server.GetStream(), "<exit>");
            this.Hide();
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

        private async Task<object> ServerReadSerilizedAssync(NetworkStream stream)
        {
            byte[] readMsgLen = new byte[4];
            int dataLen;
            byte[] readMsgData;
            BinaryFormatter bf1 = new BinaryFormatter();
            MemoryStream ms;

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
            
            return objeto;
        }
    }
}
