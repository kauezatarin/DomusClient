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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::DomusClient.Properties.Resources.Domus;
            this.BackImagePadding = new System.Windows.Forms.Padding(120, 10, 0, 0);
            this.BackMaxSize = 55;
            this.ClientSize = new System.Drawing.Size(570, 308);
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
    }
}