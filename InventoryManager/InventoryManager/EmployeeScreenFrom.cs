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
    public partial class EmployeeScreen : Form
    {
        public EmployeeScreen()
        {
            InitializeComponent();
        }

        private void CUSTOMER_SEARCH_Load(object sender, EventArgs e)
        {

        }

        private void CUST_SRCH_ALL_Click(object sender, EventArgs e)
        {

        }

        private void CUST_SRCH_BOX_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void logoutClick(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen login = new LoginScreen();
            login.Show();
        }
    }
}
