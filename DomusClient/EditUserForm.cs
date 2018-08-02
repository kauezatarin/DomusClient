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
using System.ComponentModel.DataAnnotations;

namespace DomusClient
{
    public partial class EditUserForm : MetroForm
    {
        private User user;
        private Thread workerThread;

        public EditUserForm(User user)
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;

            tb_passwd.Enabled = false;

            this.user = user;

            PopulateForm();

        }

        public EditUserForm()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;

            this.Text = "Novo Usuário";
            bt_save.Text = "Cadastrar";
            bt_resetPasswd.Visible = false;
        }

        private void PopulateForm()
        {
            tb_name.Text = user.name;
            tb_lastName.Text = user.lastName;
            tb_username.Text = user.username;
            tb_email.Text = user.email;

            tg_active.Checked = user.isActive;
            tg_admin.Checked = user.isAdmin;
        }

        private void SaveThread()
        {
            try
            {
                startSpinner();

                setSpinnerValue(1);

                //caso esteja no modo de edição
                if (user != null)
                {
                    if(!ValidateForm())
                    {
                        MetroMessageBox.Show(this, "Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
                        resetSpinner();

                        return;
                    }

                    setSpinnerValue(2);

                    user = new User(tb_username.Text, tb_email.Text, tb_name.Text, tb_lastName.Text, tg_admin.Checked, tg_active.Checked, DateTime.Now.ToString(), DateTime.Now.ToString(), user.password, user.userId);

                    ServerHandler.ServerWrite(ServerHandler.stream, "UpdateUser", 10000);

                    if(ServerHandler.ServerRead(ServerHandler.stream, 10000) == "sendUser")
                        ServerHandler.ServerWriteSerialized(ServerHandler.stream, user, 10000);
                    else
                    {
                        throw new Exception("Resposta inesperada.");
                    }

                    string response = ServerHandler.ServerRead(ServerHandler.stream, 10000);

                    if (response == "UserUpdated")
                    {
                        MetroMessageBox.Show(this,"Usuário atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
                    }
                    else if (response == "FailToUpdate")
                    {
                        MetroMessageBox.Show(this, "Não foi possivel atualizar o usuário.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Erro inesperado.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                    }
                }
                //caso esteja no modo de cadastro
                else
                {
                    if (!ValidateForm(true))
                    {
                        MetroMessageBox.Show(this, "Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
                        resetSpinner();

                        return;
                    }

                    setSpinnerValue(2);

                    user = new User(tb_username.Text, tb_email.Text, tb_name.Text, tb_lastName.Text, tg_admin.Checked, tg_active.Checked, DateTime.Now.ToString(), DateTime.Now.ToString(), BCrypt.Net.BCrypt.HashPassword(tb_passwd.Text));

                    ServerHandler.ServerWrite(ServerHandler.stream, "AddUser", 10000);

                    if (ServerHandler.ServerRead(ServerHandler.stream, 10000) == "sendNewUser")
                        ServerHandler.ServerWriteSerialized(ServerHandler.stream, user, 10000);
                    else
                    {
                        throw new Exception("Resposta inesperada.");
                    }

                    string response = ServerHandler.ServerRead(ServerHandler.stream, 10000);

                    if (response == "UserAdded")
                    {
                        MetroMessageBox.Show(this, "Usuário cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
                    }
                    else if (response == "FailToAdd")
                    {
                        MetroMessageBox.Show(this, "Não foi possivel cadastrar o usuário.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Erro inesperado.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                    }
                }

                resetSpinner();

                Application.OpenForms.OfType<ManageUsersForm>().First().PopulateGrid();

                Invoke(new Action(() =>
                {
                    Application.OpenForms.OfType<EditUserForm>().First().Close();
                }));
            }
            catch (Exception e)
            {
                resetSpinner();

                MetroMessageBox.Show(this, "Erro ao aplicar alterações. \r\n" + e.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        private bool ValidateForm(bool validatePasswd = false)
        {
            bool result = true;
            List<string> tempList = new List<string>();

            tempList.Add(tb_name.Text.Replace(" ", ""));
            tempList.Add(tb_lastName.Text.Replace(" ", ""));
            tempList.Add(tb_username.Text.Replace(" ", ""));

            foreach (string s in tempList)
            {
                if (s.Length < 3)
                {
                    result = false;
                    break;
                }
            }

            if (validatePasswd && (tb_passwd.Text.Length < 8 || tb_passwd.Text.Contains(" ")))
                result = false;

            if (new EmailAddressAttribute().IsValid(tb_email.Text) == false)
                result = false;

            return result;
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
                    bt_resetPasswd.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                pb_spinner.Enabled = true;
                bt_save.Enabled = false;
                bt_resetPasswd.Enabled = false;
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
                    bt_save.Enabled = true;
                    bt_resetPasswd.Enabled = true;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                pb_spinner.Enabled = false;
                bt_save.Enabled = true;
                bt_resetPasswd.Enabled = true;
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
            this.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            this.workerThread = new Thread(()=>SaveThread());
            this.workerThread.Start();
        }

        private void bt_resetPasswd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
