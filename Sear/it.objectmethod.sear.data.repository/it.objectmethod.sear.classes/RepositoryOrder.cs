using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Sear.it.objectmethod.sa.connection.manager;

namespace Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.Classes
{
    class DaoOrder
    {
        public static string AddNewOrder(string customer, string store, string staff, string date, int price)
        {
            SqlConnection conn = Connector.Connection();
            conn.Open();
            SqlCommand SDA = new SqlCommand("exec add_new_order   @customer  ,  @date , @store , @staff", conn);

            SDA.Parameters.AddWithValue("@customer", customer);
            SDA.Parameters.AddWithValue("@date", date);
            SDA.Parameters.AddWithValue("@store", store);
            SDA.Parameters.AddWithValue("@staff", staff);
            
            string code = (string)SDA.ExecuteScalar();
            conn.Close();
            return code;

        }

        public static DataTable OrderFiller()
        {
            
            SqlConnection conn = Connector.Connection();
            SqlDataAdapter SDA = new SqlDataAdapter("exec modify_order", conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            return dt;
        }
        

        public static DataTable OrderData(string code)
        {

            SqlConnection conn = Connector.Connection();
            SqlDataAdapter SDA = new SqlDataAdapter("select so.customer_id, store_name, ss.first_name," +
                                                    " so.order_date from sales.orders so  join sales.stores sos" +
                                                    " on sos.store_id = so.store_id join sales.staffs ss on ss.staff_id =" +
                                                    " so.staff_id where order_code = @ordercode"
                                                     , conn);
            SDA.SelectCommand.Parameters.AddWithValue("@ordercode", code);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            return dt;

        }

        public static bool UpdateOrder(string customer, string store, string staff, string date,string ordercode)
        {
            try
            {
                int customer_id=Convert.ToInt32(customer);
            SqlConnection conn = Connector.Connection();
            conn.Open();
            SqlCommand SDA = new SqlCommand("exec update_order   @customer  ,  @date , @store , @staff , @ordercode", conn);

            SDA.Parameters.AddWithValue("@customer", customer_id);
            SDA.Parameters.AddWithValue("@date", date);
            SDA.Parameters.AddWithValue("@store", store);
            SDA.Parameters.AddWithValue("@staff", staff);
            SDA.Parameters.AddWithValue("@ordercode", ordercode);

            string code = (string)SDA.ExecuteScalar();
            conn.Close();
                return true;
            }catch (Exception )
            {
                return false;
            }
            

        }

        public static List<string> FillComboStore()
        {
            var retList = new List<string>();
            SqlConnection conn = Connector.Connection();
            SqlDataReader reader;
            conn.Open();
            SqlCommand SDA = new SqlCommand("Select distinct store_name from sales.Stores", conn);
            reader = SDA.ExecuteReader();
            while (reader.Read())
            {
                string sName = reader.GetString(0);
                retList.Add(sName);


            }
            conn.Close();
            return retList;
        }

        public static List<string> FillComboStaff()
        {
            var retList = new List<string>();
            SqlConnection conn = Connector.Connection();
            SqlDataReader reader;
            conn.Open();
            SqlCommand SDA = new SqlCommand(" Select first_name as Staff from sales.staffs", conn);
            reader = SDA.ExecuteReader();
            while (reader.Read())
            {
                string sName = reader.GetString(0);
                retList.Add(sName);


            }
            conn.Close();
            return retList;
        }

        public static List<string> FillComboItems(string patter)
        {
            var retList = new List<string>();
            SqlConnection conn = Connector.Connection();
            SqlDataReader reader;
            conn.Open();
            SqlCommand SDA = new SqlCommand(" Select product_name as Products from production.products where product_name like '%" + patter + "%'", conn);
            reader = SDA.ExecuteReader();
            while (reader.Read())
            {
                string sName = reader.GetString(0);
                retList.Add(sName);


            }
            conn.Close();
            return retList;
        }
    }
}
