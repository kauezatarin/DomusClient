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
using DomusSharedClasses;
using MetroFramework;

namespace DomusClient
{
    public partial class MainForm : MetroForm
    {
        private LoginForm loginForm;
        public User user;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                //inicializa a classe de conexão com o servidor
                ServerHandler.Initialize();
                ServerHandler.Connect();
            }
            catch (SocketException exception)
            {
                MetroMessageBox.Show(this, "Não foi possivel conectar ao servidor.\r\n" + exception.SocketErrorCode + " - " + exception.Message,
                    "Domus Client - Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error,
                    150);

                this.Close();
            }

            loginForm = new LoginForm();

            loginForm.ShowDialog();

            loginForm.Dispose();

            if (user == null) //se o login falhar encerra o programa
            {
                this.Close();
            }

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ServerHandler.ServerWrite(ServerHandler.stream, "<exit>");
                ServerHandler.Dispose();
            }
            catch
            {

            }

        }

        private void bt_devices_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Função ainda não implementada.",
                "Domus Client - Em breve",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
