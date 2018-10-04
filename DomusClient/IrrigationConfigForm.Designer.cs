namespace DomusClient
{
    partial class IrrigationConfigForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IrrigationConfigForm));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tg_forecast = new MetroFramework.Controls.MetroToggle();
            this.bt_cancel = new MetroFramework.Controls.MetroButton();
            this.bt_save = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.np_maxTemperature = new System.Windows.Forms.NumericUpDown();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.np_minTemperature = new System.Windows.Forms.NumericUpDown();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.np_maxHumidity = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bt_delet = new MetroFramework.Controls.MetroButton();
            this.bt_edit = new MetroFramework.Controls.MetroButton();
            this.bt_newSchedule = new MetroFramework.Controls.MetroButton();
            this.pb_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.dtg_schedules = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.np_maxTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_minTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_maxHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_schedules)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(400, 360);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(158, 19);
            this.metroLabel2.TabIndex = 88;
            this.metroLabel2.Text = "Usar Previsão do Tempo?";
            // 
            // tg_forecast
            // 
            this.tg_forecast.AutoSize = true;
            this.tg_forecast.Location = new System.Drawing.Point(439, 392);
            this.tg_forecast.Name = "tg_forecast";
            this.tg_forecast.Size = new System.Drawing.Size(80, 17);
            this.tg_forecast.TabIndex = 87;
            this.tg_forecast.Text = "Off";
            this.tg_forecast.UseSelectable = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(132)))), ((int)(((byte)(12)))));
            this.bt_cancel.Location = new System.Drawing.Point(587, 428);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(85, 35);
            this.bt_cancel.Style = MetroFramework.MetroColorStyle.White;
            this.bt_cancel.TabIndex = 86;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseCustomBackColor = true;
            this.bt_cancel.UseSelectable = true;
            this.bt_cancel.UseStyleColors = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_save
            // 
            this.bt_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.bt_save.Location = new System.Drawing.Point(682, 428);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(85, 35);
            this.bt_save.Style = MetroFramework.MetroColorStyle.White;
            this.bt_save.TabIndex = 85;
            this.bt_save.Text = "Salvar";
            this.bt_save.UseCustomBackColor = true;
            this.bt_save.UseSelectable = true;
            this.bt_save.UseStyleColors = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(232, 431);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(40, 19);
            this.metroLabel8.TabIndex = 84;
            this.metroLabel8.Text = "Max.:";
            // 
            // np_maxTemperature
            // 
            this.np_maxTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np_maxTemperature.Location = new System.Drawing.Point(278, 427);
            this.np_maxTemperature.Name = "np_maxTemperature";
            this.np_maxTemperature.Size = new System.Drawing.Size(57, 26);
            this.np_maxTemperature.TabIndex = 83;
            this.np_maxTemperature.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(335, 427);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(30, 25);
            this.metroLabel9.TabIndex = 82;
            this.metroLabel9.Text = "°C";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(235, 388);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(37, 19);
            this.metroLabel7.TabIndex = 81;
            this.metroLabel7.Text = "Min.:";
            // 
            // np_minTemperature
            // 
            this.np_minTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np_minTemperature.Location = new System.Drawing.Point(278, 385);
            this.np_minTemperature.Name = "np_minTemperature";
            this.np_minTemperature.Size = new System.Drawing.Size(57, 26);
            this.np_minTemperature.TabIndex = 80;
            this.np_minTemperature.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(335, 385);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(30, 25);
            this.metroLabel4.TabIndex = 79;
            this.metroLabel4.Text = "°C";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(230, 360);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(125, 19);
            this.metroLabel5.TabIndex = 78;
            this.metroLabel5.Text = "Temperatura do Ár:";
            // 
            // np_maxHumidity
            // 
            this.np_maxHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np_maxHumidity.Location = new System.Drawing.Point(67, 385);
            this.np_maxHumidity.Name = "np_maxHumidity";
            this.np_maxHumidity.Size = new System.Drawing.Size(57, 26);
            this.np_maxHumidity.TabIndex = 77;
            this.np_maxHumidity.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(124, 385);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(28, 25);
            this.metroLabel3.TabIndex = 76;
            this.metroLabel3.Text = "%";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 360);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(174, 19);
            this.metroLabel1.TabIndex = 75;
            this.metroLabel1.Text = "Humidade Máxima do Solo:";
            // 
            // bt_delet
            // 
            this.bt_delet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_delet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(132)))), ((int)(((byte)(12)))));
            this.bt_delet.Location = new System.Drawing.Point(492, 74);
            this.bt_delet.Name = "bt_delet";
            this.bt_delet.Size = new System.Drawing.Size(85, 35);
            this.bt_delet.Style = MetroFramework.MetroColorStyle.White;
            this.bt_delet.TabIndex = 74;
            this.bt_delet.Text = "Deletar";
            this.bt_delet.UseCustomBackColor = true;
            this.bt_delet.UseSelectable = true;
            this.bt_delet.UseStyleColors = true;
            this.bt_delet.Click += new System.EventHandler(this.bt_delet_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_edit.Location = new System.Drawing.Point(587, 74);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(85, 35);
            this.bt_edit.TabIndex = 73;
            this.bt_edit.Text = "Editar";
            this.bt_edit.UseSelectable = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_newSchedule
            // 
            this.bt_newSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_newSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_newSchedule.Location = new System.Drawing.Point(682, 74);
            this.bt_newSchedule.Name = "bt_newSchedule";
            this.bt_newSchedule.Size = new System.Drawing.Size(85, 35);
            this.bt_newSchedule.Style = MetroFramework.MetroColorStyle.White;
            this.bt_newSchedule.TabIndex = 72;
            this.bt_newSchedule.Text = "Novo";
            this.bt_newSchedule.UseCustomBackColor = true;
            this.bt_newSchedule.UseSelectable = true;
            this.bt_newSchedule.UseStyleColors = true;
            this.bt_newSchedule.Click += new System.EventHandler(this.bt_newSchedule_Click);
            // 
            // pb_spinner
            // 
            this.pb_spinner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_spinner.Enabled = false;
            this.pb_spinner.Location = new System.Drawing.Point(380, 210);
            this.pb_spinner.Maximum = 4;
            this.pb_spinner.Name = "pb_spinner";
            this.pb_spinner.Size = new System.Drawing.Size(32, 32);
            this.pb_spinner.TabIndex = 71;
            this.pb_spinner.TabStop = false;
            this.pb_spinner.UseSelectable = true;
            this.pb_spinner.Value = 1;
            this.pb_spinner.Visible = false;
            // 
            // dtg_schedules
            // 
            this.dtg_schedules.AllowUserToAddRows = false;
            this.dtg_schedules.AllowUserToDeleteRows = false;
            this.dtg_schedules.AllowUserToResizeRows = false;
            this.dtg_schedules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_schedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtg_schedules.BackgroundColor = System.Drawing.Color.White;
            this.dtg_schedules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_schedules.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_schedules.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_schedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_schedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_schedules.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_schedules.EnableHeadersVisualStyles = false;
            this.dtg_schedules.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtg_schedules.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_schedules.Location = new System.Drawing.Point(23, 126);
            this.dtg_schedules.MultiSelect = false;
            this.dtg_schedules.Name = "dtg_schedules";
            this.dtg_schedules.ReadOnly = true;
            this.dtg_schedules.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_schedules.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_schedules.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtg_schedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_schedules.Size = new System.Drawing.Size(744, 219);
            this.dtg_schedules.TabIndex = 70;
            // 
            // IrrigationConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 486);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tg_forecast);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.np_maxTemperature);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.np_minTemperature);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.np_maxHumidity);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.bt_delet);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_newSchedule);
            this.Controls.Add(this.pb_spinner);
            this.Controls.Add(this.dtg_schedules);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IrrigationConfigForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Irrigação";
            this.Load += new System.EventHandler(this.IrrigationConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.np_maxTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_minTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_maxHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_schedules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle tg_forecast;
        private MetroFramework.Controls.MetroButton bt_cancel;
        private MetroFramework.Controls.MetroButton bt_save;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.NumericUpDown np_maxTemperature;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.NumericUpDown np_minTemperature;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.NumericUpDown np_maxHumidity;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton bt_delet;
        private MetroFramework.Controls.MetroButton bt_edit;
        private MetroFramework.Controls.MetroButton bt_newSchedule;
        private MetroFramework.Controls.MetroProgressSpinner pb_spinner;
        private MetroFramework.Controls.MetroGrid dtg_schedules;
    }
}