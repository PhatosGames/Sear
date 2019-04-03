using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sear.it.objectmethod.sa.dao.impl;



namespace Sear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           object dt = DaoShops.ShopsByCity(txt_city.Text);
            dataGridView1.DataSource = dt;
        }

        private void btn_fatturato_Click(object sender, EventArgs e)
        {
            int year = Int32.Parse(txt_fatturato.Text);
            object dt = DaoStatistics.SalesByYear(year);
            dataGridView1.DataSource = dt;
        }


    }
}
