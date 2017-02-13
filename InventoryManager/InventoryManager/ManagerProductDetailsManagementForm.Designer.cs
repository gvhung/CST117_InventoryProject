﻿namespace InventoryManager
{
    partial class ProductDetailsManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetailsManager));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewProductList = new System.Windows.Forms.DataGridView();
            this.btnByBrand = new System.Windows.Forms.Button();
            this.btnByType = new System.Windows.Forms.Button();
            this.btnByItem = new System.Windows.Forms.Button();
            this.btnPreviousMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManager.Properties.Resources.TTG_LOGO_LOGIN_SCREEN_WIDTH_477PX;
            this.pictureBox1.Location = new System.Drawing.Point(531, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 321);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // viewProductList
            // 
            this.viewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProductList.Location = new System.Drawing.Point(346, 197);
            this.viewProductList.Margin = new System.Windows.Forms.Padding(2);
            this.viewProductList.Name = "viewProductList";
            this.viewProductList.RowTemplate.Height = 24;
            this.viewProductList.Size = new System.Drawing.Size(750, 569);
            this.viewProductList.TabIndex = 10;
            this.viewProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewProductList_CellContentClick);
            // 
            // btnByBrand
            // 
            this.btnByBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByBrand.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnByBrand.Location = new System.Drawing.Point(346, 771);
            this.btnByBrand.Name = "btnByBrand";
            this.btnByBrand.Size = new System.Drawing.Size(100, 23);
            this.btnByBrand.TabIndex = 11;
            this.btnByBrand.Text = "By Brand";
            this.btnByBrand.UseVisualStyleBackColor = true;
            this.btnByBrand.Click += new System.EventHandler(this.btnByBrand_Click);
            // 
            // btnByType
            // 
            this.btnByType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnByType.Location = new System.Drawing.Point(447, 771);
            this.btnByType.Name = "btnByType";
            this.btnByType.Size = new System.Drawing.Size(100, 23);
            this.btnByType.TabIndex = 12;
            this.btnByType.Text = "By Type";
            this.btnByType.UseVisualStyleBackColor = true;
            this.btnByType.Click += new System.EventHandler(this.btnByType_Click);
            // 
            // btnByItem
            // 
            this.btnByItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnByItem.Location = new System.Drawing.Point(548, 771);
            this.btnByItem.Name = "btnByItem";
            this.btnByItem.Size = new System.Drawing.Size(100, 23);
            this.btnByItem.TabIndex = 13;
            this.btnByItem.Text = "By Item";
            this.btnByItem.UseVisualStyleBackColor = true;
            this.btnByItem.Click += new System.EventHandler(this.btnByItem_Click);
            // 
            // btnPreviousMenu
            // 
            this.btnPreviousMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPreviousMenu.Location = new System.Drawing.Point(967, 771);
            this.btnPreviousMenu.Name = "btnPreviousMenu";
            this.btnPreviousMenu.Size = new System.Drawing.Size(130, 23);
            this.btnPreviousMenu.TabIndex = 14;
            this.btnPreviousMenu.Text = "Previous Menu";
            this.btnPreviousMenu.UseVisualStyleBackColor = true;
            this.btnPreviousMenu.Click += new System.EventHandler(this.btnPreviousMenu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(1254, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.returnClick);
            // 
            // ProductDetailsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPreviousMenu);
            this.Controls.Add(this.btnByItem);
            this.Controls.Add(this.btnByType);
            this.Controls.Add(this.btnByBrand);
            this.Controls.Add(this.viewProductList);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductDetailsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Product Detail Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductDetailsManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView viewProductList;
        private System.Windows.Forms.Button btnByBrand;
        private System.Windows.Forms.Button btnByType;
        private System.Windows.Forms.Button btnByItem;
        private System.Windows.Forms.Button btnPreviousMenu;
        private System.Windows.Forms.Button button1;
    }
}