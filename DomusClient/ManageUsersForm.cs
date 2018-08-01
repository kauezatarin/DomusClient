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
using MetroFramework.Forms;
using DomusSharedClasses;
using MetroFramework;

namespace DomusClient
{
    public partial class ManageUsersForm : MetroForm
    {
        private Thread gridThread;
        private EditUserForm editUserForm;

        public ManageUsersForm()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            PopulateGrid();

            //User user =dtg_users.CurrentRow.DataBoundItem as User;
        }

        public void PopulateGrid()
        {
            gridThread = new Thread(() => PopulateGridThread());
            gridThread.Start();

            startSpinner();
        }

        private void PopulateGridThread()
        {
            List<User> users;

            setSpinnerValue(1);

            try
            {
                ServerHandler.ServerWrite(ServerHandler.stream, "listUsers");

                users = (List<User>)ServerHandler.ServerReadSerilized(ServerHandler.stream, 30000);

                Invoke(new Action(() =>
                {
                    dtg_users.DataSource = users;

                    dtg_users.Columns[9].Visible = false;//oculta a coluna de senha

                    //modifica o nome das colunas
                    dtg_users.Columns[0].HeaderText = "ID";
                    dtg_users.Columns[1].HeaderText = "Usuário";
                    dtg_users.Columns[2].HeaderText = "E-Mail";
                    dtg_users.Columns[3].HeaderText = "Nome";
                    dtg_users.Columns[4].HeaderText = "Sobrenome";
                    dtg_users.Columns[5].HeaderText = "Administrador";
                    dtg_users.Columns[6].HeaderText = "Ativo";
                    dtg_users.Columns[7].HeaderText = "Criado em";
                    dtg_users.Columns[8].HeaderText = "Ultimo Login";

                    dtg_users.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
                }));
                
            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, "Não foi possivel recuperar os dados.\r\n" + exception.Message,
                    "Domus Client - Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    150);
            }

            resetSpinner();
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
                    bt_newUser.Enabled = false;
                    bt_edit.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                pb_spinner.Enabled = true;
                bt_newUser.Enabled = false;
                bt_edit.Enabled = false;
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
                    bt_newUser.Enabled = true;
                    bt_edit.Enabled = true;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                pb_spinner.Enabled = false;
                bt_newUser.Enabled = true;
                bt_edit.Enabled = true;
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

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<EditUserForm>().Count() == 0)//verifica se ja existe uma aba aberta
            {
                editUserForm = new EditUserForm(dtg_users.CurrentRow.DataBoundItem as User);//cria o form
                int x = this.Left + (this.Width / 2) - (editUserForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (editUserForm.Height / 2);

                editUserForm.Location = new Point(x, y);//seta a posição do formulario filho

                editUserForm.Show();//mostra o formulario
            }
            else
            {
                editUserForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }
    }
}
