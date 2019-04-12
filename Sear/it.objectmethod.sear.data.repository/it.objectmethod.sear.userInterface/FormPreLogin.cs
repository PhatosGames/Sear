
//using Sear.LocalServices;
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

    public partial class FormPreLogin : Form
    {
       // private MyServiceClient service;

        public FormPreLogin()
        {
            InitializeComponent();
        }

        private void PreLoginForm_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle,2000,WinAPI.BLEND);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   service = new MyServiceClient();
         //   service.echo("txt_Login.Text");
            FormMenu newForm = new FormMenu();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
