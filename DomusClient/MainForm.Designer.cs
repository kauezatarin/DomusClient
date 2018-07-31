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
            this.SuspendLayout();
            // 
            // bt_devices
            // 
            this.bt_devices.ActiveControl = null;
            this.bt_devices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(23)))), ((int)(((byte)(178)))));
            this.bt_devices.Location = new System.Drawing.Point(129, 63);
            this.bt_devices.Name = "bt_devices";
            this.bt_devices.Size = new System.Drawing.Size(100, 68);
            this.bt_devices.TabIndex = 0;
            this.bt_devices.Text = "Dispositivos";
            this.bt_devices.UseCustomBackColor = true;
            this.bt_devices.UseSelectable = true;
            this.bt_devices.Click += new System.EventHandler(this.bt_devices_Click);
            // 
            // bt_wather
            // 
            this.bt_wather.ActiveControl = null;
            this.bt_wather.Location = new System.Drawing.Point(23, 137);
            this.bt_wather.Name = "bt_wather";
            this.bt_wather.Size = new System.Drawing.Size(100, 68);
            this.bt_wather.TabIndex = 1;
            this.bt_wather.Text = "Água";
            this.bt_wather.UseSelectable = true;
            // 
            // bt_energy
            // 
            this.bt_energy.ActiveControl = null;
            this.bt_energy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(7)))));
            this.bt_energy.Location = new System.Drawing.Point(23, 63);
            this.bt_energy.Name = "bt_energy";
            this.bt_energy.Size = new System.Drawing.Size(100, 68);
            this.bt_energy.TabIndex = 2;
            this.bt_energy.Text = "Energia";
            this.bt_energy.UseCustomBackColor = true;
            this.bt_energy.UseSelectable = true;
            // 
            // MainForm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::DomusClient.Properties.Resources.Domus;
            this.BackImagePadding = new System.Windows.Forms.Padding(120, 10, 0, 0);
            this.BackMaxSize = 55;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}