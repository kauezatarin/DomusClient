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
        private Thread workerThread;
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
        }

        public void PopulateGrid()
        {
            workerThread = new Thread(PopulateGridThread);
            workerThread.Start();

            startSpinner();
        }

        private void PopulateGridThread()
        {
            List<User> users;

            setSpinnerValue(1);

            try
            {
                ServerHandler.ServerWrite(ServerHandler.stream, "ListUsers");

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

        private void DeleteUserThread()
        {
            try
            {
                startSpinner();
                setSpinnerValue(1);

                User temp = dtg_users.CurrentRow.DataBoundItem as User;
                DialogResult result = MetroMessageBox.Show(this,"Gostaria de deletar o usuário " + temp.username + "?\r\nNão será possivel reverter a alteração.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);

                if (result == DialogResult.No)
                {
                    resetSpinner();
                    return;
                }

                ServerHandler.ServerWrite(ServerHandler.stream, "DeleteUser;"+temp.userId, 3000);

                string response = ServerHandler.ServerRead(ServerHandler.stream, 10000);

                if (response == "UserDeleted")
                    MetroMessageBox.Show(this, "Usuário deletado com sucesso.", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Question, 150);
                else if(response == "FailToDelete")
                    MetroMessageBox.Show(this, "Erro ao deletar usuário.", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, 150);
                else
                {
                    MetroMessageBox.Show(this, "Erro inesperado.", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, 150);
                }

                resetSpinner();

                PopulateGrid();
            }
            catch (Exception e)
            {
                resetSpinner();

                MetroMessageBox.Show(this, "Erro ao aplicar alterações. \r\n" + e.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, 150);
            }
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
                    bt_delet.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                pb_spinner.Enabled = true;
                bt_newUser.Enabled = false;
                bt_edit.Enabled = false;
                bt_delet.Enabled = false;
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
                    bt_delet.Enabled = true;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                pb_spinner.Enabled = false;
                bt_newUser.Enabled = true;
                bt_edit.Enabled = true;
                bt_delet.Enabled = true;
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
            try
            {
                if (!Application.OpenForms.OfType<EditUserForm>().Any()) //verifica se ja existe uma aba aberta
                {
                    editUserForm = new EditUserForm(dtg_users.CurrentRow.DataBoundItem as User); //cria o form
                    int x = this.Left + (this.Width / 2) - (editUserForm.Width / 2);
                    int y = this.Top + (this.Height / 2) - (editUserForm.Height / 2);

                    editUserForm.Location = new Point(x, y); //seta a posição do formulario filho

                    editUserForm.Show(); //mostra o formulario
                }
                else
                {
                    MetroMessageBox.Show(this, "Só é possivel realizar uma operação por vez.",
                        "Domus Client - Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        150);

                    editUserForm.Focus(); //caso a janela ja esteja aberta, foca na mesma
                }
            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, "Erro ao editar.\r\n" + exception.Message,
                    "Domus Client - Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    150);
            }
        }

        private void bt_newUser_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<EditUserForm>().Any())//verifica se ja existe uma aba aberta
            {
                editUserForm = new EditUserForm();//cria o form
                int x = this.Left + (this.Width / 2) - (editUserForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (editUserForm.Height / 2);

                editUserForm.Location = new Point(x, y);//seta a posição do formulario filho

                editUserForm.Show();//mostra o formulario
            }
            else
            {
                MetroMessageBox.Show(this, "Só é possivel realizar uma operação por vez.",
                    "Domus Client - Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    150);

                editUserForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void bt_delet_Click(object sender, EventArgs e)
        {
            workerThread = new Thread(DeleteUserThread);
            workerThread.Start();

            startSpinner();
        }
    }
}
