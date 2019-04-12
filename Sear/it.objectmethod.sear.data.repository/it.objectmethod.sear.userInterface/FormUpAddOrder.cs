using Sear.it.objectmethod.sa.connection.manager;
using Sear.it.objectmethod.sa.dao.impl;
using Sear.it.objectmethod.sa.helpers;
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
            var list = DaoOrder.FillComboStore();
            foreach (string store in list)
            {
                comboBox_StoreNames.Items.Add(store);
            }

        }

        void FillStaff()
        {
            var list = DaoOrder.FillComboStaff();
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
            string orderCode = YourOrders.SetCode;
            this.TopMost = true;
            if (String.IsNullOrEmpty(orderCode) == false)
            {
                txt_OrderCode.Text = orderCode;
                btn_AddOrder.Hide();
                dataGridView2.Hide();
                dataGridView2.DataSource = DaoItems.OrderedItems(orderCode);
                int count = dataGridView2.Rows.Count-1;
                for (int i = 0; i < count; i++)
                {
                    string name = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    string strquantity = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    string strtotalprice = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    int quantity = Convert.ToInt32(strquantity);
                    double dprice = Convert.ToDouble(strtotalprice);
                    int price = Convert.ToInt32(dprice);


                    datGridView_Items.Rows.Add(name, quantity, price, "Delete");
                    int Total = datGridView_Items.Rows.Cast<DataGridViewRow>()
                        .Sum(t => Convert.ToInt32(t.Cells[2].Value));
                    txt_Total.Text = Total.ToString();
                }
                dataGridView2.DataSource = DaoOrder.OrderData(orderCode);
                string id = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string storeName = dataGridView2.Rows[0].Cells[1].Value.ToString();
                string staffName = dataGridView2.Rows[0].Cells[2].Value.ToString();
                string date = dataGridView2.Rows[0].Cells[3].Value.ToString();
                txt_Customer.Text = id;
                comboBox_StoreNames.Text = storeName;
                comboBox1.Text = staffName;
                dateTimePicker.Text = date;
            }
            else
            {
                btn_Modify.Hide();
                dataGridView2.Hide();
                txt_OrderCode.Hide();
                lbl_OrderCode.Hide();
            }
        }
        

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            bool check = InsertErrorManager.OrderChecker(txt_Customer.Text, comboBox_StoreNames.Text,
                 comboBox1.Text, dateTimePicker.Text, txt_Total.Text);
            if(check == true)
            {
                MessageBox.Show("All field must be filled");
            }
            else
            {
                int total = Convert.ToInt32(txt_Total.Text);
                string orderCode = DaoOrder.AddNewOrder(txt_Customer.Text, comboBox_StoreNames.Text,
                 comboBox1.Text, dateTimePicker.Text, total);
                int count = datGridView_Items.Rows.Count-1;
                for (int i=0; i< count; i++)
                {
                    string name = datGridView_Items.Rows[i].Cells[0].Value.ToString();
                    string strquantity = datGridView_Items.Rows[i].Cells[1].Value.ToString();
                    string strprice = datGridView_Items.Rows[i].Cells[2].Value.ToString();
                    int quantity = Convert.ToInt32(strquantity);
                    int price = Convert.ToInt32(strprice);

                    DaoItems.AddItem(name,quantity,price,orderCode);

                }
                MessageBox.Show("Order Added, Order Code:" + orderCode);
            }

        }

        private void AddItems_Click(object sender, EventArgs e)
        {

            using (FormItems newForm = new FormItems() { })
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
                        datGridView_Items.Rows.Add(newForm.getItem().getName(), newForm.getItem().getQuantity(), newForm.getItem().getTotalprice(),
                       "Delete");

                        int Total = datGridView_Items.Rows.Cast<DataGridViewRow>()
                        .Sum(t => Convert.ToInt32(t.Cells[2].Value));
                        txt_Total.Text = Total.ToString();
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 3 && datGridView_Items[0, e.RowIndex].Value != null)
            {
                datGridView_Items.Rows.RemoveAt(e.RowIndex);
                int Total = datGridView_Items.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt32(t.Cells[2].Value));
                txt_Total.Text = Total.ToString();
            }
        }

        private void btn_ChangeOrder_Click(object sender, EventArgs e)
        {
            bool val = InsertErrorManager.OrderChecker(txt_Customer.Text, comboBox_StoreNames.Text,
                comboBox1.Text, dateTimePicker.Text, txt_Total.Text);
            if (val==false)
            {
                MessageBox.Show("All field must be filled");
            }
            else
            {
                int total = Convert.ToInt32(txt_Total.Text);
                string orderCode = YourOrders.SetCode;
                if (DaoOrder.UpdateOrder(txt_Customer.Text, comboBox_StoreNames.Text,
                    comboBox1.Text, dateTimePicker.Text, txt_OrderCode.Text))
                {
                    DaoItems.DeleteItemsByCode(orderCode);
                    int count = datGridView_Items.Rows.Count - 1;
                    for (int i = 0; i < count; i++)
                    {
                        string name = datGridView_Items.Rows[i].Cells[0].Value.ToString();
                        string strquantity = datGridView_Items.Rows[i].Cells[1].Value.ToString();
                        string strprice = datGridView_Items.Rows[i].Cells[2].Value.ToString();

                        int quantity = Convert.ToInt32(strquantity);
                        int price = Convert.ToInt32(strprice);

                        DaoItems.AddItem(name, quantity, price, orderCode);

                    }
                    MessageBox.Show("Order Saved, Order Code:" + orderCode);
                }
                else
                {
                    MessageBox.Show("Error during the update, try check customer id again");
                }
            }


        }


    }
}
