﻿namespace DomusClient
{
    partial class CisternConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CisternConfigForm));
            this.np_rainTime = new System.Windows.Forms.NumericUpDown();
            this.lb_rainTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.trb_minLevel = new MetroFramework.Controls.MetroTrackBar();
            this.lb_levelValue = new MetroFramework.Controls.MetroLabel();
            this.listb_action = new System.Windows.Forms.ListBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.bt_save = new MetroFramework.Controls.MetroButton();
            this.bt_cancel = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.np_rainTime)).BeginInit();
            this.SuspendLayout();
            // 
            // np_rainTime
            // 
            this.np_rainTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np_rainTime.Location = new System.Drawing.Point(281, 63);
            this.np_rainTime.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.np_rainTime.Name = "np_rainTime";
            this.np_rainTime.Size = new System.Drawing.Size(57, 26);
            this.np_rainTime.TabIndex = 0;
            this.np_rainTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lb_rainTime
            // 
            this.lb_rainTime.AutoSize = true;
            this.lb_rainTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_rainTime.Location = new System.Drawing.Point(23, 60);
            this.lb_rainTime.Name = "lb_rainTime";
            this.lb_rainTime.Size = new System.Drawing.Size(252, 25);
            this.lb_rainTime.TabIndex = 1;
            this.lb_rainTime.Text = "Tempo para captação de chuva:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(270, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nivel minimo de armazenamento:";
            // 
            // trb_minLevel
            // 
            this.trb_minLevel.BackColor = System.Drawing.Color.Transparent;
            this.trb_minLevel.Location = new System.Drawing.Point(23, 140);
            this.trb_minLevel.Name = "trb_minLevel";
            this.trb_minLevel.Size = new System.Drawing.Size(281, 23);
            this.trb_minLevel.TabIndex = 3;
            this.trb_minLevel.Text = "Nivel minimo";
            this.trb_minLevel.Value = 10;
            this.trb_minLevel.ValueChanged += new System.EventHandler(this.trb_minLevel_ValueChanged);
            // 
            // lb_levelValue
            // 
            this.lb_levelValue.AutoSize = true;
            this.lb_levelValue.Location = new System.Drawing.Point(310, 141);
            this.lb_levelValue.Name = "lb_levelValue";
            this.lb_levelValue.Size = new System.Drawing.Size(39, 19);
            this.lb_levelValue.TabIndex = 4;
            this.lb_levelValue.Text = "100%";
            // 
            // listb_action
            // 
            this.listb_action.FormattingEnabled = true;
            this.listb_action.Items.AddRange(new object[] {
            "Parar Irrigação",
            "Seguir até esvaziar",
            "Agua da rua"});
            this.listb_action.Location = new System.Drawing.Point(23, 213);
            this.listb_action.Name = "listb_action";
            this.listb_action.Size = new System.Drawing.Size(184, 69);
            this.listb_action.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 185);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(184, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Nivel minimo atingido:";
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.bt_save.Location = new System.Drawing.Point(342, 336);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.Style = MetroFramework.MetroColorStyle.White;
            this.bt_save.TabIndex = 8;
            this.bt_save.Text = "Salvar";
            this.bt_save.UseCustomBackColor = true;
            this.bt_save.UseSelectable = true;
            this.bt_save.UseStyleColors = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(246, 336);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 9;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseSelectable = true;
            // 
            // CisternConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 382);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.listb_action);
            this.Controls.Add(this.lb_levelValue);
            this.Controls.Add(this.trb_minLevel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lb_rainTime);
            this.Controls.Add(this.np_rainTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CisternConfigForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cisterna";
            this.Load += new System.EventHandler(this.CisternConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.np_rainTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown np_rainTime;
        private MetroFramework.Controls.MetroLabel lb_rainTime;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTrackBar trb_minLevel;
        private MetroFramework.Controls.MetroLabel lb_levelValue;
        private System.Windows.Forms.ListBox listb_action;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton bt_save;
        private MetroFramework.Controls.MetroButton bt_cancel;
    }
}