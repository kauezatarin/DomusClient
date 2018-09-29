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
            this.mlv_devices = new MetroFramework.Controls.MetroListView();
            this.lb_serviceName = new MetroFramework.Controls.MetroLabel();
            this.mlv_ports = new MetroFramework.Controls.MetroListView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.bt_save = new MetroFramework.Controls.MetroButton();
            this.bt_cancel = new MetroFramework.Controls.MetroButton();
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
            // mlv_devices
            // 
            this.mlv_devices.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlv_devices.FullRowSelect = true;
            this.mlv_devices.Location = new System.Drawing.Point(23, 161);
            this.mlv_devices.Name = "mlv_devices";
            this.mlv_devices.OwnerDraw = true;
            this.mlv_devices.Size = new System.Drawing.Size(179, 97);
            this.mlv_devices.TabIndex = 1;
            this.mlv_devices.UseCompatibleStateImageBehavior = false;
            this.mlv_devices.UseSelectable = true;
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
            // mlv_ports
            // 
            this.mlv_ports.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlv_ports.FullRowSelect = true;
            this.mlv_ports.Location = new System.Drawing.Point(261, 161);
            this.mlv_ports.Name = "mlv_ports";
            this.mlv_ports.OwnerDraw = true;
            this.mlv_ports.Size = new System.Drawing.Size(152, 97);
            this.mlv_ports.TabIndex = 3;
            this.mlv_ports.UseCompatibleStateImageBehavior = false;
            this.mlv_ports.UseSelectable = true;
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
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(283, 297);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 16;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseSelectable = true;
            // 
            // LinkDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 343);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mlv_ports);
            this.Controls.Add(this.lb_serviceName);
            this.Controls.Add(this.mlv_devices);
            this.Controls.Add(this.lb_service);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LinkDeviceForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vincular Dispositivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lb_service;
        private MetroFramework.Controls.MetroListView mlv_devices;
        private MetroFramework.Controls.MetroLabel lb_serviceName;
        private MetroFramework.Controls.MetroListView mlv_ports;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton bt_save;
        private MetroFramework.Controls.MetroButton bt_cancel;
    }
}