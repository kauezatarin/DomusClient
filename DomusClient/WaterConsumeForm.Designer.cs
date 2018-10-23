namespace DomusClient
{
    partial class WaterConsumeForm
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
            this.WaterConsumeChart = new LiveCharts.WinForms.CartesianChart();
            this.np_year = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bt_applyDate = new MetroFramework.Controls.MetroButton();
            this.pb_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lb_volume = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.np_year)).BeginInit();
            this.SuspendLayout();
            // 
            // WaterConsumeChart
            // 
            this.WaterConsumeChart.Location = new System.Drawing.Point(23, 136);
            this.WaterConsumeChart.Name = "WaterConsumeChart";
            this.WaterConsumeChart.Size = new System.Drawing.Size(754, 291);
            this.WaterConsumeChart.TabIndex = 0;
            this.WaterConsumeChart.Text = "Consumo de Água";
            // 
            // np_year
            // 
            this.np_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np_year.Location = new System.Drawing.Point(600, 99);
            this.np_year.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.np_year.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.np_year.Name = "np_year";
            this.np_year.Size = new System.Drawing.Size(69, 26);
            this.np_year.TabIndex = 82;
            this.np_year.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(545, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 25);
            this.metroLabel1.TabIndex = 83;
            this.metroLabel1.Text = "Ano:";
            // 
            // bt_applyDate
            // 
            this.bt_applyDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_applyDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.bt_applyDate.Location = new System.Drawing.Point(692, 95);
            this.bt_applyDate.Name = "bt_applyDate";
            this.bt_applyDate.Size = new System.Drawing.Size(85, 35);
            this.bt_applyDate.Style = MetroFramework.MetroColorStyle.White;
            this.bt_applyDate.TabIndex = 84;
            this.bt_applyDate.Text = "Buscar";
            this.bt_applyDate.UseCustomBackColor = true;
            this.bt_applyDate.UseSelectable = true;
            this.bt_applyDate.UseStyleColors = true;
            this.bt_applyDate.Click += new System.EventHandler(this.bt_applyDate_Click);
            // 
            // pb_spinner
            // 
            this.pb_spinner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_spinner.Enabled = false;
            this.pb_spinner.Location = new System.Drawing.Point(394, 222);
            this.pb_spinner.Maximum = 4;
            this.pb_spinner.Name = "pb_spinner";
            this.pb_spinner.Size = new System.Drawing.Size(32, 32);
            this.pb_spinner.TabIndex = 85;
            this.pb_spinner.TabStop = false;
            this.pb_spinner.UseSelectable = true;
            this.pb_spinner.Value = 1;
            this.pb_spinner.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(46, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 86;
            this.metroLabel2.Text = "Volume Total:";
            // 
            // lb_volume
            // 
            this.lb_volume.AutoSize = true;
            this.lb_volume.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_volume.Location = new System.Drawing.Point(143, 105);
            this.lb_volume.Name = "lb_volume";
            this.lb_volume.Size = new System.Drawing.Size(15, 19);
            this.lb_volume.TabIndex = 87;
            this.lb_volume.Text = "-";
            // 
            // WaterConsumeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_volume);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pb_spinner);
            this.Controls.Add(this.bt_applyDate);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.np_year);
            this.Controls.Add(this.WaterConsumeChart);
            this.MaximizeBox = false;
            this.Name = "WaterConsumeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Consumo de Água";
            this.Load += new System.EventHandler(this.WaterConsumeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.np_year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart WaterConsumeChart;
        private System.Windows.Forms.NumericUpDown np_year;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton bt_applyDate;
        private MetroFramework.Controls.MetroProgressSpinner pb_spinner;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lb_volume;
    }
}