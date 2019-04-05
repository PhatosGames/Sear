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

namespace Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.Classes
{
    class DaoAddOrder
    {
        public static bool AddNewOrder(string customer,string store,string staff,string date)
        {
            try
            {
              
                SqlConnection conn = Connector.Connection();
                conn.Open();
                SqlCommand SDA = new SqlCommand("exec add_new_order   @customer  ,  @date , @store , @staff ", conn);
              
                SDA.Parameters.AddWithValue("@customer", customer);
                SDA.Parameters.AddWithValue("@date", date);
                SDA.Parameters.AddWithValue("@store", store);
                SDA.Parameters.AddWithValue("@staff", staff);
                SDA.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static List<string>OrderIdExtractor()
        {
            var retList = new List<string>();
            SqlConnection conn = Connector.Connection();
            SqlDataReader reader;
            conn.Open();
            SqlCommand SDA = new SqlCommand("select top(1) order_code from sales.orders order by order_id desc", conn);
            reader = SDA.ExecuteReader();
            while (reader.Read())
            {
                string LastcustomerId = reader.GetString(0);
                retList.Add(LastcustomerId);

            }
            conn.Close();
            return retList;
        }
    }
}
