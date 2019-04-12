using Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.Classes;
using Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.UserInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.userInterface
{
    public partial class YourOrders : Form
    {
        public static string SetCode = "";
        public YourOrders()
        {
         
            InitializeComponent();
            dataGridView_mod.DataSource = DaoOrder.OrderFiller();

        }



        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        int i;
        private void dataGridView_mod_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView_mod.Rows[i];
            txt_Code.Text = row.Cells[5].Value.ToString();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin login = new FormLogin();
            login.ShowDialog();
            
        }

        private void btn_ModOrder_Click(object sender, EventArgs e)
        {
            SetCode = txt_Code.Text;
            this.WindowState = FormWindowState.Minimized;
            DisplayAddOrder newForm = new DisplayAddOrder();
            newForm.ShowDialog();
            txt_Code.Text = null;
            dataGridView_mod.DataSource = null;
            dataGridView_mod.Rows.Clear();
            dataGridView_mod.DataSource = DaoOrder.OrderFiller();
            this.WindowState = FormWindowState.Normal;

        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            txt_Code.Text = null;
            SetCode = txt_Code.Text;
            this.WindowState = FormWindowState.Minimized;
            DisplayAddOrder newForm = new DisplayAddOrder();
            newForm.ShowDialog();
            txt_Code.Text = null;
            dataGridView_mod.DataSource = null;
            dataGridView_mod.Rows.Clear();
            dataGridView_mod.DataSource = DaoOrder.OrderFiller();
            this.WindowState = FormWindowState.Normal;

        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStatistics stat = new FormStatistics();
            stat.ShowDialog();
            this.Close();
        }
    }
}
