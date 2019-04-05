using Sear.it.objectmethod.sa.connection.manager;
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
                 comboBox1.Text, dateTimePicker.Text);
            if (Message != "ok")
            {
                MessageBox.Show(Message);
            }
            else
            {
             if(DaoAddOrder.AddNewOrder(txt_Customer.Text, comboBox_StoreNames.Text,
                comboBox1.Text, dateTimePicker.Text))
             {
                   var list=DaoAddOrder.OrderIdExtractor();
                    foreach (string code in list)
                    {
                        MessageBox.Show("Order successfully added! Order Code :"+code);
                    }
           }
             else
             {
                MessageBox.Show("Error During Interaction");
             }
             }
        }

        private void AddItems_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            DisplayAddItems newForm = new DisplayAddItems();
            newForm.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }
        public string Product { get; set; }
        public string ProductionYear { get; set; }
        public string Quantity { get; set; }
        public string TotalPrice { get; set; }
    }
}
