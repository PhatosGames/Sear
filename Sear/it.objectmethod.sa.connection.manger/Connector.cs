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

namespace Sear.it.objectmethod.sa.connection.manager
{
    class Connector
    {
        public static SqlConnection Connection ()
        {
            SqlConnection conn = new SqlConnection("Data Source=LILIANA-PC;Initial Catalog=BikeStores;Integrated Security=True");
            return conn;
        }
    }
}
