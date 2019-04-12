using System;
using Sear.ServiceReference1;
using System.Windows.Forms;
using Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.Classes;

namespace Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.userInterface
{
    public partial class FormLogin : Form
    {
        public MyServiceClient service= new MyServiceClient();
        public FormLogin()
        {
            InitializeComponent();
            FillStores();
        }
        void FillStores()
        {
            var list = DaoOrder.FillComboStaff();
            foreach (string store in list)
            {
                combo_Username.Items.Add(store);
            }

        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(combo_Username.Text) || string.IsNullOrEmpty(txt_Password.Text))
            {
                MessageBox.Show("All fields must be filled!");
            }
            else
            {

                if(txt_Password.Text=="Giovanni")
                {
                    this.Hide();
                    FormPreLogin log = new FormPreLogin();
                    log.Hide();
                    FormMenu men = new FormMenu();
                    men.Hide();
                    YourOrders newForm = new YourOrders();
                    newForm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!");
                }
            }
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
