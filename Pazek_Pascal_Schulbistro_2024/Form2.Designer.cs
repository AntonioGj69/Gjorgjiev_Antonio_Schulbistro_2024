namespace Pazek_Pascal_Schulbistro_2024
{
    partial class Form2
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLoginF2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Peru;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(134, 200);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(144, 24);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "admin";
            // 
            // btnLoginF2
            // 
            this.btnLoginF2.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginF2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLoginF2.Location = new System.Drawing.Point(218, 296);
            this.btnLoginF2.Name = "btnLoginF2";
            this.btnLoginF2.Size = new System.Drawing.Size(60, 23);
            this.btnLoginF2.TabIndex = 4;
            this.btnLoginF2.Text = "login";
            this.btnLoginF2.UseVisualStyleBackColor = false;
            this.btnLoginF2.Click += new System.EventHandler(this.btnLoginF2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(134, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.BackgroundImage = global::Pazek_Pascal_Schulbistro_2024.Properties.Resources.loginpanel_background;
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.btnLoginF2);
            this.panelLogin.Controls.Add(this.btnExit);
            this.panelLogin.Controls.Add(this.txtUsername);
            this.panelLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLogin.Location = new System.Drawing.Point(380, 127);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(410, 408);
            this.panelLogin.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Peru;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(134, 254);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(144, 24);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "Manna!2024";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pazek_Pascal_Schulbistro_2024.Properties.Resources.login_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 690);
            this.Controls.Add(this.panelLogin);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLoginF2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox txtPassword;
    }
}