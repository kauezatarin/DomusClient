namespace DomusClient
{
    partial class EditIrrigationSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditIrrigationSchedule));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tb_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tg_active = new MetroFramework.Controls.MetroToggle();
            this.np_duration = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tg_monday = new MetroFramework.Controls.MetroToggle();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tg_friday = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tg_saturday = new MetroFramework.Controls.MetroToggle();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tg_sunday = new MetroFramework.Controls.MetroToggle();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tg_thursday = new MetroFramework.Controls.MetroToggle();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.tg_wednesday = new MetroFramework.Controls.MetroToggle();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.tg_tuesday = new MetroFramework.Controls.MetroToggle();
            this.bt_cancel = new MetroFramework.Controls.MetroButton();
            this.bt_save = new MetroFramework.Controls.MetroButton();
            this.cb_timeScale = new MetroFramework.Controls.MetroComboBox();
            this.dt_hour = new System.Windows.Forms.DateTimePicker();
            this.pb_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            ((System.ComponentModel.ISupportInitialize)(this.np_duration)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome:";
            // 
            // tb_name
            // 
            // 
            // 
            // 
            this.tb_name.CustomButton.Image = null;
            this.tb_name.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.tb_name.CustomButton.Name = "";
            this.tb_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_name.CustomButton.TabIndex = 1;
            this.tb_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_name.CustomButton.UseSelectable = true;
            this.tb_name.CustomButton.Visible = false;
            this.tb_name.Lines = new string[0];
            this.tb_name.Location = new System.Drawing.Point(79, 80);
            this.tb_name.MaxLength = 44;
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_name.SelectedText = "";
            this.tb_name.SelectionLength = 0;
            this.tb_name.SelectionStart = 0;
            this.tb_name.ShortcutsEnabled = true;
            this.tb_name.Size = new System.Drawing.Size(241, 23);
            this.tb_name.TabIndex = 1;
            this.tb_name.UseSelectable = true;
            this.tb_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(351, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Hora:";
            // 
            // tg_active
            // 
            this.tg_active.AutoSize = true;
            this.tg_active.Location = new System.Drawing.Point(398, 134);
            this.tg_active.Name = "tg_active";
            this.tg_active.Size = new System.Drawing.Size(80, 17);
            this.tg_active.TabIndex = 4;
            this.tg_active.Text = "Off";
            this.tg_active.UseSelectable = true;
            // 
            // np_duration
            // 
            this.np_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np_duration.Location = new System.Drawing.Point(91, 134);
            this.np_duration.Maximum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.np_duration.Name = "np_duration";
            this.np_duration.Size = new System.Drawing.Size(57, 26);
            this.np_duration.TabIndex = 81;
            this.np_duration.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 136);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 82;
            this.metroLabel3.Text = "Duração:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(351, 132);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(42, 19);
            this.metroLabel5.TabIndex = 84;
            this.metroLabel5.Text = "Ativo:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(95, 201);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 86;
            this.metroLabel6.Text = "Segunda:";
            // 
            // tg_monday
            // 
            this.tg_monday.AutoSize = true;
            this.tg_monday.Location = new System.Drawing.Point(164, 201);
            this.tg_monday.Name = "tg_monday";
            this.tg_monday.Size = new System.Drawing.Size(80, 17);
            this.tg_monday.TabIndex = 85;
            this.tg_monday.Text = "Off";
            this.tg_monday.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(279, 201);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(43, 19);
            this.metroLabel7.TabIndex = 88;
            this.metroLabel7.Text = "Sexta:";
            // 
            // tg_friday
            // 
            this.tg_friday.AutoSize = true;
            this.tg_friday.Location = new System.Drawing.Point(352, 201);
            this.tg_friday.Name = "tg_friday";
            this.tg_friday.Size = new System.Drawing.Size(80, 17);
            this.tg_friday.TabIndex = 87;
            this.tg_friday.Text = "Off";
            this.tg_friday.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(279, 240);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(57, 19);
            this.metroLabel8.TabIndex = 90;
            this.metroLabel8.Text = "Sábado:";
            // 
            // tg_saturday
            // 
            this.tg_saturday.AutoSize = true;
            this.tg_saturday.Location = new System.Drawing.Point(352, 240);
            this.tg_saturday.Name = "tg_saturday";
            this.tg_saturday.Size = new System.Drawing.Size(80, 17);
            this.tg_saturday.TabIndex = 89;
            this.tg_saturday.Text = "Off";
            this.tg_saturday.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(279, 279);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(67, 19);
            this.metroLabel9.TabIndex = 92;
            this.metroLabel9.Text = "Domingo:";
            // 
            // tg_sunday
            // 
            this.tg_sunday.AutoSize = true;
            this.tg_sunday.Location = new System.Drawing.Point(352, 279);
            this.tg_sunday.Name = "tg_sunday";
            this.tg_sunday.Size = new System.Drawing.Size(80, 17);
            this.tg_sunday.TabIndex = 91;
            this.tg_sunday.Text = "Off";
            this.tg_sunday.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(95, 318);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(51, 19);
            this.metroLabel10.TabIndex = 94;
            this.metroLabel10.Text = "Quinta:";
            // 
            // tg_thursday
            // 
            this.tg_thursday.AutoSize = true;
            this.tg_thursday.Location = new System.Drawing.Point(164, 320);
            this.tg_thursday.Name = "tg_thursday";
            this.tg_thursday.Size = new System.Drawing.Size(80, 17);
            this.tg_thursday.TabIndex = 93;
            this.tg_thursday.Text = "Off";
            this.tg_thursday.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(95, 281);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(54, 19);
            this.metroLabel11.TabIndex = 96;
            this.metroLabel11.Text = "Quarta:";
            // 
            // tg_wednesday
            // 
            this.tg_wednesday.AutoSize = true;
            this.tg_wednesday.Location = new System.Drawing.Point(164, 279);
            this.tg_wednesday.Name = "tg_wednesday";
            this.tg_wednesday.Size = new System.Drawing.Size(80, 17);
            this.tg_wednesday.TabIndex = 95;
            this.tg_wednesday.Text = "Off";
            this.tg_wednesday.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(95, 240);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(42, 19);
            this.metroLabel12.TabIndex = 98;
            this.metroLabel12.Text = "Terça:";
            // 
            // tg_tuesday
            // 
            this.tg_tuesday.AutoSize = true;
            this.tg_tuesday.Location = new System.Drawing.Point(164, 242);
            this.tg_tuesday.Name = "tg_tuesday";
            this.tg_tuesday.Size = new System.Drawing.Size(80, 17);
            this.tg_tuesday.TabIndex = 97;
            this.tg_tuesday.Text = "Off";
            this.tg_tuesday.UseSelectable = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(335, 364);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 102;
            this.bt_cancel.Text = "Sair";
            this.bt_cancel.UseSelectable = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_save.Location = new System.Drawing.Point(431, 364);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.Style = MetroFramework.MetroColorStyle.White;
            this.bt_save.TabIndex = 101;
            this.bt_save.Text = "Salvar";
            this.bt_save.UseCustomBackColor = true;
            this.bt_save.UseSelectable = true;
            this.bt_save.UseStyleColors = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // cb_timeScale
            // 
            this.cb_timeScale.FormattingEnabled = true;
            this.cb_timeScale.ItemHeight = 23;
            this.cb_timeScale.Items.AddRange(new object[] {
            "Segundo(s)",
            "Minuto(s)"});
            this.cb_timeScale.Location = new System.Drawing.Point(164, 132);
            this.cb_timeScale.Name = "cb_timeScale";
            this.cb_timeScale.Size = new System.Drawing.Size(121, 29);
            this.cb_timeScale.TabIndex = 103;
            this.cb_timeScale.UseSelectable = true;
            // 
            // dt_hour
            // 
            this.dt_hour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_hour.Location = new System.Drawing.Point(398, 80);
            this.dt_hour.Name = "dt_hour";
            this.dt_hour.ShowUpDown = true;
            this.dt_hour.Size = new System.Drawing.Size(80, 20);
            this.dt_hour.TabIndex = 104;
            this.dt_hour.Value = new System.DateTime(2018, 10, 3, 12, 0, 0, 0);
            // 
            // pb_spinner
            // 
            this.pb_spinner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_spinner.Enabled = false;
            this.pb_spinner.Location = new System.Drawing.Point(248, 189);
            this.pb_spinner.Maximum = 4;
            this.pb_spinner.Name = "pb_spinner";
            this.pb_spinner.Size = new System.Drawing.Size(32, 32);
            this.pb_spinner.TabIndex = 105;
            this.pb_spinner.TabStop = false;
            this.pb_spinner.UseSelectable = true;
            this.pb_spinner.Value = 1;
            this.pb_spinner.Visible = false;
            // 
            // EditIrrigationSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 410);
            this.Controls.Add(this.pb_spinner);
            this.Controls.Add(this.dt_hour);
            this.Controls.Add(this.cb_timeScale);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.tg_tuesday);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.tg_wednesday);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.tg_thursday);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.tg_sunday);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.tg_saturday);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.tg_friday);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.tg_monday);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.np_duration);
            this.Controls.Add(this.tg_active);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditIrrigationSchedule";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Agendar Irrigação";
            this.Load += new System.EventHandler(this.EditIrrigationSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.np_duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tb_name;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle tg_active;
        private System.Windows.Forms.NumericUpDown np_duration;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle tg_monday;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroToggle tg_friday;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle tg_saturday;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroToggle tg_sunday;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroToggle tg_thursday;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroToggle tg_wednesday;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroToggle tg_tuesday;
        private MetroFramework.Controls.MetroButton bt_cancel;
        private MetroFramework.Controls.MetroButton bt_save;
        private MetroFramework.Controls.MetroComboBox cb_timeScale;
        private System.Windows.Forms.DateTimePicker dt_hour;
        private MetroFramework.Controls.MetroProgressSpinner pb_spinner;
    }
}