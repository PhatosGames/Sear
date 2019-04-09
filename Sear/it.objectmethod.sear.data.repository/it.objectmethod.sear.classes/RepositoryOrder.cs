using System.Data.SqlClient;
using Sear.it.objectmethod.sa.connection.manager;

namespace Sear.it.objectmethod.sear.data.repository.it.objectmethod.Sear.Classes
{
    class DaoAddOrder
    {
        public static string AddNewOrder(string customer, string store, string staff, string date, int price)
        {
            SqlConnection conn = Connector.Connection();
            conn.Open();
            SqlCommand SDA = new SqlCommand("exec add_new_order   @customer  ,  @date , @store , @staff ,@price", conn);

            SDA.Parameters.AddWithValue("@customer", customer);
            SDA.Parameters.AddWithValue("@date", date);
            SDA.Parameters.AddWithValue("@store", store);
            SDA.Parameters.AddWithValue("@staff", staff);
            SDA.Parameters.AddWithValue("@price", price);
            string code = (string)SDA.ExecuteScalar();
            conn.Close();
            return code;

        }

    }
}
