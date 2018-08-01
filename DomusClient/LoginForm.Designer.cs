namespace DomusClient
{
    partial class LoginForm
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
            this.tb_user = new MetroFramework.Controls.MetroTextBox();
            this.tb_passwd = new MetroFramework.Controls.MetroTextBox();
            this.lb_user = new MetroFramework.Controls.MetroLabel();
            this.lb_passwd = new MetroFramework.Controls.MetroLabel();
            this.bt_cancel = new MetroFramework.Controls.MetroButton();
            this.bt_login = new MetroFramework.Controls.MetroButton();
            this.pb_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            // 
            // 
            // 
            this.tb_user.CustomButton.Image = null;
            this.tb_user.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.tb_user.CustomButton.Name = "";
            this.tb_user.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_user.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_user.CustomButton.TabIndex = 1;
            this.tb_user.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_user.CustomButton.UseSelectable = true;
            this.tb_user.CustomButton.Visible = false;
            this.tb_user.Lines = new string[0];
            this.tb_user.Location = new System.Drawing.Point(86, 81);
            this.tb_user.MaxLength = 32767;
            this.tb_user.Name = "tb_user";
            this.tb_user.PasswordChar = '\0';
            this.tb_user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_user.SelectedText = "";
            this.tb_user.SelectionLength = 0;
            this.tb_user.SelectionStart = 0;
            this.tb_user.ShortcutsEnabled = true;
            this.tb_user.Size = new System.Drawing.Size(248, 23);
            this.tb_user.TabIndex = 0;
            this.tb_user.UseSelectable = true;
            this.tb_user.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_user.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_passwd
            // 
            // 
            // 
            // 
            this.tb_passwd.CustomButton.Image = null;
            this.tb_passwd.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.tb_passwd.CustomButton.Name = "";
            this.tb_passwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_passwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_passwd.CustomButton.TabIndex = 1;
            this.tb_passwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_passwd.CustomButton.UseSelectable = true;
            this.tb_passwd.CustomButton.Visible = false;
            this.tb_passwd.Lines = new string[0];
            this.tb_passwd.Location = new System.Drawing.Point(86, 125);
            this.tb_passwd.MaxLength = 32767;
            this.tb_passwd.Name = "tb_passwd";
            this.tb_passwd.PasswordChar = '●';
            this.tb_passwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_passwd.SelectedText = "";
            this.tb_passwd.SelectionLength = 0;
            this.tb_passwd.SelectionStart = 0;
            this.tb_passwd.ShortcutsEnabled = true;
            this.tb_passwd.Size = new System.Drawing.Size(248, 23);
            this.tb_passwd.TabIndex = 1;
            this.tb_passwd.UseSelectable = true;
            this.tb_passwd.UseSystemPasswordChar = true;
            this.tb_passwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_passwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(24, 81);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(56, 19);
            this.lb_user.TabIndex = 2;
            this.lb_user.Text = "Usuário:";
            // 
            // lb_passwd
            // 
            this.lb_passwd.AutoSize = true;
            this.lb_passwd.Location = new System.Drawing.Point(33, 125);
            this.lb_passwd.Name = "lb_passwd";
            this.lb_passwd.Size = new System.Drawing.Size(47, 19);
            this.lb_passwd.TabIndex = 3;
            this.lb_passwd.Text = "Senha:";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(33, 171);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(106, 42);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseSelectable = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.bt_login.Location = new System.Drawing.Point(228, 171);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(106, 42);
            this.bt_login.Style = MetroFramework.MetroColorStyle.White;
            this.bt_login.TabIndex = 5;
            this.bt_login.Text = "Login";
            this.bt_login.UseCustomBackColor = true;
            this.bt_login.UseSelectable = true;
            this.bt_login.UseStyleColors = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // pb_spinner
            // 
            this.pb_spinner.Location = new System.Drawing.Point(171, 106);
            this.pb_spinner.Maximum = 100;
            this.pb_spinner.Name = "pb_spinner";
            this.pb_spinner.Size = new System.Drawing.Size(16, 16);
            this.pb_spinner.TabIndex = 6;
            this.pb_spinner.TabStop = false;
            this.pb_spinner.UseSelectable = true;
            this.pb_spinner.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 227);
            this.ControlBox = false;
            this.Controls.Add(this.pb_spinner);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.lb_passwd);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.tb_passwd);
            this.Controls.Add(this.tb_user);
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Domus - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tb_user;
        private MetroFramework.Controls.MetroTextBox tb_passwd;
        private MetroFramework.Controls.MetroLabel lb_user;
        private MetroFramework.Controls.MetroLabel lb_passwd;
        private MetroFramework.Controls.MetroButton bt_cancel;
        private MetroFramework.Controls.MetroButton bt_login;
        private MetroFramework.Controls.MetroProgressSpinner pb_spinner;
    }
}