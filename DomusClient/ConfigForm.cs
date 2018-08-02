using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace DomusClient
{
    public partial class ConfigForm : MetroForm
    {
        private Thread workerThread;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            tb_serverIp.Text = Properties.Settings.Default.serverIp;
            tb_serverPort.Text = Properties.Settings.Default.serverPort.ToString();
        }

        private void startSpinner()
        {
            if (pb_spinner.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pb_spinner.Value = 0;
                    pb_spinner.Visible = true;
                    pb_spinner.Enabled = true;
                    bt_save.Enabled = false;
                    bt_changePasswd.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                pb_spinner.Enabled = true;
                bt_save.Enabled = false;
                bt_changePasswd.Enabled = false;
            }
        }

        private void resetSpinner()
        {
            if (pb_spinner.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pb_spinner.Value = 0;
                    pb_spinner.Visible = false;
                    pb_spinner.Enabled = false;
                    bt_save.Enabled = false;
                    bt_changePasswd.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                pb_spinner.Enabled = false;
                bt_save.Enabled = false;
                bt_changePasswd.Enabled = false;
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

        private bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }

        private bool ValidatePasswdForm()
        {
            bool result = !(tb_passwd.Text.Length < 8 || tb_newPasswd.Text.Length < 8 || tb_newPasswd.Text != tb_confNewPasswd.Text);

            return result;
        }

        private void ChangePasswdThread()
        {
            if (!ValidatePasswdForm())
            {
                MetroMessageBox.Show(this, "Preencha todos os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
                resetSpinner();

                return;
            }

            setSpinnerValue(1);

            ServerHandler.ServerWrite(ServerHandler.stream, "ChangePasswd;" + BCrypt.Net.BCrypt.HashPassword(tb_passwd.Text) + BCrypt.Net.BCrypt.HashPassword(tb_newPasswd.Text), 10000);

            string response = ServerHandler.ServerRead(ServerHandler.stream, 10000);

            if (response == "PasswdChanged")
            {
                MetroMessageBox.Show(this, "Usuário atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
            }
            else if (response == "InvalidOldPasswd")
            {
                MetroMessageBox.Show(this, "Não foi possivel alterar a senha.\r\nSenha atual incorreta.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
            else if (response == "FailToChangePasswd")
            {
                MetroMessageBox.Show(this, "Não foi possivel alterar a senha.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
            else
            {
                MetroMessageBox.Show(this, "Erro inesperado.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (ValidateIPv4(tb_serverIp.Text) && (Convert.ToInt32(tb_serverPort.Text) <= 65535) && (Convert.ToInt32(tb_serverPort.Text) >= 0))
            {
                Properties.Settings.Default.serverIp = tb_serverIp.Text;
                Properties.Settings.Default.serverPort = Convert.ToInt32(tb_serverPort.Text);

                MetroMessageBox.Show(this, "Configurações salvas.",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question, 150);

                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this,"Endereço IP ou porta incorretos.\r\nVerifique os campos e tente novamente.", 
                    "Inválido", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning, 150);
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_changePasswd_Click(object sender, EventArgs e)
        {
            workerThread = new Thread(ChangePasswdThread);

            workerThread.Start();
        }
    }
}
