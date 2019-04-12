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

        public static void AddItem(string name, int quantity, int price,string ordercode)
        {
            SqlConnection conn = Connector.Connection();
            conn.Open();
            SqlCommand SDA = new SqlCommand("exec add_items @name,@quantity,@price,@ordercode", conn);
            
            SDA.Parameters.AddWithValue("@name", name);
            SDA.Parameters.AddWithValue("@quantity", quantity);
            SDA.Parameters.AddWithValue("@price", price);
            SDA.Parameters.AddWithValue("@ordercode", ordercode);
            SDA.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteItemsByCode (string ordercode)
        {
            SqlConnection conn = Connector.Connection();
            conn.Open();
            SqlCommand SDA = new SqlCommand("exec delete_items_by_code @ordercode", conn);
            
            SDA.Parameters.AddWithValue("@ordercode", ordercode);
            SDA.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable OrderedItems(string ordercode)
        {
            SqlConnection conn = Connector.Connection();
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("select  pp.product_name as Product ,item_id as Quantity ," +
                                            " soi.list_price as Price from sales.order_items as soi join" +
                                            " production.products as pp on soi.product_id=pp.product_id join " +
                                            "sales.orders as so on soi.order_id=so.order_id where order_code=@code", conn);
            SDA.SelectCommand.Parameters.AddWithValue("@code", ordercode);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            return dt;
        }


    }
}
