namespace DomusClient
{
    partial class ManageUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersForm));
            this.dtg_users = new MetroFramework.Controls.MetroGrid();
            this.bt_newUser = new MetroFramework.Controls.MetroButton();
            this.pb_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.bt_edit = new MetroFramework.Controls.MetroButton();
            this.bt_delet = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_users)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_users
            // 
            this.dtg_users.AllowUserToAddRows = false;
            this.dtg_users.AllowUserToDeleteRows = false;
            this.dtg_users.AllowUserToResizeRows = false;
            this.dtg_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtg_users.BackgroundColor = System.Drawing.Color.White;
            this.dtg_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_users.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_users.EnableHeadersVisualStyles = false;
            this.dtg_users.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtg_users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_users.Location = new System.Drawing.Point(23, 104);
            this.dtg_users.Name = "dtg_users";
            this.dtg_users.ReadOnly = true;
            this.dtg_users.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_users.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtg_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_users.Size = new System.Drawing.Size(852, 384);
            this.dtg_users.TabIndex = 0;
            // 
            // bt_newUser
            // 
            this.bt_newUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_newUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_newUser.Location = new System.Drawing.Point(790, 63);
            this.bt_newUser.Name = "bt_newUser";
            this.bt_newUser.Size = new System.Drawing.Size(85, 35);
            this.bt_newUser.Style = MetroFramework.MetroColorStyle.White;
            this.bt_newUser.TabIndex = 1;
            this.bt_newUser.Text = "Novo Usuário";
            this.bt_newUser.UseCustomBackColor = true;
            this.bt_newUser.UseSelectable = true;
            this.bt_newUser.UseStyleColors = true;
            this.bt_newUser.Click += new System.EventHandler(this.bt_newUser_Click);
            // 
            // pb_spinner
            // 
            this.pb_spinner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_spinner.Enabled = false;
            this.pb_spinner.Location = new System.Drawing.Point(436, 264);
            this.pb_spinner.Maximum = 4;
            this.pb_spinner.Name = "pb_spinner";
            this.pb_spinner.Size = new System.Drawing.Size(32, 32);
            this.pb_spinner.TabIndex = 2;
            this.pb_spinner.TabStop = false;
            this.pb_spinner.UseSelectable = true;
            this.pb_spinner.Value = 1;
            this.pb_spinner.Visible = false;
            // 
            // bt_edit
            // 
            this.bt_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.bt_edit.Location = new System.Drawing.Point(695, 63);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(85, 35);
            this.bt_edit.TabIndex = 3;
            this.bt_edit.Text = "Editar";
            this.bt_edit.UseSelectable = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delet
            // 
            this.bt_delet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_delet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(132)))), ((int)(((byte)(12)))));
            this.bt_delet.Location = new System.Drawing.Point(600, 63);
            this.bt_delet.Name = "bt_delet";
            this.bt_delet.Size = new System.Drawing.Size(85, 35);
            this.bt_delet.Style = MetroFramework.MetroColorStyle.White;
            this.bt_delet.TabIndex = 4;
            this.bt_delet.Text = "Deletar";
            this.bt_delet.UseCustomBackColor = true;
            this.bt_delet.UseSelectable = true;
            this.bt_delet.UseStyleColors = true;
            this.bt_delet.Click += new System.EventHandler(this.bt_delet_Click);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(898, 511);
            this.Controls.Add(this.bt_delet);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.pb_spinner);
            this.Controls.Add(this.bt_newUser);
            this.Controls.Add(this.dtg_users);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManageUsersForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dtg_users;
        private MetroFramework.Controls.MetroButton bt_newUser;
        private MetroFramework.Controls.MetroProgressSpinner pb_spinner;
        private MetroFramework.Controls.MetroButton bt_edit;
        private MetroFramework.Controls.MetroButton bt_delet;
    }
}