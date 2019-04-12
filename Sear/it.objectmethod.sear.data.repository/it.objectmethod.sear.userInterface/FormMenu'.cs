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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn_OrderOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin log = new FormLogin();
            log.ShowDialog();
        }

        private void btn_StatisticsOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStatistics dis = new FormStatistics();
            dis.ShowDialog();
        }


    }
}
