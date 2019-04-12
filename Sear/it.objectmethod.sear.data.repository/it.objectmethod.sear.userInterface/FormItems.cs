using Sear.it.objectmethod.sa.dao.impl;
using Sear.it.objectmethod.sa.helpers;
using System;
using System.Windows.Forms;
using Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.models;

namespace Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.userInterface
{
    public partial class FormItems : Form
    {
        public Items item;

        public Items getItem()
        {
            return this.item;
        }

        public void setItem(Items _item)
        {
            this.item = _item;
        }

        public FormItems()
        {
            InitializeComponent();
            item = new Items();
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
                MessageBox.Show("Search field is empty!");
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (InsertErrorManager.AddItemsChecker(txt_Item.Text, (int)numericUpDown.Value))
            {
                item.setItem((string)txt_Item.Text);
                item.setQuantity((int)numericUpDown.Value);
                item.setTotalprice((string)txt_Item.Text, (int)numericUpDown.Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("All field must be filled up!");
            }
        }

            int i;
        private void dataGridView_Items_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView_Items.Rows[i];
            txt_Item.Text = row.Cells[0].Value.ToString();
        }
       
    }
}
