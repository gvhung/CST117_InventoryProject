﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class StockSearch: Form
    {
        public StockSearch()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }

        private void StockSearch_Load(object sender, EventArgs e)
        {
            MessageBox.Show("When application is live, the user will be able to select an item and it will pop a screen requesting/saving updates");
        }

        private void btnPreviousMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            StockControl StockControl = new StockControl();
            StockControl.Show();
        }

        private void btnByBrand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort stock by brand");
        }

        private void btnByItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort stock by item");
        }

        private void btnByType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort stock by type");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockControl form1 = new StockControl();
            form1.Show();
        }
    }
}
