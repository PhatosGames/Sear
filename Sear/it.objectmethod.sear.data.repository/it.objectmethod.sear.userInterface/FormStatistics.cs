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
using Sear.it.objectmethod.sa.helpers;
using System.IO;
using Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.UserInterface;
using Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.Classes;
using Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.userInterface;

namespace Sear
{

    public partial class FormStatistics : Form
    {

        public FormStatistics()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (InsertErrorManager.CityChecker(txt_city.Text))
            {
                dataGridView.DataSource = DaoShops.ShopsByCity(txt_city.Text);
            }
            else
            {
                var txt = InsertErrorManager.CityAlert();
                MessageBox.Show(txt.Item1, txt.Item2);
            }
        }

        private void btn_fatturato_Click(object sender, EventArgs e)
        {
            if (InsertErrorManager.YearChecker(txt_sales.Text))
            {
                dataGridView.DataSource = DaoStatistics.SalesByYear(txt_sales.Text);
            }
            else
            {
                var txt = InsertErrorManager.YearAlert();
                MessageBox.Show(txt.Item1, txt.Item2);
            }
        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            DisplayAddOrder newForm = new DisplayAddOrder();
            newForm.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void btn_OpenOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin log = new FormLogin();
            log.ShowDialog();
            this.Close();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            string fileName = InsertErrorManager.FileNameChecker(txt_exp.Text);
            TextWriter writer = new StreamWriter(@"C:\folder\" + fileName + ".csv");
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    writer.Write(dataGridView.Rows[i].Cells[j].Value.ToString() + "\t");
                }
                writer.WriteLine("");

            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }


    }
}
