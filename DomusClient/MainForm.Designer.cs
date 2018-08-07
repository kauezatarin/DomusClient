namespace DomusClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bt_devices = new MetroFramework.Controls.MetroTile();
            this.bt_wather = new MetroFramework.Controls.MetroTile();
            this.bt_energy = new MetroFramework.Controls.MetroTile();
            this.bt_irrigation = new MetroFramework.Controls.MetroTile();
            this.bt_cistern = new MetroFramework.Controls.MetroTile();
            this.bt_plugs = new MetroFramework.Controls.MetroTile();
            this.bt_users = new MetroFramework.Controls.MetroTile();
            this.bt_settings = new MetroFramework.Controls.MetroTile();
            this.bt_exit = new MetroFramework.Controls.MetroTile();
            this.llb_about = new MetroFramework.Controls.MetroLink();
            this.pb_forecast = new System.Windows.Forms.PictureBox();
            this.lb_forecastLocation = new MetroFramework.Controls.MetroLabel();
            this.lb_forecastMinValue = new MetroFramework.Controls.MetroLabel();
            this.lb_forecastMin = new MetroFramework.Controls.MetroLabel();
            this.lb_forecastMax = new MetroFramework.Controls.MetroLabel();
            this.lb_forecastMaxValue = new MetroFramework.Controls.MetroLabel();
            this.lb_humidity = new MetroFramework.Controls.MetroLabel();
            this.lb_humidityValue = new MetroFramework.Controls.MetroLabel();
            this.pb_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.pb_warning = new System.Windows.Forms.PictureBox();
            this.lb_ImageDescription = new MetroFramework.Controls.MetroLabel();
            this.pl_weather = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_forecast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_warning)).BeginInit();
            this.pl_weather.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_devices
            // 
            this.bt_devices.ActiveControl = null;
            this.bt_devices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(23)))), ((int)(((byte)(178)))));
            this.bt_devices.Location = new System.Drawing.Point(133, 219);
            this.bt_devices.Name = "bt_devices";
            this.bt_devices.Size = new System.Drawing.Size(100, 68);
            this.bt_devices.Style = MetroFramework.MetroColorStyle.Purple;
            this.bt_devices.TabIndex = 7;
            this.bt_devices.TabStop = false;
            this.bt_devices.Text = "Dispositivos";
            this.bt_devices.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_devices.TileImage = ((System.Drawing.Image)(resources.GetObject("bt_devices.TileImage")));
            this.bt_devices.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bt_devices.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bt_devices.UseSelectable = true;
            this.bt_devices.UseTileImage = true;
            this.bt_devices.Click += new System.EventHandler(this.bt_devices_Click);
            // 
            // bt_wather
            // 
            this.bt_wather.ActiveControl = null;
            this.bt_wather.Location = new System.Drawing.Point(133, 63);
            this.bt_wather.Name = "bt_wather";
            this.bt_wather.Size = new System.Drawing.Size(100, 68);
            this.bt_wather.TabIndex = 1;
            this.bt_wather.TabStop = false;
            this.bt_wather.Text = "Água";
            this.bt_wather.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_wather.TileImage = ((System.Drawing.Image)(resources.GetObject("bt_wather.TileImage")));
            this.bt_wather.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bt_wather.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bt_wather.UseSelectable = true;
            this.bt_wather.UseTileImage = true;
            // 
            // bt_energy
            // 
            this.bt_energy.ActiveControl = null;
            this.bt_energy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(7)))));
            this.bt_energy.Location = new System.Drawing.Point(23, 63);
            this.bt_energy.Name = "bt_energy";
            this.bt_energy.Size = new System.Drawing.Size(100, 68);
            this.bt_energy.TabIndex = 0;
            this.bt_energy.TabStop = false;
            this.bt_energy.Text = "Energia";
            this.bt_energy.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_energy.TileImage = global::DomusClient.Properties.Resources.lightningbolt;
            this.bt_energy.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bt_energy.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bt_energy.UseCustomBackColor = true;
            this.bt_energy.UseSelectable = true;
            this.bt_energy.UseTileImage = true;
            // 
            // bt_irrigation
            // 
            this.bt_irrigation.ActiveControl = null;
            this.bt_irrigation.Location = new System.Drawing.Point(133, 141);
            this.bt_irrigation.Name = "bt_irrigation";
            this.bt_irrigation.Size = new System.Drawing.Size(100, 68);
            this.bt_irrigation.Style = MetroFramework.MetroColorStyle.Green;
            this.bt_irrigation.TabIndex = 4;
            this.bt_irrigation.TabStop = false;
            this.bt_irrigation.Text = "Irrigação";
            this.bt_irrigation.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_irrigation.TileImage = ((System.Drawing.Image)(resources.GetObject("bt_irrigation.TileImage")));
            this.bt_irrigation.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bt_irrigation.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bt_irrigation.UseSelectable = true;
            this.bt_irrigation.UseTileImage = true;
            // 
            // bt_cistern
            // 
            this.bt_cistern.ActiveControl = null;
            this.bt_cistern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_cistern.Location = new System.Drawing.Point(23, 141);
            this.bt_cistern.Name = "bt_cistern";
            this.bt_cistern.Size = new System.Drawing.Size(100, 68);
            this.bt_cistern.TabIndex = 3;
            this.bt_cistern.TabStop = false;
            this.bt_cistern.Text = "Cisterna";
            this.bt_cistern.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_cistern.TileImage = global::DomusClient.Properties.Resources.watertower;
            this.bt_cistern.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bt_cistern.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bt_cistern.UseCustomBackColor = true;
            this.bt_cistern.UseSelectable = true;
            this.bt_cistern.UseTileImage = true;
            // 
            // bt_plugs
            // 
            this.bt_plugs.ActiveControl = null;
            this.bt_plugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(7)))));
            this.bt_plugs.Location = new System.Drawing.Point(23, 219);
            this.bt_plugs.Name = "bt_plugs";
            this.bt_plugs.Size = new System.Drawing.Size(100, 68);
            this.bt_plugs.Style = MetroFramework.MetroColorStyle.Orange;
            this.bt_plugs.TabIndex = 6;
            this.bt_plugs.TabStop = false;
            this.bt_plugs.Text = "Tomadas";
            this.bt_plugs.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_plugs.TileImage = ((System.Drawing.Image)(resources.GetObject("bt_plugs.TileImage")));
            this.bt_plugs.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bt_plugs.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bt_plugs.UseSelectable = true;
            this.bt_plugs.UseTileImage = true;
            // 
            // bt_users
            // 
            this.bt_users.ActiveControl = null;
            this.bt_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(23)))), ((int)(((byte)(178)))));
            this.bt_users.Location = new System.Drawing.Point(243, 63);
            this.bt_users.Name = "bt_users";
            this.bt_users.Size = new System.Drawing.Size(100, 68);
            this.bt_users.Style = MetroFramework.MetroColorStyle.Purple;
            this.bt_users.TabIndex = 2;
            this.bt_users.TabStop = false;
            this.bt_users.Text = "Usuários";
            this.bt_users.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_users.TileImage = ((System.Drawing.Image)(resources.GetObject("bt_users.TileImage")));
            this.bt_users.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bt_users.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bt_users.UseSelectable = true;
            this.bt_users.UseTileImage = true;
            this.bt_users.Click += new System.EventHandler(this.bt_users_Click);
            // 
            // bt_settings
            // 
            this.bt_settings.ActiveControl = null;
            this.bt_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_settings.Location = new System.Drawing.Point(243, 141);
            this.bt_settings.Name = "bt_settings";
            this.bt_settings.Size = new System.Drawing.Size(100, 68);
            this.bt_settings.TabIndex = 5;
            this.bt_settings.TabStop = false;
            this.bt_settings.Text = "Configurações";
            this.bt_settings.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_settings.TileImage = ((System.Drawing.Image)(resources.GetObject("bt_settings.TileImage")));
            this.bt_settings.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bt_settings.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.bt_settings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bt_settings.UseCustomBackColor = true;
            this.bt_settings.UseSelectable = true;
            this.bt_settings.UseTileImage = true;
            this.bt_settings.Click += new System.EventHandler(this.bt_settings_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.ActiveControl = null;
            this.bt_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(23)))), ((int)(((byte)(178)))));
            this.bt_exit.Location = new System.Drawing.Point(243, 219);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(100, 68);
            this.bt_exit.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_exit.TabIndex = 8;
            this.bt_exit.TabStop = false;
            this.bt_exit.Text = "Sair";
            this.bt_exit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_exit.TileImage = global::DomusClient.Properties.Resources.logout;
            this.bt_exit.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bt_exit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bt_exit.UseSelectable = true;
            this.bt_exit.UseTileImage = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // llb_about
            // 
            this.llb_about.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.llb_about.Location = new System.Drawing.Point(421, 264);
            this.llb_about.Name = "llb_about";
            this.llb_about.Size = new System.Drawing.Size(126, 23);
            this.llb_about.TabIndex = 9;
            this.llb_about.TabStop = false;
            this.llb_about.Text = "Sobre - Domus Client";
            this.llb_about.UseSelectable = true;
            this.llb_about.Click += new System.EventHandler(this.llb_about_Click);
            // 
            // pb_forecast
            // 
            this.pb_forecast.Image = global::DomusClient.Properties.Resources.forecastSample;
            this.pb_forecast.Location = new System.Drawing.Point(31, 3);
            this.pb_forecast.Name = "pb_forecast";
            this.pb_forecast.Size = new System.Drawing.Size(48, 48);
            this.pb_forecast.TabIndex = 10;
            this.pb_forecast.TabStop = false;
            // 
            // lb_forecastLocation
            // 
            this.lb_forecastLocation.AutoSize = true;
            this.lb_forecastLocation.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lb_forecastLocation.Location = new System.Drawing.Point(86, 4);
            this.lb_forecastLocation.Name = "lb_forecastLocation";
            this.lb_forecastLocation.Size = new System.Drawing.Size(76, 15);
            this.lb_forecastLocation.TabIndex = 11;
            this.lb_forecastLocation.Text = "Piracicaba, SP";
            // 
            // lb_forecastMinValue
            // 
            this.lb_forecastMinValue.AutoSize = true;
            this.lb_forecastMinValue.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lb_forecastMinValue.Location = new System.Drawing.Point(153, 42);
            this.lb_forecastMinValue.Name = "lb_forecastMinValue";
            this.lb_forecastMinValue.Size = new System.Drawing.Size(34, 15);
            this.lb_forecastMinValue.TabIndex = 12;
            this.lb_forecastMinValue.Text = "-22ºc";
            // 
            // lb_forecastMin
            // 
            this.lb_forecastMin.AutoSize = true;
            this.lb_forecastMin.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lb_forecastMin.Location = new System.Drawing.Point(126, 42);
            this.lb_forecastMin.Name = "lb_forecastMin";
            this.lb_forecastMin.Size = new System.Drawing.Size(31, 15);
            this.lb_forecastMin.TabIndex = 13;
            this.lb_forecastMin.Text = "Min.:";
            // 
            // lb_forecastMax
            // 
            this.lb_forecastMax.AutoSize = true;
            this.lb_forecastMax.Location = new System.Drawing.Point(89, 23);
            this.lb_forecastMax.Name = "lb_forecastMax";
            this.lb_forecastMax.Size = new System.Drawing.Size(40, 19);
            this.lb_forecastMax.TabIndex = 15;
            this.lb_forecastMax.Text = "Max.:";
            // 
            // lb_forecastMaxValue
            // 
            this.lb_forecastMaxValue.AutoSize = true;
            this.lb_forecastMaxValue.Location = new System.Drawing.Point(126, 23);
            this.lb_forecastMaxValue.Name = "lb_forecastMaxValue";
            this.lb_forecastMaxValue.Size = new System.Drawing.Size(41, 19);
            this.lb_forecastMaxValue.TabIndex = 14;
            this.lb_forecastMaxValue.Text = "-22ºc";
            // 
            // lb_humidity
            // 
            this.lb_humidity.AutoSize = true;
            this.lb_humidity.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lb_humidity.Location = new System.Drawing.Point(107, 60);
            this.lb_humidity.Name = "lb_humidity";
            this.lb_humidity.Size = new System.Drawing.Size(46, 15);
            this.lb_humidity.TabIndex = 16;
            this.lb_humidity.Text = "Humid.:";
            // 
            // lb_humidityValue
            // 
            this.lb_humidityValue.AutoSize = true;
            this.lb_humidityValue.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lb_humidityValue.Location = new System.Drawing.Point(155, 60);
            this.lb_humidityValue.Name = "lb_humidityValue";
            this.lb_humidityValue.Size = new System.Drawing.Size(35, 15);
            this.lb_humidityValue.TabIndex = 17;
            this.lb_humidityValue.Text = "100 %";
            // 
            // pb_spinner
            // 
            this.pb_spinner.Location = new System.Drawing.Point(96, 22);
            this.pb_spinner.Maximum = 4;
            this.pb_spinner.Name = "pb_spinner";
            this.pb_spinner.Size = new System.Drawing.Size(24, 24);
            this.pb_spinner.TabIndex = 18;
            this.pb_spinner.UseSelectable = true;
            this.pb_spinner.Visible = false;
            // 
            // pb_warning
            // 
            this.pb_warning.BackColor = System.Drawing.Color.Transparent;
            this.pb_warning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_warning.Image = global::DomusClient.Properties.Resources.warning;
            this.pb_warning.Location = new System.Drawing.Point(89, 14);
            this.pb_warning.Name = "pb_warning";
            this.pb_warning.Size = new System.Drawing.Size(32, 32);
            this.pb_warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_warning.TabIndex = 19;
            this.pb_warning.TabStop = false;
            this.pb_warning.Visible = false;
            this.pb_warning.Click += new System.EventHandler(this.pb_warning_Click);
            // 
            // lb_ImageDescription
            // 
            this.lb_ImageDescription.AutoSize = true;
            this.lb_ImageDescription.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lb_ImageDescription.Location = new System.Drawing.Point(12, 54);
            this.lb_ImageDescription.Name = "lb_ImageDescription";
            this.lb_ImageDescription.Size = new System.Drawing.Size(85, 15);
            this.lb_ImageDescription.TabIndex = 20;
            this.lb_ImageDescription.Text = "Parcial Nublado";
            this.lb_ImageDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_weather
            // 
            this.pl_weather.Controls.Add(this.lb_ImageDescription);
            this.pl_weather.Controls.Add(this.pb_warning);
            this.pl_weather.Controls.Add(this.pb_spinner);
            this.pl_weather.Controls.Add(this.pb_forecast);
            this.pl_weather.Controls.Add(this.lb_forecastLocation);
            this.pl_weather.Controls.Add(this.lb_humidityValue);
            this.pl_weather.Controls.Add(this.lb_forecastMinValue);
            this.pl_weather.Controls.Add(this.lb_humidity);
            this.pl_weather.Controls.Add(this.lb_forecastMin);
            this.pl_weather.Controls.Add(this.lb_forecastMax);
            this.pl_weather.Controls.Add(this.lb_forecastMaxValue);
            this.pl_weather.HorizontalScrollbarBarColor = true;
            this.pl_weather.HorizontalScrollbarHighlightOnWheel = false;
            this.pl_weather.HorizontalScrollbarSize = 10;
            this.pl_weather.Location = new System.Drawing.Point(358, 63);
            this.pl_weather.Name = "pl_weather";
            this.pl_weather.Size = new System.Drawing.Size(200, 83);
            this.pl_weather.TabIndex = 21;
            this.pl_weather.VerticalScrollbarBarColor = true;
            this.pl_weather.VerticalScrollbarHighlightOnWheel = false;
            this.pl_weather.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::DomusClient.Properties.Resources.Domus;
            this.BackImagePadding = new System.Windows.Forms.Padding(120, 10, 0, 0);
            this.BackMaxSize = 55;
            this.ClientSize = new System.Drawing.Size(570, 308);
            this.Controls.Add(this.pl_weather);
            this.Controls.Add(this.llb_about);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_settings);
            this.Controls.Add(this.bt_users);
            this.Controls.Add(this.bt_plugs);
            this.Controls.Add(this.bt_cistern);
            this.Controls.Add(this.bt_irrigation);
            this.Controls.Add(this.bt_energy);
            this.Controls.Add(this.bt_wather);
            this.Controls.Add(this.bt_devices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Domus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_forecast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_warning)).EndInit();
            this.pl_weather.ResumeLayout(false);
            this.pl_weather.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile bt_devices;
        private MetroFramework.Controls.MetroTile bt_wather;
        private MetroFramework.Controls.MetroTile bt_energy;
        private MetroFramework.Controls.MetroTile bt_irrigation;
        private MetroFramework.Controls.MetroTile bt_cistern;
        private MetroFramework.Controls.MetroTile bt_plugs;
        private MetroFramework.Controls.MetroTile bt_users;
        private MetroFramework.Controls.MetroTile bt_settings;
        private MetroFramework.Controls.MetroTile bt_exit;
        private MetroFramework.Controls.MetroLink llb_about;
        private System.Windows.Forms.PictureBox pb_forecast;
        private MetroFramework.Controls.MetroLabel lb_forecastLocation;
        private MetroFramework.Controls.MetroLabel lb_forecastMinValue;
        private MetroFramework.Controls.MetroLabel lb_forecastMin;
        private MetroFramework.Controls.MetroLabel lb_forecastMax;
        private MetroFramework.Controls.MetroLabel lb_forecastMaxValue;
        private MetroFramework.Controls.MetroLabel lb_humidity;
        private MetroFramework.Controls.MetroLabel lb_humidityValue;
        private MetroFramework.Controls.MetroProgressSpinner pb_spinner;
        private System.Windows.Forms.PictureBox pb_warning;
        private MetroFramework.Controls.MetroLabel lb_ImageDescription;
        private MetroFramework.Controls.MetroPanel pl_weather;
    }
}