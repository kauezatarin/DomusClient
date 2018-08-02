namespace DomusClient
{
    partial class EditUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tb_username = new MetroFramework.Controls.MetroTextBox();
            this.tb_passwd = new MetroFramework.Controls.MetroTextBox();
            this.lb_passwd = new MetroFramework.Controls.MetroLabel();
            this.tb_name = new MetroFramework.Controls.MetroTextBox();
            this.lb_name = new MetroFramework.Controls.MetroLabel();
            this.tb_lastName = new MetroFramework.Controls.MetroTextBox();
            this.lb_lastName = new MetroFramework.Controls.MetroLabel();
            this.tb_email = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.bt_resetPasswd = new MetroFramework.Controls.MetroButton();
            this.bt_cancel = new MetroFramework.Controls.MetroButton();
            this.bt_save = new MetroFramework.Controls.MetroButton();
            this.tg_admin = new MetroFramework.Controls.MetroToggle();
            this.lb_isAdmin = new MetroFramework.Controls.MetroLabel();
            this.lb_isActive = new MetroFramework.Controls.MetroLabel();
            this.tg_active = new MetroFramework.Controls.MetroToggle();
            this.pb_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuário:";
            // 
            // tb_username
            // 
            // 
            // 
            // 
            this.tb_username.CustomButton.Image = null;
            this.tb_username.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.tb_username.CustomButton.Name = "";
            this.tb_username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_username.CustomButton.TabIndex = 1;
            this.tb_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_username.CustomButton.UseSelectable = true;
            this.tb_username.CustomButton.Visible = false;
            this.tb_username.Lines = new string[0];
            this.tb_username.Location = new System.Drawing.Point(101, 73);
            this.tb_username.MaxLength = 32767;
            this.tb_username.Name = "tb_username";
            this.tb_username.PasswordChar = '\0';
            this.tb_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_username.SelectedText = "";
            this.tb_username.SelectionLength = 0;
            this.tb_username.SelectionStart = 0;
            this.tb_username.ShortcutsEnabled = true;
            this.tb_username.Size = new System.Drawing.Size(155, 23);
            this.tb_username.TabIndex = 1;
            this.tb_username.UseSelectable = true;
            this.tb_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_passwd
            // 
            // 
            // 
            // 
            this.tb_passwd.CustomButton.Image = null;
            this.tb_passwd.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.tb_passwd.CustomButton.Name = "";
            this.tb_passwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_passwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_passwd.CustomButton.TabIndex = 1;
            this.tb_passwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_passwd.CustomButton.UseSelectable = true;
            this.tb_passwd.CustomButton.Visible = false;
            this.tb_passwd.Lines = new string[0];
            this.tb_passwd.Location = new System.Drawing.Point(322, 73);
            this.tb_passwd.MaxLength = 32767;
            this.tb_passwd.Name = "tb_passwd";
            this.tb_passwd.PasswordChar = '●';
            this.tb_passwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_passwd.SelectedText = "";
            this.tb_passwd.SelectionLength = 0;
            this.tb_passwd.SelectionStart = 0;
            this.tb_passwd.ShortcutsEnabled = true;
            this.tb_passwd.Size = new System.Drawing.Size(155, 23);
            this.tb_passwd.TabIndex = 3;
            this.tb_passwd.UseSelectable = true;
            this.tb_passwd.UseSystemPasswordChar = true;
            this.tb_passwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_passwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_passwd
            // 
            this.lb_passwd.AutoSize = true;
            this.lb_passwd.Location = new System.Drawing.Point(269, 77);
            this.lb_passwd.Name = "lb_passwd";
            this.lb_passwd.Size = new System.Drawing.Size(47, 19);
            this.lb_passwd.TabIndex = 2;
            this.lb_passwd.Text = "Senha:";
            // 
            // tb_name
            // 
            // 
            // 
            // 
            this.tb_name.CustomButton.Image = null;
            this.tb_name.CustomButton.Location = new System.Drawing.Point(354, 1);
            this.tb_name.CustomButton.Name = "";
            this.tb_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_name.CustomButton.TabIndex = 1;
            this.tb_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_name.CustomButton.UseSelectable = true;
            this.tb_name.CustomButton.Visible = false;
            this.tb_name.Lines = new string[0];
            this.tb_name.Location = new System.Drawing.Point(101, 137);
            this.tb_name.MaxLength = 32767;
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_name.SelectedText = "";
            this.tb_name.SelectionLength = 0;
            this.tb_name.SelectionStart = 0;
            this.tb_name.ShortcutsEnabled = true;
            this.tb_name.Size = new System.Drawing.Size(376, 23);
            this.tb_name.TabIndex = 5;
            this.tb_name.UseSelectable = true;
            this.tb_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(46, 141);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(49, 19);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "Nome:";
            // 
            // tb_lastName
            // 
            // 
            // 
            // 
            this.tb_lastName.CustomButton.Image = null;
            this.tb_lastName.CustomButton.Location = new System.Drawing.Point(354, 1);
            this.tb_lastName.CustomButton.Name = "";
            this.tb_lastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_lastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_lastName.CustomButton.TabIndex = 1;
            this.tb_lastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_lastName.CustomButton.UseSelectable = true;
            this.tb_lastName.CustomButton.Visible = false;
            this.tb_lastName.Lines = new string[0];
            this.tb_lastName.Location = new System.Drawing.Point(101, 177);
            this.tb_lastName.MaxLength = 32767;
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.PasswordChar = '\0';
            this.tb_lastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_lastName.SelectedText = "";
            this.tb_lastName.SelectionLength = 0;
            this.tb_lastName.SelectionStart = 0;
            this.tb_lastName.ShortcutsEnabled = true;
            this.tb_lastName.Size = new System.Drawing.Size(376, 23);
            this.tb_lastName.TabIndex = 7;
            this.tb_lastName.UseSelectable = true;
            this.tb_lastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_lastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_lastName
            // 
            this.lb_lastName.AutoSize = true;
            this.lb_lastName.Location = new System.Drawing.Point(14, 181);
            this.lb_lastName.Name = "lb_lastName";
            this.lb_lastName.Size = new System.Drawing.Size(81, 19);
            this.lb_lastName.TabIndex = 6;
            this.lb_lastName.Text = "Sobrenome:";
            // 
            // tb_email
            // 
            // 
            // 
            // 
            this.tb_email.CustomButton.Image = null;
            this.tb_email.CustomButton.Location = new System.Drawing.Point(354, 1);
            this.tb_email.CustomButton.Name = "";
            this.tb_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_email.CustomButton.TabIndex = 1;
            this.tb_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_email.CustomButton.UseSelectable = true;
            this.tb_email.CustomButton.Visible = false;
            this.tb_email.Lines = new string[0];
            this.tb_email.Location = new System.Drawing.Point(101, 215);
            this.tb_email.MaxLength = 32767;
            this.tb_email.Name = "tb_email";
            this.tb_email.PasswordChar = '\0';
            this.tb_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_email.SelectedText = "";
            this.tb_email.SelectionLength = 0;
            this.tb_email.SelectionStart = 0;
            this.tb_email.ShortcutsEnabled = true;
            this.tb_email.Size = new System.Drawing.Size(376, 23);
            this.tb_email.TabIndex = 9;
            this.tb_email.UseSelectable = true;
            this.tb_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(45, 219);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "E-Mail:";
            // 
            // bt_resetPasswd
            // 
            this.bt_resetPasswd.Location = new System.Drawing.Point(355, 102);
            this.bt_resetPasswd.Name = "bt_resetPasswd";
            this.bt_resetPasswd.Size = new System.Drawing.Size(122, 23);
            this.bt_resetPasswd.TabIndex = 13;
            this.bt_resetPasswd.Text = "Resetar senha";
            this.bt_resetPasswd.UseSelectable = true;
            this.bt_resetPasswd.Click += new System.EventHandler(this.bt_resetPasswd_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(305, 316);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 14;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseSelectable = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_save.Location = new System.Drawing.Point(402, 316);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.Style = MetroFramework.MetroColorStyle.White;
            this.bt_save.TabIndex = 15;
            this.bt_save.Text = "Salvar";
            this.bt_save.UseCustomBackColor = true;
            this.bt_save.UseSelectable = true;
            this.bt_save.UseStyleColors = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // tg_admin
            // 
            this.tg_admin.AutoSize = true;
            this.tg_admin.Location = new System.Drawing.Point(108, 271);
            this.tg_admin.Name = "tg_admin";
            this.tg_admin.Size = new System.Drawing.Size(80, 17);
            this.tg_admin.TabIndex = 16;
            this.tg_admin.Text = "Off";
            this.tg_admin.UseSelectable = true;
            // 
            // lb_isAdmin
            // 
            this.lb_isAdmin.AutoSize = true;
            this.lb_isAdmin.Location = new System.Drawing.Point(121, 249);
            this.lb_isAdmin.Name = "lb_isAdmin";
            this.lb_isAdmin.Size = new System.Drawing.Size(51, 19);
            this.lb_isAdmin.TabIndex = 17;
            this.lb_isAdmin.Text = "Admin:";
            // 
            // lb_isActive
            // 
            this.lb_isActive.AutoSize = true;
            this.lb_isActive.Location = new System.Drawing.Point(282, 249);
            this.lb_isActive.Name = "lb_isActive";
            this.lb_isActive.Size = new System.Drawing.Size(42, 19);
            this.lb_isActive.TabIndex = 19;
            this.lb_isActive.Text = "Ativo:";
            // 
            // tg_active
            // 
            this.tg_active.AutoSize = true;
            this.tg_active.Checked = true;
            this.tg_active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tg_active.Location = new System.Drawing.Point(269, 271);
            this.tg_active.Name = "tg_active";
            this.tg_active.Size = new System.Drawing.Size(80, 17);
            this.tg_active.TabIndex = 18;
            this.tg_active.Text = "On";
            this.tg_active.UseSelectable = true;
            // 
            // pb_spinner
            // 
            this.pb_spinner.Location = new System.Drawing.Point(243, 157);
            this.pb_spinner.Maximum = 4;
            this.pb_spinner.Name = "pb_spinner";
            this.pb_spinner.Size = new System.Drawing.Size(32, 32);
            this.pb_spinner.TabIndex = 20;
            this.pb_spinner.UseSelectable = true;
            this.pb_spinner.Visible = false;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 362);
            this.Controls.Add(this.pb_spinner);
            this.Controls.Add(this.lb_isActive);
            this.Controls.Add(this.tg_active);
            this.Controls.Add(this.lb_isAdmin);
            this.Controls.Add(this.tg_admin);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_resetPasswd);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.lb_lastName);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_passwd);
            this.Controls.Add(this.lb_passwd);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "EditUserForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Editar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tb_username;
        private MetroFramework.Controls.MetroTextBox tb_passwd;
        private MetroFramework.Controls.MetroLabel lb_passwd;
        private MetroFramework.Controls.MetroTextBox tb_name;
        private MetroFramework.Controls.MetroLabel lb_name;
        private MetroFramework.Controls.MetroTextBox tb_lastName;
        private MetroFramework.Controls.MetroLabel lb_lastName;
        private MetroFramework.Controls.MetroTextBox tb_email;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton bt_resetPasswd;
        private MetroFramework.Controls.MetroButton bt_cancel;
        private MetroFramework.Controls.MetroButton bt_save;
        private MetroFramework.Controls.MetroToggle tg_admin;
        private MetroFramework.Controls.MetroLabel lb_isAdmin;
        private MetroFramework.Controls.MetroLabel lb_isActive;
        private MetroFramework.Controls.MetroToggle tg_active;
        private MetroFramework.Controls.MetroProgressSpinner pb_spinner;
    }
}