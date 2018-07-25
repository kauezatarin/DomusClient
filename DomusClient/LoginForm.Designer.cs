namespace DomusClient
{
    partial class LoginForm
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
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_passwd = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_passwd = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(65, 13);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(165, 20);
            this.tb_user.TabIndex = 0;
            // 
            // tb_passwd
            // 
            this.tb_passwd.Location = new System.Drawing.Point(65, 53);
            this.tb_passwd.Name = "tb_passwd";
            this.tb_passwd.Size = new System.Drawing.Size(165, 20);
            this.tb_passwd.TabIndex = 1;
            this.tb_passwd.UseSystemPasswordChar = true;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(13, 16);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(46, 13);
            this.lb_user.TabIndex = 2;
            this.lb_user.Text = "Usuário:";
            // 
            // lb_passwd
            // 
            this.lb_passwd.AutoSize = true;
            this.lb_passwd.Location = new System.Drawing.Point(18, 56);
            this.lb_passwd.Name = "lb_passwd";
            this.lb_passwd.Size = new System.Drawing.Size(41, 13);
            this.lb_passwd.TabIndex = 3;
            this.lb_passwd.Text = "Senha:";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(12, 96);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(93, 38);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(166, 96);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(93, 38);
            this.bt_login.TabIndex = 5;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 139);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.lb_passwd);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.tb_passwd);
            this.Controls.Add(this.tb_user);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_passwd;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_passwd;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_login;
    }
}