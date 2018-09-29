namespace DomusClient
{
    partial class EditDevicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDevicesForm));
            this.pb_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.bt_save = new MetroFramework.Controls.MetroButton();
            this.bt_cancel = new MetroFramework.Controls.MetroButton();
            this.tb_Uid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tb_devicename = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tb_data1Name = new MetroFramework.Controls.MetroTextBox();
            this.tb_data2Name = new MetroFramework.Controls.MetroTextBox();
            this.tb_data3Name = new MetroFramework.Controls.MetroTextBox();
            this.tb_data4Name = new MetroFramework.Controls.MetroTextBox();
            this.tg_data1Active = new MetroFramework.Controls.MetroToggle();
            this.tg_data2Active = new MetroFramework.Controls.MetroToggle();
            this.tg_data3Active = new MetroFramework.Controls.MetroToggle();
            this.tg_data4Active = new MetroFramework.Controls.MetroToggle();
            this.bt_createLink = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // pb_spinner
            // 
            this.pb_spinner.Location = new System.Drawing.Point(243, 157);
            this.pb_spinner.Maximum = 4;
            this.pb_spinner.Name = "pb_spinner";
            this.pb_spinner.Size = new System.Drawing.Size(32, 32);
            this.pb_spinner.TabIndex = 21;
            this.pb_spinner.UseSelectable = true;
            this.pb_spinner.Visible = false;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_save.Location = new System.Drawing.Point(417, 316);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.Style = MetroFramework.MetroColorStyle.White;
            this.bt_save.TabIndex = 23;
            this.bt_save.Text = "Salvar";
            this.bt_save.UseCustomBackColor = true;
            this.bt_save.UseSelectable = true;
            this.bt_save.UseStyleColors = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(320, 316);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 22;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseSelectable = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // tb_Uid
            // 
            // 
            // 
            // 
            this.tb_Uid.CustomButton.Image = null;
            this.tb_Uid.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.tb_Uid.CustomButton.Name = "";
            this.tb_Uid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_Uid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Uid.CustomButton.TabIndex = 1;
            this.tb_Uid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Uid.CustomButton.UseSelectable = true;
            this.tb_Uid.CustomButton.Visible = false;
            this.tb_Uid.Lines = new string[0];
            this.tb_Uid.Location = new System.Drawing.Point(78, 73);
            this.tb_Uid.MaxLength = 32767;
            this.tb_Uid.Name = "tb_Uid";
            this.tb_Uid.PasswordChar = '\0';
            this.tb_Uid.ReadOnly = true;
            this.tb_Uid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Uid.SelectedText = "";
            this.tb_Uid.SelectionLength = 0;
            this.tb_Uid.SelectionStart = 0;
            this.tb_Uid.ShortcutsEnabled = true;
            this.tb_Uid.Size = new System.Drawing.Size(424, 23);
            this.tb_Uid.TabIndex = 24;
            this.tb_Uid.UseSelectable = true;
            this.tb_Uid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Uid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 19);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "UID:";
            // 
            // tb_devicename
            // 
            // 
            // 
            // 
            this.tb_devicename.CustomButton.Image = null;
            this.tb_devicename.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.tb_devicename.CustomButton.Name = "";
            this.tb_devicename.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_devicename.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_devicename.CustomButton.TabIndex = 1;
            this.tb_devicename.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_devicename.CustomButton.UseSelectable = true;
            this.tb_devicename.CustomButton.Visible = false;
            this.tb_devicename.Lines = new string[0];
            this.tb_devicename.Location = new System.Drawing.Point(78, 111);
            this.tb_devicename.MaxLength = 32767;
            this.tb_devicename.Name = "tb_devicename";
            this.tb_devicename.PasswordChar = '\0';
            this.tb_devicename.PromptText = "ex: nome do dispositivo";
            this.tb_devicename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_devicename.SelectedText = "";
            this.tb_devicename.SelectionLength = 0;
            this.tb_devicename.SelectionStart = 0;
            this.tb_devicename.ShortcutsEnabled = true;
            this.tb_devicename.Size = new System.Drawing.Size(424, 23);
            this.tb_devicename.TabIndex = 27;
            this.tb_devicename.UseSelectable = true;
            this.tb_devicename.WaterMark = "ex: nome do dispositivo";
            this.tb_devicename.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_devicename.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Nome:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 155);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Dado 1:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 253);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Dado 4:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(17, 222);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "Dado 3:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(17, 189);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(55, 19);
            this.metroLabel6.TabIndex = 31;
            this.metroLabel6.Text = "Dado 2:";
            // 
            // tb_data1Name
            // 
            // 
            // 
            // 
            this.tb_data1Name.CustomButton.Image = null;
            this.tb_data1Name.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.tb_data1Name.CustomButton.Name = "";
            this.tb_data1Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_data1Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_data1Name.CustomButton.TabIndex = 1;
            this.tb_data1Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_data1Name.CustomButton.UseSelectable = true;
            this.tb_data1Name.CustomButton.Visible = false;
            this.tb_data1Name.Lines = new string[0];
            this.tb_data1Name.Location = new System.Drawing.Point(78, 151);
            this.tb_data1Name.MaxLength = 32767;
            this.tb_data1Name.Name = "tb_data1Name";
            this.tb_data1Name.PasswordChar = '\0';
            this.tb_data1Name.PromptText = "ex: Temperatura";
            this.tb_data1Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_data1Name.SelectedText = "";
            this.tb_data1Name.SelectionLength = 0;
            this.tb_data1Name.SelectionStart = 0;
            this.tb_data1Name.ShortcutsEnabled = true;
            this.tb_data1Name.Size = new System.Drawing.Size(245, 23);
            this.tb_data1Name.TabIndex = 32;
            this.tb_data1Name.UseSelectable = true;
            this.tb_data1Name.WaterMark = "ex: Temperatura";
            this.tb_data1Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_data1Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_data2Name
            // 
            // 
            // 
            // 
            this.tb_data2Name.CustomButton.Image = null;
            this.tb_data2Name.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.tb_data2Name.CustomButton.Name = "";
            this.tb_data2Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_data2Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_data2Name.CustomButton.TabIndex = 1;
            this.tb_data2Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_data2Name.CustomButton.UseSelectable = true;
            this.tb_data2Name.CustomButton.Visible = false;
            this.tb_data2Name.Lines = new string[0];
            this.tb_data2Name.Location = new System.Drawing.Point(78, 185);
            this.tb_data2Name.MaxLength = 32767;
            this.tb_data2Name.Name = "tb_data2Name";
            this.tb_data2Name.PasswordChar = '\0';
            this.tb_data2Name.PromptText = "ex: Humidade";
            this.tb_data2Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_data2Name.SelectedText = "";
            this.tb_data2Name.SelectionLength = 0;
            this.tb_data2Name.SelectionStart = 0;
            this.tb_data2Name.ShortcutsEnabled = true;
            this.tb_data2Name.Size = new System.Drawing.Size(245, 23);
            this.tb_data2Name.TabIndex = 33;
            this.tb_data2Name.UseSelectable = true;
            this.tb_data2Name.WaterMark = "ex: Humidade";
            this.tb_data2Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_data2Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_data3Name
            // 
            // 
            // 
            // 
            this.tb_data3Name.CustomButton.Image = null;
            this.tb_data3Name.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.tb_data3Name.CustomButton.Name = "";
            this.tb_data3Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_data3Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_data3Name.CustomButton.TabIndex = 1;
            this.tb_data3Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_data3Name.CustomButton.UseSelectable = true;
            this.tb_data3Name.CustomButton.Visible = false;
            this.tb_data3Name.Lines = new string[0];
            this.tb_data3Name.Location = new System.Drawing.Point(78, 218);
            this.tb_data3Name.MaxLength = 32767;
            this.tb_data3Name.Name = "tb_data3Name";
            this.tb_data3Name.PasswordChar = '\0';
            this.tb_data3Name.PromptText = "ex: Sensação termica";
            this.tb_data3Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_data3Name.SelectedText = "";
            this.tb_data3Name.SelectionLength = 0;
            this.tb_data3Name.SelectionStart = 0;
            this.tb_data3Name.ShortcutsEnabled = true;
            this.tb_data3Name.Size = new System.Drawing.Size(245, 23);
            this.tb_data3Name.TabIndex = 34;
            this.tb_data3Name.UseSelectable = true;
            this.tb_data3Name.WaterMark = "ex: Sensação termica";
            this.tb_data3Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_data3Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_data4Name
            // 
            // 
            // 
            // 
            this.tb_data4Name.CustomButton.Image = null;
            this.tb_data4Name.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.tb_data4Name.CustomButton.Name = "";
            this.tb_data4Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_data4Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_data4Name.CustomButton.TabIndex = 1;
            this.tb_data4Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_data4Name.CustomButton.UseSelectable = true;
            this.tb_data4Name.CustomButton.Visible = false;
            this.tb_data4Name.Lines = new string[0];
            this.tb_data4Name.Location = new System.Drawing.Point(78, 253);
            this.tb_data4Name.MaxLength = 32767;
            this.tb_data4Name.Name = "tb_data4Name";
            this.tb_data4Name.PasswordChar = '\0';
            this.tb_data4Name.PromptText = "ex: Pressão atmosférica";
            this.tb_data4Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_data4Name.SelectedText = "";
            this.tb_data4Name.SelectionLength = 0;
            this.tb_data4Name.SelectionStart = 0;
            this.tb_data4Name.ShortcutsEnabled = true;
            this.tb_data4Name.Size = new System.Drawing.Size(245, 23);
            this.tb_data4Name.TabIndex = 35;
            this.tb_data4Name.UseSelectable = true;
            this.tb_data4Name.WaterMark = "ex: Pressão atmosférica";
            this.tb_data4Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_data4Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tg_data1Active
            // 
            this.tg_data1Active.AutoSize = true;
            this.tg_data1Active.Location = new System.Drawing.Point(379, 155);
            this.tg_data1Active.Name = "tg_data1Active";
            this.tg_data1Active.Size = new System.Drawing.Size(80, 17);
            this.tg_data1Active.TabIndex = 36;
            this.tg_data1Active.Text = "Off";
            this.tg_data1Active.UseSelectable = true;
            // 
            // tg_data2Active
            // 
            this.tg_data2Active.AutoSize = true;
            this.tg_data2Active.Location = new System.Drawing.Point(379, 189);
            this.tg_data2Active.Name = "tg_data2Active";
            this.tg_data2Active.Size = new System.Drawing.Size(80, 17);
            this.tg_data2Active.TabIndex = 37;
            this.tg_data2Active.Text = "Off";
            this.tg_data2Active.UseSelectable = true;
            // 
            // tg_data3Active
            // 
            this.tg_data3Active.AutoSize = true;
            this.tg_data3Active.Location = new System.Drawing.Point(379, 222);
            this.tg_data3Active.Name = "tg_data3Active";
            this.tg_data3Active.Size = new System.Drawing.Size(80, 17);
            this.tg_data3Active.TabIndex = 38;
            this.tg_data3Active.Text = "Off";
            this.tg_data3Active.UseSelectable = true;
            // 
            // tg_data4Active
            // 
            this.tg_data4Active.AutoSize = true;
            this.tg_data4Active.Location = new System.Drawing.Point(379, 253);
            this.tg_data4Active.Name = "tg_data4Active";
            this.tg_data4Active.Size = new System.Drawing.Size(80, 17);
            this.tg_data4Active.TabIndex = 39;
            this.tg_data4Active.Text = "Off";
            this.tg_data4Active.UseSelectable = true;
            // 
            // bt_createLink
            // 
            this.bt_createLink.Location = new System.Drawing.Point(78, 293);
            this.bt_createLink.Name = "bt_createLink";
            this.bt_createLink.Size = new System.Drawing.Size(75, 23);
            this.bt_createLink.TabIndex = 40;
            this.bt_createLink.Text = "Vincular";
            this.bt_createLink.UseSelectable = true;
            this.bt_createLink.Click += new System.EventHandler(this.bt_createLink_Click);
            // 
            // EditDevicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 362);
            this.Controls.Add(this.bt_createLink);
            this.Controls.Add(this.pb_spinner);
            this.Controls.Add(this.tg_data4Active);
            this.Controls.Add(this.tg_data3Active);
            this.Controls.Add(this.tg_data2Active);
            this.Controls.Add(this.tg_data1Active);
            this.Controls.Add(this.tb_data4Name);
            this.Controls.Add(this.tb_data3Name);
            this.Controls.Add(this.tb_data2Name);
            this.Controls.Add(this.tb_data1Name);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tb_devicename);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tb_Uid);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditDevicesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Editar Dispositivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner pb_spinner;
        private MetroFramework.Controls.MetroButton bt_save;
        private MetroFramework.Controls.MetroButton bt_cancel;
        private MetroFramework.Controls.MetroTextBox tb_Uid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tb_devicename;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox tb_data1Name;
        private MetroFramework.Controls.MetroTextBox tb_data2Name;
        private MetroFramework.Controls.MetroTextBox tb_data3Name;
        private MetroFramework.Controls.MetroTextBox tb_data4Name;
        private MetroFramework.Controls.MetroToggle tg_data1Active;
        private MetroFramework.Controls.MetroToggle tg_data2Active;
        private MetroFramework.Controls.MetroToggle tg_data3Active;
        private MetroFramework.Controls.MetroToggle tg_data4Active;
        private MetroFramework.Controls.MetroButton bt_createLink;
    }
}