namespace DomusClient
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.lb_serverIp = new MetroFramework.Controls.MetroLabel();
            this.tb_serverIp = new MetroFramework.Controls.MetroTextBox();
            this.tb_serverPort = new MetroFramework.Controls.MetroTextBox();
            this.lb_serverPort = new MetroFramework.Controls.MetroLabel();
            this.tb_passwd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tb_newPasswd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tb_confNewPasswd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.bt_changePasswd = new MetroFramework.Controls.MetroButton();
            this.bt_exit = new MetroFramework.Controls.MetroButton();
            this.bt_save = new MetroFramework.Controls.MetroButton();
            this.pb_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.tb_devicesPort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lb_serverIp
            // 
            this.lb_serverIp.AutoSize = true;
            this.lb_serverIp.Location = new System.Drawing.Point(23, 90);
            this.lb_serverIp.Name = "lb_serverIp";
            this.lb_serverIp.Size = new System.Drawing.Size(78, 19);
            this.lb_serverIp.TabIndex = 0;
            this.lb_serverIp.Text = "IP Servidor:";
            // 
            // tb_serverIp
            // 
            // 
            // 
            // 
            this.tb_serverIp.CustomButton.Image = null;
            this.tb_serverIp.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.tb_serverIp.CustomButton.Name = "";
            this.tb_serverIp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_serverIp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_serverIp.CustomButton.TabIndex = 1;
            this.tb_serverIp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_serverIp.CustomButton.UseSelectable = true;
            this.tb_serverIp.CustomButton.Visible = false;
            this.tb_serverIp.Lines = new string[0];
            this.tb_serverIp.Location = new System.Drawing.Point(107, 90);
            this.tb_serverIp.MaxLength = 32767;
            this.tb_serverIp.Name = "tb_serverIp";
            this.tb_serverIp.PasswordChar = '\0';
            this.tb_serverIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_serverIp.SelectedText = "";
            this.tb_serverIp.SelectionLength = 0;
            this.tb_serverIp.SelectionStart = 0;
            this.tb_serverIp.ShortcutsEnabled = true;
            this.tb_serverIp.Size = new System.Drawing.Size(104, 23);
            this.tb_serverIp.TabIndex = 1;
            this.tb_serverIp.UseSelectable = true;
            this.tb_serverIp.WaterMark = "127.0.0.1";
            this.tb_serverIp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_serverIp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_serverPort
            // 
            // 
            // 
            // 
            this.tb_serverPort.CustomButton.Image = null;
            this.tb_serverPort.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.tb_serverPort.CustomButton.Name = "";
            this.tb_serverPort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_serverPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_serverPort.CustomButton.TabIndex = 1;
            this.tb_serverPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_serverPort.CustomButton.UseSelectable = true;
            this.tb_serverPort.CustomButton.Visible = false;
            this.tb_serverPort.Lines = new string[0];
            this.tb_serverPort.Location = new System.Drawing.Point(291, 90);
            this.tb_serverPort.MaxLength = 32767;
            this.tb_serverPort.Name = "tb_serverPort";
            this.tb_serverPort.PasswordChar = '\0';
            this.tb_serverPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_serverPort.SelectedText = "";
            this.tb_serverPort.SelectionLength = 0;
            this.tb_serverPort.SelectionStart = 0;
            this.tb_serverPort.ShortcutsEnabled = true;
            this.tb_serverPort.Size = new System.Drawing.Size(63, 23);
            this.tb_serverPort.TabIndex = 3;
            this.tb_serverPort.UseSelectable = true;
            this.tb_serverPort.WaterMark = "9090";
            this.tb_serverPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_serverPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_serverPort
            // 
            this.lb_serverPort.AutoSize = true;
            this.lb_serverPort.Location = new System.Drawing.Point(241, 90);
            this.lb_serverPort.Name = "lb_serverPort";
            this.lb_serverPort.Size = new System.Drawing.Size(44, 19);
            this.lb_serverPort.TabIndex = 2;
            this.lb_serverPort.Text = "Porta:";
            // 
            // tb_passwd
            // 
            // 
            // 
            // 
            this.tb_passwd.CustomButton.Image = null;
            this.tb_passwd.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.tb_passwd.CustomButton.Name = "";
            this.tb_passwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_passwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_passwd.CustomButton.TabIndex = 1;
            this.tb_passwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_passwd.CustomButton.UseSelectable = true;
            this.tb_passwd.CustomButton.Visible = false;
            this.tb_passwd.Lines = new string[0];
            this.tb_passwd.Location = new System.Drawing.Point(107, 158);
            this.tb_passwd.MaxLength = 32767;
            this.tb_passwd.Name = "tb_passwd";
            this.tb_passwd.PasswordChar = '●';
            this.tb_passwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_passwd.SelectedText = "";
            this.tb_passwd.SelectionLength = 0;
            this.tb_passwd.SelectionStart = 0;
            this.tb_passwd.ShortcutsEnabled = true;
            this.tb_passwd.Size = new System.Drawing.Size(247, 23);
            this.tb_passwd.TabIndex = 5;
            this.tb_passwd.UseSelectable = true;
            this.tb_passwd.UseSystemPasswordChar = true;
            this.tb_passwd.WaterMark = "Senha atual";
            this.tb_passwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_passwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 158);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Senha atual:";
            // 
            // tb_newPasswd
            // 
            // 
            // 
            // 
            this.tb_newPasswd.CustomButton.Image = null;
            this.tb_newPasswd.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.tb_newPasswd.CustomButton.Name = "";
            this.tb_newPasswd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_newPasswd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_newPasswd.CustomButton.TabIndex = 1;
            this.tb_newPasswd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_newPasswd.CustomButton.UseSelectable = true;
            this.tb_newPasswd.CustomButton.Visible = false;
            this.tb_newPasswd.Lines = new string[0];
            this.tb_newPasswd.Location = new System.Drawing.Point(107, 205);
            this.tb_newPasswd.MaxLength = 32767;
            this.tb_newPasswd.Name = "tb_newPasswd";
            this.tb_newPasswd.PasswordChar = '●';
            this.tb_newPasswd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_newPasswd.SelectedText = "";
            this.tb_newPasswd.SelectionLength = 0;
            this.tb_newPasswd.SelectionStart = 0;
            this.tb_newPasswd.ShortcutsEnabled = true;
            this.tb_newPasswd.Size = new System.Drawing.Size(246, 23);
            this.tb_newPasswd.TabIndex = 7;
            this.tb_newPasswd.UseSelectable = true;
            this.tb_newPasswd.UseSystemPasswordChar = true;
            this.tb_newPasswd.WaterMark = "Nova Senha";
            this.tb_newPasswd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_newPasswd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 205);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Nova senha:";
            // 
            // tb_confNewPasswd
            // 
            // 
            // 
            // 
            this.tb_confNewPasswd.CustomButton.Image = null;
            this.tb_confNewPasswd.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.tb_confNewPasswd.CustomButton.Name = "";
            this.tb_confNewPasswd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_confNewPasswd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_confNewPasswd.CustomButton.TabIndex = 1;
            this.tb_confNewPasswd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_confNewPasswd.CustomButton.UseSelectable = true;
            this.tb_confNewPasswd.CustomButton.Visible = false;
            this.tb_confNewPasswd.Lines = new string[0];
            this.tb_confNewPasswd.Location = new System.Drawing.Point(107, 251);
            this.tb_confNewPasswd.MaxLength = 32767;
            this.tb_confNewPasswd.Name = "tb_confNewPasswd";
            this.tb_confNewPasswd.PasswordChar = '●';
            this.tb_confNewPasswd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_confNewPasswd.SelectedText = "";
            this.tb_confNewPasswd.SelectionLength = 0;
            this.tb_confNewPasswd.SelectionStart = 0;
            this.tb_confNewPasswd.ShortcutsEnabled = true;
            this.tb_confNewPasswd.Size = new System.Drawing.Size(246, 23);
            this.tb_confNewPasswd.TabIndex = 9;
            this.tb_confNewPasswd.UseSelectable = true;
            this.tb_confNewPasswd.UseSystemPasswordChar = true;
            this.tb_confNewPasswd.WaterMark = "Confirmar nova senha";
            this.tb_confNewPasswd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_confNewPasswd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 251);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Conf. senha:";
            // 
            // bt_changePasswd
            // 
            this.bt_changePasswd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_changePasswd.Location = new System.Drawing.Point(263, 293);
            this.bt_changePasswd.Name = "bt_changePasswd";
            this.bt_changePasswd.Size = new System.Drawing.Size(90, 23);
            this.bt_changePasswd.Style = MetroFramework.MetroColorStyle.White;
            this.bt_changePasswd.TabIndex = 10;
            this.bt_changePasswd.Text = "Alterar Senha";
            this.bt_changePasswd.UseCustomBackColor = true;
            this.bt_changePasswd.UseSelectable = true;
            this.bt_changePasswd.UseStyleColors = true;
            this.bt_changePasswd.Click += new System.EventHandler(this.bt_changePasswd_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(178, 293);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 11;
            this.bt_exit.Text = "Sair";
            this.bt_exit.UseSelectable = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_save.Location = new System.Drawing.Point(278, 121);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.Style = MetroFramework.MetroColorStyle.White;
            this.bt_save.TabIndex = 12;
            this.bt_save.Text = "Salvar";
            this.bt_save.UseCustomBackColor = true;
            this.bt_save.UseSelectable = true;
            this.bt_save.UseStyleColors = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // pb_spinner
            // 
            this.pb_spinner.Location = new System.Drawing.Point(179, 165);
            this.pb_spinner.Maximum = 4;
            this.pb_spinner.Name = "pb_spinner";
            this.pb_spinner.Size = new System.Drawing.Size(32, 32);
            this.pb_spinner.TabIndex = 13;
            this.pb_spinner.UseSelectable = true;
            this.pb_spinner.Visible = false;
            // 
            // tb_devicesPort
            // 
            // 
            // 
            // 
            this.tb_devicesPort.CustomButton.Image = null;
            this.tb_devicesPort.CustomButton.Location = new System.Drawing.Point(41, 1);
            this.tb_devicesPort.CustomButton.Name = "";
            this.tb_devicesPort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_devicesPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_devicesPort.CustomButton.TabIndex = 1;
            this.tb_devicesPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_devicesPort.CustomButton.UseSelectable = true;
            this.tb_devicesPort.CustomButton.Visible = false;
            this.tb_devicesPort.Lines = new string[0];
            this.tb_devicesPort.Location = new System.Drawing.Point(148, 121);
            this.tb_devicesPort.MaxLength = 32767;
            this.tb_devicesPort.Name = "tb_devicesPort";
            this.tb_devicesPort.PasswordChar = '\0';
            this.tb_devicesPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_devicesPort.SelectedText = "";
            this.tb_devicesPort.SelectionLength = 0;
            this.tb_devicesPort.SelectionStart = 0;
            this.tb_devicesPort.ShortcutsEnabled = true;
            this.tb_devicesPort.Size = new System.Drawing.Size(63, 23);
            this.tb_devicesPort.TabIndex = 15;
            this.tb_devicesPort.UseSelectable = true;
            this.tb_devicesPort.WaterMark = "9595";
            this.tb_devicesPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_devicesPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 121);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(122, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Porta (dispositivos):";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 336);
            this.Controls.Add(this.tb_devicesPort);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.pb_spinner);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_changePasswd);
            this.Controls.Add(this.tb_confNewPasswd);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tb_newPasswd);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tb_passwd);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tb_serverPort);
            this.Controls.Add(this.lb_serverPort);
            this.Controls.Add(this.tb_serverIp);
            this.Controls.Add(this.lb_serverIp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Configurações - Domus Client";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lb_serverIp;
        private MetroFramework.Controls.MetroTextBox tb_serverIp;
        private MetroFramework.Controls.MetroTextBox tb_serverPort;
        private MetroFramework.Controls.MetroLabel lb_serverPort;
        private MetroFramework.Controls.MetroTextBox tb_passwd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tb_newPasswd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tb_confNewPasswd;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton bt_changePasswd;
        private MetroFramework.Controls.MetroButton bt_exit;
        private MetroFramework.Controls.MetroButton bt_save;
        private MetroFramework.Controls.MetroProgressSpinner pb_spinner;
        private MetroFramework.Controls.MetroTextBox tb_devicesPort;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}