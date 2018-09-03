namespace DomusClient
{
    partial class ConfigureDeviceForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureDeviceForm));
            this.conectWatch = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tb_uid = new MetroFramework.Controls.MetroTextBox();
            this.tb_serverIp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tb_porta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tb_deviceIp = new MetroFramework.Controls.MetroTextBox();
            this.tg_isDHCP = new MetroFramework.Controls.MetroToggle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tb_mac = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.bt_newMac = new MetroFramework.Controls.MetroButton();
            this.tb_log = new MetroFramework.Controls.MetroTextBox();
            this.bt_apply = new MetroFramework.Controls.MetroButton();
            this.bt_exit = new MetroFramework.Controls.MetroButton();
            this.cb_coms = new MetroFramework.Controls.MetroComboBox();
            this.bt_connect = new MetroFramework.Controls.MetroButton();
            this.timerCom = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // conectWatch
            // 
            this.conectWatch.Interval = 5000;
            this.conectWatch.Tick += new System.EventHandler(this.ConnectionWatcher);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "UID:";
            // 
            // tb_uid
            // 
            // 
            // 
            // 
            this.tb_uid.CustomButton.Image = null;
            this.tb_uid.CustomButton.Location = new System.Drawing.Point(398, 1);
            this.tb_uid.CustomButton.Name = "";
            this.tb_uid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_uid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_uid.CustomButton.TabIndex = 1;
            this.tb_uid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_uid.CustomButton.UseSelectable = true;
            this.tb_uid.CustomButton.Visible = false;
            this.tb_uid.Enabled = false;
            this.tb_uid.Lines = new string[0];
            this.tb_uid.Location = new System.Drawing.Point(62, 60);
            this.tb_uid.MaxLength = 32767;
            this.tb_uid.Name = "tb_uid";
            this.tb_uid.PasswordChar = '\0';
            this.tb_uid.ReadOnly = true;
            this.tb_uid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_uid.SelectedText = "";
            this.tb_uid.SelectionLength = 0;
            this.tb_uid.SelectionStart = 0;
            this.tb_uid.ShortcutsEnabled = true;
            this.tb_uid.Size = new System.Drawing.Size(420, 23);
            this.tb_uid.TabIndex = 1;
            this.tb_uid.TabStop = false;
            this.tb_uid.UseSelectable = true;
            this.tb_uid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_uid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_serverIp
            // 
            // 
            // 
            // 
            this.tb_serverIp.CustomButton.Image = null;
            this.tb_serverIp.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tb_serverIp.CustomButton.Name = "";
            this.tb_serverIp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_serverIp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_serverIp.CustomButton.TabIndex = 1;
            this.tb_serverIp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_serverIp.CustomButton.UseSelectable = true;
            this.tb_serverIp.CustomButton.Visible = false;
            this.tb_serverIp.Lines = new string[0];
            this.tb_serverIp.Location = new System.Drawing.Point(107, 101);
            this.tb_serverIp.MaxLength = 32767;
            this.tb_serverIp.Name = "tb_serverIp";
            this.tb_serverIp.PasswordChar = '\0';
            this.tb_serverIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_serverIp.SelectedText = "";
            this.tb_serverIp.SelectionLength = 0;
            this.tb_serverIp.SelectionStart = 0;
            this.tb_serverIp.ShortcutsEnabled = true;
            this.tb_serverIp.Size = new System.Drawing.Size(148, 23);
            this.tb_serverIp.TabIndex = 5;
            this.tb_serverIp.UseSelectable = true;
            this.tb_serverIp.WaterMark = "ex: 127.0.0.1";
            this.tb_serverIp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_serverIp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "IP Servidor:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(286, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(122, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Porta (dispositivos):";
            // 
            // tb_porta
            // 
            // 
            // 
            // 
            this.tb_porta.CustomButton.Image = null;
            this.tb_porta.CustomButton.Location = new System.Drawing.Point(46, 1);
            this.tb_porta.CustomButton.Name = "";
            this.tb_porta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_porta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_porta.CustomButton.TabIndex = 1;
            this.tb_porta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_porta.CustomButton.UseSelectable = true;
            this.tb_porta.CustomButton.Visible = false;
            this.tb_porta.Lines = new string[0];
            this.tb_porta.Location = new System.Drawing.Point(414, 101);
            this.tb_porta.MaxLength = 32767;
            this.tb_porta.Name = "tb_porta";
            this.tb_porta.PasswordChar = '\0';
            this.tb_porta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_porta.SelectedText = "";
            this.tb_porta.SelectionLength = 0;
            this.tb_porta.SelectionStart = 0;
            this.tb_porta.ShortcutsEnabled = true;
            this.tb_porta.Size = new System.Drawing.Size(68, 23);
            this.tb_porta.TabIndex = 6;
            this.tb_porta.UseSelectable = true;
            this.tb_porta.WaterMark = "ex: 9090";
            this.tb_porta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_porta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "IP Dispositivo:";
            // 
            // tb_deviceIp
            // 
            // 
            // 
            // 
            this.tb_deviceIp.CustomButton.Image = null;
            this.tb_deviceIp.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tb_deviceIp.CustomButton.Name = "";
            this.tb_deviceIp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_deviceIp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_deviceIp.CustomButton.TabIndex = 1;
            this.tb_deviceIp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_deviceIp.CustomButton.UseSelectable = true;
            this.tb_deviceIp.CustomButton.Visible = false;
            this.tb_deviceIp.Enabled = false;
            this.tb_deviceIp.Lines = new string[0];
            this.tb_deviceIp.Location = new System.Drawing.Point(107, 136);
            this.tb_deviceIp.MaxLength = 32767;
            this.tb_deviceIp.Name = "tb_deviceIp";
            this.tb_deviceIp.PasswordChar = '\0';
            this.tb_deviceIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_deviceIp.SelectedText = "";
            this.tb_deviceIp.SelectionLength = 0;
            this.tb_deviceIp.SelectionStart = 0;
            this.tb_deviceIp.ShortcutsEnabled = true;
            this.tb_deviceIp.Size = new System.Drawing.Size(148, 23);
            this.tb_deviceIp.TabIndex = 0;
            this.tb_deviceIp.UseSelectable = true;
            this.tb_deviceIp.WaterMark = "ex: 127.0.0.1";
            this.tb_deviceIp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_deviceIp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tg_isDHCP
            // 
            this.tg_isDHCP.AutoSize = true;
            this.tg_isDHCP.Checked = true;
            this.tg_isDHCP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tg_isDHCP.Location = new System.Drawing.Point(339, 142);
            this.tg_isDHCP.Name = "tg_isDHCP";
            this.tg_isDHCP.Size = new System.Drawing.Size(80, 17);
            this.tg_isDHCP.TabIndex = 8;
            this.tg_isDHCP.TabStop = false;
            this.tg_isDHCP.Text = "On";
            this.tg_isDHCP.UseSelectable = true;
            this.tg_isDHCP.CheckedChanged += new System.EventHandler(this.tg_isDHCP_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(286, 140);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "DHCP:";
            // 
            // tb_mac
            // 
            // 
            // 
            // 
            this.tb_mac.CustomButton.Image = null;
            this.tb_mac.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tb_mac.CustomButton.Name = "";
            this.tb_mac.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_mac.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_mac.CustomButton.TabIndex = 1;
            this.tb_mac.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_mac.CustomButton.UseSelectable = true;
            this.tb_mac.CustomButton.Visible = false;
            this.tb_mac.Lines = new string[0];
            this.tb_mac.Location = new System.Drawing.Point(107, 171);
            this.tb_mac.MaxLength = 17;
            this.tb_mac.Name = "tb_mac";
            this.tb_mac.PasswordChar = '\0';
            this.tb_mac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_mac.SelectedText = "";
            this.tb_mac.SelectionLength = 0;
            this.tb_mac.SelectionStart = 0;
            this.tb_mac.ShortcutsEnabled = true;
            this.tb_mac.Size = new System.Drawing.Size(148, 23);
            this.tb_mac.TabIndex = 1;
            this.tb_mac.UseCustomForeColor = true;
            this.tb_mac.UseSelectable = true;
            this.tb_mac.WaterMark = "ex: 00-E0-4C-48-24-9F";
            this.tb_mac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_mac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_mac.Leave += new System.EventHandler(this.tb_mac_Leave);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(59, 171);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(42, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "MAC:";
            // 
            // bt_newMac
            // 
            this.bt_newMac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_newMac.Location = new System.Drawing.Point(286, 171);
            this.bt_newMac.Name = "bt_newMac";
            this.bt_newMac.Size = new System.Drawing.Size(80, 23);
            this.bt_newMac.Style = MetroFramework.MetroColorStyle.White;
            this.bt_newMac.TabIndex = 2;
            this.bt_newMac.Text = "Gerar MAC";
            this.bt_newMac.UseCustomBackColor = true;
            this.bt_newMac.UseSelectable = true;
            this.bt_newMac.UseStyleColors = true;
            this.bt_newMac.Click += new System.EventHandler(this.bt_newMac_Click);
            // 
            // tb_log
            // 
            // 
            // 
            // 
            this.tb_log.CustomButton.Image = null;
            this.tb_log.CustomButton.Location = new System.Drawing.Point(124, 2);
            this.tb_log.CustomButton.Name = "";
            this.tb_log.CustomButton.Size = new System.Drawing.Size(131, 131);
            this.tb_log.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_log.CustomButton.TabIndex = 1;
            this.tb_log.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_log.CustomButton.UseSelectable = true;
            this.tb_log.CustomButton.Visible = false;
            this.tb_log.Enabled = false;
            this.tb_log.Lines = new string[0];
            this.tb_log.Location = new System.Drawing.Point(26, 233);
            this.tb_log.MaxLength = 32767;
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.PasswordChar = '\0';
            this.tb_log.ReadOnly = true;
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_log.SelectedText = "";
            this.tb_log.SelectionLength = 0;
            this.tb_log.SelectionStart = 0;
            this.tb_log.ShortcutsEnabled = true;
            this.tb_log.Size = new System.Drawing.Size(258, 136);
            this.tb_log.TabIndex = 13;
            this.tb_log.TabStop = false;
            this.tb_log.UseSelectable = true;
            this.tb_log.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_log.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bt_apply
            // 
            this.bt_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_apply.Enabled = false;
            this.bt_apply.Location = new System.Drawing.Point(407, 346);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(75, 23);
            this.bt_apply.Style = MetroFramework.MetroColorStyle.White;
            this.bt_apply.TabIndex = 3;
            this.bt_apply.Text = "Aplicar";
            this.bt_apply.UseCustomBackColor = true;
            this.bt_apply.UseSelectable = true;
            this.bt_apply.UseStyleColors = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(302, 346);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 4;
            this.bt_exit.Text = "Sair";
            this.bt_exit.UseSelectable = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // cb_coms
            // 
            this.cb_coms.FormattingEnabled = true;
            this.cb_coms.ItemHeight = 23;
            this.cb_coms.Location = new System.Drawing.Point(302, 262);
            this.cb_coms.Name = "cb_coms";
            this.cb_coms.Size = new System.Drawing.Size(180, 29);
            this.cb_coms.TabIndex = 14;
            this.cb_coms.UseSelectable = true;
            // 
            // bt_connect
            // 
            this.bt_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_connect.Location = new System.Drawing.Point(302, 233);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(75, 23);
            this.bt_connect.Style = MetroFramework.MetroColorStyle.White;
            this.bt_connect.TabIndex = 15;
            this.bt_connect.Text = "Conectar";
            this.bt_connect.UseCustomBackColor = true;
            this.bt_connect.UseSelectable = true;
            this.bt_connect.UseStyleColors = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // timerCom
            // 
            this.timerCom.Interval = 1000;
            this.timerCom.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // ConfigureDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 392);
            this.Controls.Add(this.bt_connect);
            this.Controls.Add(this.cb_coms);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.bt_newMac);
            this.Controls.Add(this.tb_mac);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tg_isDHCP);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tb_deviceIp);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tb_porta);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tb_serverIp);
            this.Controls.Add(this.tb_uid);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigureDeviceForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Configurar Dispositivo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigureDeviceForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfigureDeviceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer conectWatch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tb_uid;
        private MetroFramework.Controls.MetroTextBox tb_serverIp;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tb_porta;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tb_deviceIp;
        private MetroFramework.Controls.MetroToggle tg_isDHCP;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tb_mac;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton bt_newMac;
        private MetroFramework.Controls.MetroTextBox tb_log;
        private MetroFramework.Controls.MetroButton bt_apply;
        private MetroFramework.Controls.MetroButton bt_exit;
        private MetroFramework.Controls.MetroComboBox cb_coms;
        private MetroFramework.Controls.MetroButton bt_connect;
        private System.Windows.Forms.Timer timerCom;
    }
}