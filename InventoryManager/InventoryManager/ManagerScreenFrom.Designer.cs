﻿namespace InventoryManager
{
    partial class ManagerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerScreen));
            this.CustomerSearchBox = new System.Windows.Forms.TextBox();
            this.CustomerSearchBoxButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnInventoryManagement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerSearchBox
            // 
            this.CustomerSearchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearchBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CustomerSearchBox.Location = new System.Drawing.Point(969, 190);
            this.CustomerSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerSearchBox.Name = "CustomerSearchBox";
            this.CustomerSearchBox.Size = new System.Drawing.Size(311, 37);
            this.CustomerSearchBox.TabIndex = 1;
            this.CustomerSearchBox.Text = "Search T2 Games";
            this.CustomerSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerSearchBox.TextChanged += new System.EventHandler(this.CustomerSearchBox_TextChanged);
            // 
            // CustomerSearchBoxButton
            // 
            this.CustomerSearchBoxButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerSearchBoxButton.BackgroundImage = global::InventoryManager.Properties.Resources.SEARCH_ICON_75X47_002;
            this.CustomerSearchBoxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CustomerSearchBoxButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomerSearchBoxButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerSearchBoxButton.FlatAppearance.BorderSize = 0;
            this.CustomerSearchBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerSearchBoxButton.Location = new System.Drawing.Point(1285, 190);
            this.CustomerSearchBoxButton.Margin = new System.Windows.Forms.Padding(0);
            this.CustomerSearchBoxButton.Name = "CustomerSearchBoxButton";
            this.CustomerSearchBoxButton.Size = new System.Drawing.Size(41, 37);
            this.CustomerSearchBoxButton.TabIndex = 3;
            this.CustomerSearchBoxButton.TabStop = false;
            this.CustomerSearchBoxButton.UseVisualStyleBackColor = false;
            this.CustomerSearchBoxButton.Click += new System.EventHandler(this.CUST_SRCH_BOX_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManager.Properties.Resources.TTG_LOGO_LOGIN_SCREEN_WIDTH_477PX;
            this.pictureBox1.Location = new System.Drawing.Point(472, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 226);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(729, 182);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(229, 39);
            this.Header.TabIndex = 7;
            this.Header.Text = "Management";
            this.Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogout.Location = new System.Drawing.Point(1254, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 36);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnClickLogout);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUserManagement.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUserManagement.Location = new System.Drawing.Point(472, 275);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(229, 88);
            this.btnUserManagement.TabIndex = 9;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.manageUsersEvent);
            // 
            // btnInventoryManagement
            // 
            this.btnInventoryManagement.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnInventoryManagement.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnInventoryManagement.Location = new System.Drawing.Point(736, 275);
            this.btnInventoryManagement.Name = "btnInventoryManagement";
            this.btnInventoryManagement.Size = new System.Drawing.Size(229, 88);
            this.btnInventoryManagement.TabIndex = 10;
            this.btnInventoryManagement.Text = "Inventory Management";
            this.btnInventoryManagement.UseVisualStyleBackColor = false;
            this.btnInventoryManagement.Click += new System.EventHandler(this.btnInventoryManagement_Click);
            // 
            // ManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1285, 741);
            this.Controls.Add(this.btnInventoryManagement);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.CustomerSearchBoxButton);
            this.Controls.Add(this.CustomerSearchBox);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Customer Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerNotice);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CustomerSearchBoxButton;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnInventoryManagement;
        public System.Windows.Forms.TextBox CustomerSearchBox;
    }
}