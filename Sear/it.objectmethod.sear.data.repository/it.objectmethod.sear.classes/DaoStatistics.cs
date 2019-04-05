﻿using System;
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
      
        public static object SalesByYear(string txt)
        {
            int year = Int32.Parse(txt);
            SqlConnection conn = Connector.Connection();
            SqlDataAdapter SDA = new SqlDataAdapter("exec SalesByYear @search", conn);
            SDA.SelectCommand.Parameters.AddWithValue("@search", year);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            return dt;
        }

    }
}