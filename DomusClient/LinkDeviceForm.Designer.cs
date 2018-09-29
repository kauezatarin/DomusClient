namespace DomusClient
{
    partial class LinkDeviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkDeviceForm));
            this.lb_service = new MetroFramework.Controls.MetroLabel();
            this.lb_serviceName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.bt_save = new MetroFramework.Controls.MetroButton();
            this.bt_cancel = new MetroFramework.Controls.MetroButton();
            this.pb_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.listb_devices = new System.Windows.Forms.ListBox();
            this.listb_ports = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_service
            // 
            this.lb_service.AutoSize = true;
            this.lb_service.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_service.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lb_service.Location = new System.Drawing.Point(23, 77);
            this.lb_service.Name = "lb_service";
            this.lb_service.Size = new System.Drawing.Size(85, 25);
            this.lb_service.TabIndex = 0;
            this.lb_service.Text = "Serviço: ";
            // 
            // lb_serviceName
            // 
            this.lb_serviceName.AutoSize = true;
            this.lb_serviceName.Location = new System.Drawing.Point(114, 83);
            this.lb_serviceName.Name = "lb_serviceName";
            this.lb_serviceName.Size = new System.Drawing.Size(117, 19);
            this.lb_serviceName.TabIndex = 2;
            this.lb_serviceName.Text = "Irrigation.Humidity";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 139);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Dispositivo";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(261, 139);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Porta";
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_save.Location = new System.Drawing.Point(380, 297);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.Style = MetroFramework.MetroColorStyle.White;
            this.bt_save.TabIndex = 17;
            this.bt_save.Text = "Salvar";
            this.bt_save.UseCustomBackColor = true;
            this.bt_save.UseSelectable = true;
            this.bt_save.UseStyleColors = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(283, 297);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 16;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseSelectable = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // pb_spinner
            // 
            this.pb_spinner.Location = new System.Drawing.Point(217, 166);
            this.pb_spinner.Maximum = 4;
            this.pb_spinner.Name = "pb_spinner";
            this.pb_spinner.Size = new System.Drawing.Size(32, 32);
            this.pb_spinner.TabIndex = 22;
            this.pb_spinner.UseSelectable = true;
            this.pb_spinner.Visible = false;
            // 
            // listb_devices
            // 
            this.listb_devices.FormattingEnabled = true;
            this.listb_devices.Location = new System.Drawing.Point(23, 161);
            this.listb_devices.Name = "listb_devices";
            this.listb_devices.Size = new System.Drawing.Size(179, 95);
            this.listb_devices.TabIndex = 23;
            this.listb_devices.SelectedIndexChanged += new System.EventHandler(this.listb_devices_SelectedIndexChanged);
            // 
            // listb_ports
            // 
            this.listb_ports.FormattingEnabled = true;
            this.listb_ports.Location = new System.Drawing.Point(261, 161);
            this.listb_ports.Name = "listb_ports";
            this.listb_ports.Size = new System.Drawing.Size(152, 95);
            this.listb_ports.TabIndex = 24;
            // 
            // LinkDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 343);
            this.Controls.Add(this.listb_ports);
            this.Controls.Add(this.listb_devices);
            this.Controls.Add(this.pb_spinner);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lb_serviceName);
            this.Controls.Add(this.lb_service);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LinkDeviceForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vincular Dispositivo";
            this.Load += new System.EventHandler(this.LinkDeviceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lb_service;
        private MetroFramework.Controls.MetroLabel lb_serviceName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton bt_save;
        private MetroFramework.Controls.MetroButton bt_cancel;
        private MetroFramework.Controls.MetroProgressSpinner pb_spinner;
        private System.Windows.Forms.ListBox listb_devices;
        private System.Windows.Forms.ListBox listb_ports;
    }
}