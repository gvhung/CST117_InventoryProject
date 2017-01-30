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
    public partial class Analytics: Form
    {
        public Analytics()
        {
            InitializeComponent();
        }

        private void Analytics_Load(object sender, EventArgs e)
        {

        }

        private void btnPopular_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnalyticData AnalyticData = new AnalyticData();
            AnalyticData.Show();
        }

        private void btnHighSellers_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnalyticData AnalyticData = new AnalyticData();
            AnalyticData.Show();
        }

        private void btnLowSellers_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnalyticData AnalyticData = new AnalyticData();
            AnalyticData.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }

        private void returnClick(object sender, EventArgs e)
        {
            this.Hide();
            InventoryManager form1 = new InventoryManager();
            form1.Show();
        }
    }
}
