﻿namespace InventoryManager
{
    partial class CustomerSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSearch));
            this.CustomerSearchBox = new System.Windows.Forms.TextBox();
            this.SearchBoxLabel = new System.Windows.Forms.Label();
            this.CustomerSearchBoxButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustomerSearchAllButton = new System.Windows.Forms.Button();
            this.or_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CUST_SRCH_BOX
            // 
            this.CustomerSearchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearchBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CustomerSearchBox.Location = new System.Drawing.Point(714, 329);
            this.CustomerSearchBox.Name = "CUST_SRCH_BOX";
            this.CustomerSearchBox.Size = new System.Drawing.Size(414, 45);
            this.CustomerSearchBox.TabIndex = 1;
            this.CustomerSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SRCH_BOX_LABEL
            // 
            this.SearchBoxLabel.AutoSize = true;
            this.SearchBoxLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchBoxLabel.Font = new System.Drawing.Font("Neuropol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBoxLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchBoxLabel.Location = new System.Drawing.Point(726, 337);
            this.SearchBoxLabel.Name = "SRCH_BOX_LABEL";
            this.SearchBoxLabel.Size = new System.Drawing.Size(390, 30);
            this.SearchBoxLabel.TabIndex = 2;
            this.SearchBoxLabel.Text = "Search Team 2 Games";
            // 
            // CUST_SRCH_BOX_BUTTON
            // 
            this.CustomerSearchBoxButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerSearchBoxButton.BackgroundImage = global::InventoryManager.Properties.Resources.SEARCH_ICON_75X47_002;
            this.CustomerSearchBoxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CustomerSearchBoxButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomerSearchBoxButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerSearchBoxButton.FlatAppearance.BorderSize = 0;
            this.CustomerSearchBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerSearchBoxButton.Location = new System.Drawing.Point(1130, 329);
            this.CustomerSearchBoxButton.Margin = new System.Windows.Forms.Padding(0);
            this.CustomerSearchBoxButton.Name = "CUST_SRCH_BOX_BUTTON";
            this.CustomerSearchBoxButton.Size = new System.Drawing.Size(55, 45);
            this.CustomerSearchBoxButton.TabIndex = 3;
            this.CustomerSearchBoxButton.TabStop = false;
            this.CustomerSearchBoxButton.UseVisualStyleBackColor = false;
            this.CustomerSearchBoxButton.Click += new System.EventHandler(this.CUST_SRCH_BOX_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManager.Properties.Resources.TTG_LOGO_LOGIN_SCREEN_WIDTH_477PX;
            this.pictureBox1.Location = new System.Drawing.Point(708, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 395);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CUST_SRCH_ALL_BUTTON
            // 
            this.CustomerSearchAllButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CustomerSearchAllButton.Font = new System.Drawing.Font("Neuropol", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearchAllButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CustomerSearchAllButton.Location = new System.Drawing.Point(716, 637);
            this.CustomerSearchAllButton.Name = "CUST_SRCH_ALL_BUTTON";
            this.CustomerSearchAllButton.Size = new System.Drawing.Size(471, 132);
            this.CustomerSearchAllButton.TabIndex = 4;
            this.CustomerSearchAllButton.Text = "SEARCH ALL GAMES";
            this.CustomerSearchAllButton.UseVisualStyleBackColor = false;
            this.CustomerSearchAllButton.Click += new System.EventHandler(this.CUST_SRCH_ALL_Click);
            // 
            // or_label
            // 
            this.or_label.AutoSize = true;
            this.or_label.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.or_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.or_label.Location = new System.Drawing.Point(926, 482);
            this.or_label.Name = "or_label";
            this.or_label.Size = new System.Drawing.Size(52, 49);
            this.or_label.TabIndex = 5;
            this.or_label.Text = "or";
            this.or_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // CUSTOMER_SEARCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1902, 1035);
            this.Controls.Add(this.or_label);
            this.Controls.Add(this.CustomerSearchAllButton);
            this.Controls.Add(this.CustomerSearchBoxButton);
            this.Controls.Add(this.SearchBoxLabel);
            this.Controls.Add(this.CustomerSearchBox);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CUSTOMER_SEARCH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Customer Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CUSTOMER_SEARCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CustomerSearchBox;
        private System.Windows.Forms.Label SearchBoxLabel;
        private System.Windows.Forms.Button CustomerSearchBoxButton;
        private System.Windows.Forms.Button CustomerSearchAllButton;
        private System.Windows.Forms.Label or_label;
    }
}