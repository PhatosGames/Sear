﻿using Sear.it.objectmethod.sa.connection.manager;
using Sear.it.objectmethod.sa.helpers;
using Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.combofillers;
using Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.userInterface;
using Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.UserInterface
{
    public partial class DisplayAddOrder : Form
    {
        public DisplayAddOrder()
        {

            InitializeComponent();
            FillStaff();
            FillStores();
        }



        void FillStores()
        {
            var list = DisplayAddOrderFillers.FillComboStores();
            foreach (string store in list)
            {
                comboBox_StoreNames.Items.Add(store);
            }

        }

        void FillStaff()
        {
            var list = DisplayAddOrderFillers.FillComboStaff();
            foreach (string store in list)
            {
                comboBox1.Items.Add(store);
            }

        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayAddOrder_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            string Message = InsertErrorManager.OrderChecker(txt_Customer.Text, comboBox_StoreNames.Text,
                 comboBox1.Text, dateTimePicker.Text, txt_Total.Text);
            if (Message != "ok")
            {
                MessageBox.Show(Message);
            }
            else
            {
                int total = Convert.ToInt32(txt_Total.Text);
                string orderCode = DaoAddOrder.AddNewOrder(txt_Customer.Text, comboBox_StoreNames.Text,
                 comboBox1.Text, dateTimePicker.Text, total);
                MessageBox.Show("Order Added, Order Code:" + orderCode);
            }

        }

        private void AddItems_Click(object sender, EventArgs e)
        {

            using (DisplayAddItems newForm = new DisplayAddItems() { })
            {
                newForm.ShowDialog();
                bool check = InsertErrorManager.AddItemsChecker(newForm.getItem().getName(), newForm.getItem().getQuantity());
                if (check == true)
                {
                    int errorPrice = newForm.getItem().getTotalprice();
                    if (errorPrice == 0)
                    {
                        MessageBox.Show("Item name entered invalid");
                    }
                    else
                    {
                        dataGridView1.Rows.Add(newForm.getItem().getName(), newForm.getItem().getQuantity(), newForm.getItem().getTotalprice(),
                       "Delete");

                        int Total = dataGridView1.Rows.Cast<DataGridViewRow>()
                        .Sum(t => Convert.ToInt32(t.Cells[2].Value));
                        txt_Total.Text = Total.ToString();
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 3 && dataGridView1[0, e.RowIndex].Value != null)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                int Total = dataGridView1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt32(t.Cells[2].Value));
                txt_Total.Text = Total.ToString();
            }
        }
    }
}
