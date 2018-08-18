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
            this.tb_username = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
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
            // tb_username
            // 
            // 
            // 
            // 
            this.tb_username.CustomButton.Image = null;
            this.tb_username.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.tb_username.CustomButton.Name = "";
            this.tb_username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_username.CustomButton.TabIndex = 1;
            this.tb_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_username.CustomButton.UseSelectable = true;
            this.tb_username.CustomButton.Visible = false;
            this.tb_username.Lines = new string[0];
            this.tb_username.Location = new System.Drawing.Point(78, 111);
            this.tb_username.MaxLength = 32767;
            this.tb_username.Name = "tb_username";
            this.tb_username.PasswordChar = '\0';
            this.tb_username.PromptText = "ex: nome do dispositivo";
            this.tb_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_username.SelectedText = "";
            this.tb_username.SelectionLength = 0;
            this.tb_username.SelectionStart = 0;
            this.tb_username.ShortcutsEnabled = true;
            this.tb_username.Size = new System.Drawing.Size(424, 23);
            this.tb_username.TabIndex = 27;
            this.tb_username.UseSelectable = true;
            this.tb_username.WaterMark = "ex: nome do dispositivo";
            this.tb_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // EditDevicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 362);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tb_Uid);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.pb_spinner);
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
        private MetroFramework.Controls.MetroTextBox tb_username;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}