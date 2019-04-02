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


namespace Sear
{
    class connessioni
    {
        public static object FiltraCittà(string città)
        {
            SqlConnection conn = new SqlConnection("Data Source=LILIANA-PC;Initial Catalog=BikeStores;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("Select * from sales.stores where city='" + città + "'", conn);
            SDA.Fill(dt);
            return dt;
   
        }
    }
}
