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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Username.Text) || string.IsNullOrEmpty(txt_Password.Text))
            {
                MessageBox.Show("All fields must be filled!");
            }
            else {
                if (txt_Password.Text == "giovanni")
                {
                    this.Hide();
                    Display newForm = new Display();
                    newForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Password!");
                }
            }
           
        }
    }
}
