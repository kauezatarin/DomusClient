using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DomusSharedClasses;

namespace DomusClient
{
    public partial class EditUserForm : MetroForm
    {
        private User user;

        public EditUserForm(User user)
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;

            this.user = user;
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

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {

        }

        private void bt_resetPasswd_Click(object sender, EventArgs e)
        {

        }
    }
}
