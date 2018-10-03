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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tg_active = new MetroFramework.Controls.MetroToggle();
            this.np_duration = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle3 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle4 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle5 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle6 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle7 = new MetroFramework.Controls.MetroToggle();
            this.bt_cancel = new MetroFramework.Controls.MetroButton();
            this.bt_save = new MetroFramework.Controls.MetroButton();
            this.cb_timeScale = new MetroFramework.Controls.MetroComboBox();
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
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(79, 80);
            this.metroTextBox1.MaxLength = 44;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(241, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.metroDateTime1.Location = new System.Drawing.Point(398, 75);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(95, 29);
            this.metroDateTime1.TabIndex = 2;
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
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(164, 201);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 85;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
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
            // metroToggle2
            // 
            this.metroToggle2.AutoSize = true;
            this.metroToggle2.Location = new System.Drawing.Point(352, 201);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(80, 17);
            this.metroToggle2.TabIndex = 87;
            this.metroToggle2.Text = "Off";
            this.metroToggle2.UseSelectable = true;
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
            // metroToggle3
            // 
            this.metroToggle3.AutoSize = true;
            this.metroToggle3.Location = new System.Drawing.Point(352, 240);
            this.metroToggle3.Name = "metroToggle3";
            this.metroToggle3.Size = new System.Drawing.Size(80, 17);
            this.metroToggle3.TabIndex = 89;
            this.metroToggle3.Text = "Off";
            this.metroToggle3.UseSelectable = true;
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
            // metroToggle4
            // 
            this.metroToggle4.AutoSize = true;
            this.metroToggle4.Location = new System.Drawing.Point(352, 279);
            this.metroToggle4.Name = "metroToggle4";
            this.metroToggle4.Size = new System.Drawing.Size(80, 17);
            this.metroToggle4.TabIndex = 91;
            this.metroToggle4.Text = "Off";
            this.metroToggle4.UseSelectable = true;
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
            // metroToggle5
            // 
            this.metroToggle5.AutoSize = true;
            this.metroToggle5.Location = new System.Drawing.Point(164, 320);
            this.metroToggle5.Name = "metroToggle5";
            this.metroToggle5.Size = new System.Drawing.Size(80, 17);
            this.metroToggle5.TabIndex = 93;
            this.metroToggle5.Text = "Off";
            this.metroToggle5.UseSelectable = true;
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
            // metroToggle6
            // 
            this.metroToggle6.AutoSize = true;
            this.metroToggle6.Location = new System.Drawing.Point(164, 279);
            this.metroToggle6.Name = "metroToggle6";
            this.metroToggle6.Size = new System.Drawing.Size(80, 17);
            this.metroToggle6.TabIndex = 95;
            this.metroToggle6.Text = "Off";
            this.metroToggle6.UseSelectable = true;
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
            // metroToggle7
            // 
            this.metroToggle7.AutoSize = true;
            this.metroToggle7.Location = new System.Drawing.Point(164, 242);
            this.metroToggle7.Name = "metroToggle7";
            this.metroToggle7.Size = new System.Drawing.Size(80, 17);
            this.metroToggle7.TabIndex = 97;
            this.metroToggle7.Text = "Off";
            this.metroToggle7.UseSelectable = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(335, 404);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 102;
            this.bt_cancel.Text = "Sair";
            this.bt_cancel.UseSelectable = true;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_save.Location = new System.Drawing.Point(431, 404);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.Style = MetroFramework.MetroColorStyle.White;
            this.bt_save.TabIndex = 101;
            this.bt_save.Text = "Salvar";
            this.bt_save.UseCustomBackColor = true;
            this.bt_save.UseSelectable = true;
            this.bt_save.UseStyleColors = true;
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
            // EditIrrigationSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.cb_timeScale);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroToggle7);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroToggle6);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroToggle5);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroToggle4);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroToggle3);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroToggle2);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.np_duration);
            this.Controls.Add(this.tg_active);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroTextBox1);
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
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle tg_active;
        private System.Windows.Forms.NumericUpDown np_duration;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle metroToggle3;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroToggle metroToggle4;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroToggle metroToggle5;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroToggle metroToggle6;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroToggle metroToggle7;
        private MetroFramework.Controls.MetroButton bt_cancel;
        private MetroFramework.Controls.MetroButton bt_save;
        private MetroFramework.Controls.MetroComboBox cb_timeScale;
    }
}