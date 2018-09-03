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
        private Thread _loginManager;

        public LoginForm()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        private void LoginRoutine()
        {
            NetworkStream stream;
            Byte[] bytes = new Byte[1024];
            string data;
            bool retry = false;
            bool success = false;
            bool receivingSerial = false;

            Invoke(new Action(() =>
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                bt_login.Enabled = false;
            }));

            try
            {
                stream = ServerHandler.Stream;
            }
            catch
            {
                try
                {
                    ServerHandler.Connect();

                    stream = ServerHandler.Stream;

                }
                catch
                {
                    MetroMessageBox.Show(this, "A conexão com o servidor foi perdida",
                        "Conexão Perdida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        100);

                    ResetSpinner();

                    return;
                }
            }

            if (!ServerHandler.ServerWrite(stream, "<Login>" + tb_user.Text + ";" + tb_passwd.Text + "<Login>", 1000))
            {
                MetroMessageBox.Show(this, "A conexão com o servidor foi perdida",
                    "Conexão Perdida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    100);

                ResetSpinner();

                return;
            }

            while (ServerHandler.Server.Connected && retry == false)
            {
                stream = ServerHandler.Stream;

                if (stream.DataAvailable) //se houver dados a serem lidos
                {
                    try
                    {
                        // Translate data bytes to a ASCII string.
                        data = ServerHandler.ServerRead(ServerHandler.Stream, 10000);

                        if (data == "sucessfullLogin")
                        {
                            //solicita as informações do usuário
                            ServerHandler.ServerWrite(stream, "<SendUser>", 10000);

                            SetSpinnerValue(1);

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

                            ResetSpinner();

                            break;
                        }

                        if (receivingSerial)
                        {
                            SetSpinnerValue(2);

                            Application.OpenForms.OfType<MainForm>().First().User = (User) ServerHandler.ServerReadSerilized(stream, 30000);

                            receivingSerial = false;
                            success = true;

                            SetSpinnerValue(3);

                            Invoke(new Action(() =>
                            {
                                this.Close();
                            }));
                        }
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "Não foi possivel realizar o login.\r\n Verifique a conexão com o servidor e tente novamente.",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            100);

                        ResetSpinner();

                        return;
                    }
                }
                if (success)
                    break;
            }

            retry = false;//reseta a varaivel para poder retentar
        }

        private void ResetSpinner()
        {
            if (pb_spinner.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pb_spinner.Value = 0;
                    pb_spinner.Visible = false;
                    bt_login.Enabled = true;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                bt_login.Enabled = true;
            }
        }

        private void SetSpinnerValue(int value)
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
            ServerHandler.ServerWrite(ServerHandler.Stream, "<exit>");
            this.Hide();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            _loginManager = new Thread(() => LoginRoutine());
            _loginManager.Start();
        }
    }
}
