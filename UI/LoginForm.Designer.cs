﻿namespace UI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxUSerIcon = new System.Windows.Forms.PictureBox();
            this.txtBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.picBoxShowPass = new System.Windows.Forms.PictureBox();
            this.picBoxHidePass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHidePass)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(83, 149);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(289, 163);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxUSerIcon
            // 
            this.pictureBoxUSerIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxUSerIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUSerIcon.Image")));
            this.pictureBoxUSerIcon.Location = new System.Drawing.Point(418, 85);
            this.pictureBoxUSerIcon.Name = "pictureBoxUSerIcon";
            this.pictureBoxUSerIcon.Size = new System.Drawing.Size(245, 260);
            this.pictureBoxUSerIcon.TabIndex = 1;
            this.pictureBoxUSerIcon.TabStop = false;
            // 
            // txtBoxEmployeeId
            // 
            this.txtBoxEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxEmployeeId.BackColor = System.Drawing.Color.DimGray;
            this.txtBoxEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEmployeeId.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxEmployeeId.ForeColor = System.Drawing.Color.White;
            this.txtBoxEmployeeId.Location = new System.Drawing.Point(87, 437);
            this.txtBoxEmployeeId.Multiline = true;
            this.txtBoxEmployeeId.Name = "txtBoxEmployeeId";
            this.txtBoxEmployeeId.Size = new System.Drawing.Size(571, 69);
            this.txtBoxEmployeeId.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPassword.BackColor = System.Drawing.Color.DimGray;
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPassword.ForeColor = System.Drawing.Color.White;
            this.txtBoxPassword.Location = new System.Drawing.Point(87, 563);
            this.txtBoxPassword.Multiline = true;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(571, 69);
            this.txtBoxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(87, 749);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(571, 69);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeId.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeId.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeId.Location = new System.Drawing.Point(87, 401);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(248, 33);
            this.lblEmployeeId.TabIndex = 7;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(87, 527);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 33);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // picBoxShowPass
            // 
            this.picBoxShowPass.Image = global::UI.Properties.Resources.EyesOpened6040;
            this.picBoxShowPass.Location = new System.Drawing.Point(582, 579);
            this.picBoxShowPass.Name = "picBoxShowPass";
            this.picBoxShowPass.Size = new System.Drawing.Size(60, 40);
            this.picBoxShowPass.TabIndex = 9;
            this.picBoxShowPass.TabStop = false;
            this.picBoxShowPass.Click += new System.EventHandler(this.picBoxShowPass_Click);
            // 
            // picBoxHidePass
            // 
            this.picBoxHidePass.Image = global::UI.Properties.Resources.eyesClosed;
            this.picBoxHidePass.Location = new System.Drawing.Point(594, 573);
            this.picBoxHidePass.Name = "picBoxHidePass";
            this.picBoxHidePass.Size = new System.Drawing.Size(50, 50);
            this.picBoxHidePass.TabIndex = 10;
            this.picBoxHidePass.TabStop = false;
            this.picBoxHidePass.Click += new System.EventHandler(this.picBoxHidePass_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(726, 1055);
            this.Controls.Add(this.picBoxHidePass);
            this.Controls.Add(this.picBoxShowPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxEmployeeId);
            this.Controls.Add(this.pictureBoxUSerIcon);
            this.Controls.Add(this.pictureBoxLogo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Login Form";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHidePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxUSerIcon;
        private System.Windows.Forms.TextBox txtBoxEmployeeId;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox picBoxShowPass;
        private System.Windows.Forms.PictureBox picBoxHidePass;
    }
}
