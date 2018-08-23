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
            this.SuspendLayout();
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
            this.tb_uid.Lines = new string[0];
            this.tb_uid.Location = new System.Drawing.Point(62, 60);
            this.tb_uid.MaxLength = 32767;
            this.tb_uid.Name = "tb_uid";
            this.tb_uid.PasswordChar = '\0';
            this.tb_uid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_uid.SelectedText = "";
            this.tb_uid.SelectionLength = 0;
            this.tb_uid.SelectionStart = 0;
            this.tb_uid.ShortcutsEnabled = true;
            this.tb_uid.Size = new System.Drawing.Size(420, 23);
            this.tb_uid.TabIndex = 1;
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
            this.tb_serverIp.Location = new System.Drawing.Point(107, 110);
            this.tb_serverIp.MaxLength = 32767;
            this.tb_serverIp.Name = "tb_serverIp";
            this.tb_serverIp.PasswordChar = '\0';
            this.tb_serverIp.PromptText = "ex: 127.0.0.1";
            this.tb_serverIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_serverIp.SelectedText = "";
            this.tb_serverIp.SelectionLength = 0;
            this.tb_serverIp.SelectionStart = 0;
            this.tb_serverIp.ShortcutsEnabled = true;
            this.tb_serverIp.Size = new System.Drawing.Size(148, 23);
            this.tb_serverIp.TabIndex = 2;
            this.tb_serverIp.UseSelectable = true;
            this.tb_serverIp.WaterMark = "ex: 127.0.0.1";
            this.tb_serverIp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_serverIp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "IP Servidor:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(286, 114);
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
            this.tb_porta.Location = new System.Drawing.Point(414, 110);
            this.tb_porta.MaxLength = 32767;
            this.tb_porta.Name = "tb_porta";
            this.tb_porta.PasswordChar = '\0';
            this.tb_porta.PromptText = "ex: 9090";
            this.tb_porta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_porta.SelectedText = "";
            this.tb_porta.SelectionLength = 0;
            this.tb_porta.SelectionStart = 0;
            this.tb_porta.ShortcutsEnabled = true;
            this.tb_porta.Size = new System.Drawing.Size(68, 23);
            this.tb_porta.TabIndex = 4;
            this.tb_porta.UseSelectable = true;
            this.tb_porta.WaterMark = "ex: 9090";
            this.tb_porta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_porta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ConfigureDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
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
            this.Text = "ConfigureDevice";
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
    }
}