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
using Sear.it.objectmethod.sa.connection.manager;

namespace Sear.it.objectmethod.sa.dao.impl
{
    class DaoStatistics
    {
      
        public static object SalesByYear(int year)
        {
            SqlConnection conn = Connector.Connection();
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("exec SalesByYear "+year, conn);
            SDA.Fill(dt);
            return dt;
        }

    }
}
