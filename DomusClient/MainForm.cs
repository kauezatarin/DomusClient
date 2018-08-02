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
        private ManageUsersForm manageUsersForm;
        private ConfigForm configForm;
        public User user;

        public MainForm()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
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
                MetroMessageBox.Show(this,
                    "Não foi possivel conectar ao servidor.\r\n" + exception.SocketErrorCode + " - " +
                    exception.Message,
                    "Domus Client - Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    150);

                this.Close();
            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this,
                    "Não foi possivel conectar ao servidor.\r\n" + exception.Message,
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

        private void bt_users_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ManageUsersForm>().Count() == 0)//verifica se ja existe uma aba aberta
            {
                manageUsersForm = new ManageUsersForm();//cria o form
                int x = this.Left + (this.Width / 2) - (manageUsersForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (manageUsersForm.Height / 2);

                manageUsersForm.Location = new Point(x, y);//seta a posição do formulario filho

                manageUsersForm.Show();//mostra o formulario
            }
            else
            {
                manageUsersForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void bt_settings_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ConfigForm>().Count() == 0)//verifica se ja existe uma aba aberta
            {
                configForm = new ConfigForm();//cria o form
                int x = this.Left + (this.Width / 2) - (configForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (configForm.Height / 2);

                configForm.Location = new Point(x, y);//seta a posição do formulario filho

                configForm.Show();//mostra o formulario
            }
            else
            {
                configForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }
    }
}
