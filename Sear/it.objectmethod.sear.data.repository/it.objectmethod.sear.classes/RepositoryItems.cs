using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Sear.it.objectmethod.sa.connection.manager;

namespace Sear.it.objectmethod.sa.dao.impl
{
    class DaoItems
    {
        public static DataTable Items(string itemTxt)
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

        public static int TotalPrice(int quantity, string item)
        {
            SqlConnection conn = Connector.Connection();
            conn.Open();
            SqlCommand SDA = new SqlCommand("exec total_price_item @quantity,@name", conn);
            SDA.Parameters.AddWithValue("@name", item);
            SDA.Parameters.AddWithValue("@quantity", quantity);

            int total = (int)SDA.ExecuteScalar();
            conn.Close();
            return total;
        }
    }
}
