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
    public partial class PreLoginForm : Form
    {
        public PreLoginForm()
        {
            InitializeComponent();
        }

        private void PreLoginForm_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle,2000,WinAPI.BLEND);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            LoginForm newForm = new LoginForm();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
