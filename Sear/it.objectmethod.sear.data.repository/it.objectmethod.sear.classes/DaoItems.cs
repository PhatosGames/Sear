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
    class DaoItems
    {
        public static object Items(string itemTxt)
        {
            string searchitem = "%" + itemTxt + "%";
            SqlConnection conn = Connector.Connection();
            SqlDataAdapter SDA = new SqlDataAdapter("Select product_name as Products ,model_year as ProductionYear," +
                "list_price as Price from production.products where product_name like @search ", conn);
            SDA.SelectCommand.Parameters.AddWithValue("@search", searchitem);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            return dt;
        }
    }
}
