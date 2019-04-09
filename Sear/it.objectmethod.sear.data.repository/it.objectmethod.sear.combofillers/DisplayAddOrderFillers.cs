using Sear.it.objectmethod.sa.connection.manager;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.combofillers
{
    class DisplayAddOrderFillers
    {
        public static List<string> FillComboStores()
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
