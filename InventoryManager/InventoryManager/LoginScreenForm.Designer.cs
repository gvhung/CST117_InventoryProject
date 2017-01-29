﻿namespace InventoryManager
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.UsernameTextField = new System.Windows.Forms.TextBox();
            this.PasswordTextField = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.LoginLogo = new System.Windows.Forms.PictureBox();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.LoginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTextField
            // 
            this.UsernameTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsernameTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextField.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UsernameTextField.Location = new System.Drawing.Point(135, 49);
            this.UsernameTextField.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameTextField.Name = "UsernameTextField";
            this.UsernameTextField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.UsernameTextField.Size = new System.Drawing.Size(193, 26);
            this.UsernameTextField.TabIndex = 0;
            this.UsernameTextField.Text = "Guest";
            // 
            // PasswordTextField
            // 
            this.PasswordTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextField.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PasswordTextField.Location = new System.Drawing.Point(135, 81);
            this.PasswordTextField.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextField.Name = "PasswordTextField";
            this.PasswordTextField.Size = new System.Drawing.Size(193, 26);
            this.PasswordTextField.TabIndex = 1;
            this.PasswordTextField.Text = "password";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LoginButton.Location = new System.Drawing.Point(160, 124);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(141, 31);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LOGIN_BUTTON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "USERNAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD:";
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginGroupBox.Controls.Add(this.PasswordTextField);
            this.LoginGroupBox.Controls.Add(this.label2);
            this.LoginGroupBox.Controls.Add(this.UsernameTextField);
            this.LoginGroupBox.Controls.Add(this.label1);
            this.LoginGroupBox.Controls.Add(this.LoginButton);
            this.LoginGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginGroupBox.Location = new System.Drawing.Point(677, 256);
            this.LoginGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.LoginGroupBox.Size = new System.Drawing.Size(350, 199);
            this.LoginGroupBox.TabIndex = 5;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "SIGN IN";
            // 
            // LoginLogo
            // 
            this.LoginLogo.Image = global::InventoryManager.Properties.Resources.TTG_LOGO_LOGIN_SCREEN_WIDTH_477PX;
            this.LoginLogo.Location = new System.Drawing.Point(174, 256);
            this.LoginLogo.Margin = new System.Windows.Forms.Padding(2);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(488, 295);
            this.LoginLogo.TabIndex = 6;
            this.LoginLogo.TabStop = false;
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExitApplication.Location = new System.Drawing.Point(886, 460);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(141, 31);
            this.btnExitApplication.TabIndex = 7;
            this.btnExitApplication.Text = "Exit Application";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.exitEvent);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.LoginLogo);
            this.Controls.Add(this.LoginGroupBox);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTextField;
        private System.Windows.Forms.TextBox PasswordTextField;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.PictureBox LoginLogo;
        private System.Windows.Forms.Button btnExitApplication;
    }
}

