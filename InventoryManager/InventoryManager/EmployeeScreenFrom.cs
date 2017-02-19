﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
            panel4.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen openForm1 = new LoginScreen();
            openForm1.Show();
        }

        private void btnStockList_Click(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
            panel1.Visible = true;
            SqlConnection connection1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=T2G_MainDB;Integrated Security=True;Connect Timeout=30");
            connection1.Open();
            //SqlCommand readinventory = new SqlCommand("select Title, Details, Price, Brand, Type from Main_Inventory where Main_Inventory = '" + searchquery + "'", connection1);
            //SqlDataReader inventorysearch = readinventory.ExecuteReader();
            SqlDataAdapter searchinventory = new SqlDataAdapter("select Title, Details, Price, Brand, Type from Main_Inventory", connection1);
            DataTable viewinventory = new DataTable();
            searchinventory.Fill(viewinventory);
            BindingSource inventory_BS = new BindingSource();
            inventory_BS.DataSource = viewinventory;
            viewStock.DataSource = inventory_BS;
            viewStock.Show();
            //connection1.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
            panel2.Visible = true;
            SqlConnection connection1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=T2G_MainDB;Integrated Security=True;Connect Timeout=30");
            connection1.Open();
            //SqlCommand readinventory = new SqlCommand("select Title, Details, Price, Brand, Type from Main_Inventory where Main_Inventory = '" + searchquery + "'", connection1);
            //SqlDataReader inventorysearch = readinventory.ExecuteReader();
            SqlDataAdapter searchinventory = new SqlDataAdapter("select Title, Details, Price, Brand, Type from Main_Inventory", connection1);
            DataTable viewinventory = new DataTable();
            searchinventory.Fill(viewinventory);
            BindingSource inventory_BS = new BindingSource();
            inventory_BS.DataSource = viewinventory;
            editInventory.DataSource = inventory_BS;
            editInventory.Show();
            //connection1.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnListInventory_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
            panel3.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public bool IsAllDigits(string s)
        {
            return s.All(char.IsDigit);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void removeInventory_btn_Click_1(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in editInventory.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();

                SqlConnection connection1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\T2G_MainDB.mdf;Integrated Security=True");
                connection1.Open();
                SqlCommand remove = new SqlCommand("DELETE from Main_Inventory WHERE Title = '" + value1 + "'", connection1);
                SqlDataReader reader = remove.ExecuteReader();
            }
        }
    }

}
