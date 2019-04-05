using Sear.it.objectmethod.sa.dao.impl;
using Sear.it.objectmethod.sa.helpers;
using Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.combofillers;
using Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.Classes;
using Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.userInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.UserInterface;

namespace Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.userInterface
{
    public partial class DisplayAddItems : Form
    {
        public DisplayAddItems()
        {
            InitializeComponent();
        }

        private void DisplayAddItems_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView_Items.ClearSelection();
            if (InsertErrorManager.ItemChecker(txt_Item.Text))
            {
                dataGridView_Items.DataSource = DaoItems.Items(txt_Item.Text);
            }
            else
            {
                MessageBox.Show("Search filed is empty!");
            }

        }
        int i;
        private void dataGridView_Items_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView_Items.Rows[i];
            txt_Item.Text = row.Cells[0].Value.ToString();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            string Item = txt_Item.Text;
            string Quantity = txt_Quantity.Text;
            DisplayAddOrder.displayAddOrderBindingSource6.Add(new DisplayAddOrder() { Product = txt_Item.Text, ProductionYear = "2016", Quantity = txt_Quantity.Text, TotalPrice = "000" });
        }
    }
}
