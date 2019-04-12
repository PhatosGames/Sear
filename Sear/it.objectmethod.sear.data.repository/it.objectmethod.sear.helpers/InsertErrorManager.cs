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
using Sear.it.objectmethod.sa.dao.impl;
using Sear.it.objectmethod.sa.helpers;

namespace Sear.it.objectmethod.sa.helpers
{
    class InsertErrorManager
    {
        //Year

        public static Tuple<string, string> YearAlert()
        {
            string message = "Need to insert a year!";
            string title = "Error...";
            return Tuple.Create(message, title);
        }

        public static bool YearChecker(string txt)
        {
            int length = txt.Length;
            if (length == 4)
            {
                try
                {
                    int year = Int32.Parse(txt);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        //City Name

        public static Tuple<string, string> CityAlert()
        {
            string message = "Need to insert a city!";
            string title = "Error...";
            return Tuple.Create(message, title);
        }
        public static bool CityChecker(string txt)
        {
            int length = txt.Length;
            if (length > 3 && length < 40)
            {
                try
                {
                    int year = Int32.Parse(txt);
                    return false;
                }
                catch (Exception)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }

        }

        //File Name 

        public static string FileNameChecker(string txt)
        {
            string fileName = txt;
            if (fileName.Length == 0)
            {
                fileName = "defaultFile";
            }
            return fileName;
        }

        //Add Order 

        public static bool OrderChecker(string txtcustomerID, string txtstoreID, string txtstaffID, string txtitemID, string totalprize)
        {
            if (string.IsNullOrEmpty(txtcustomerID) || string.IsNullOrEmpty(txtstoreID) ||
                string.IsNullOrEmpty(txtstaffID) || string.IsNullOrEmpty(txtitemID) || string.IsNullOrEmpty(totalprize))
            {
               
                return false;
            }
            else
            {
                
                return true;
            }
        }

        //Add Item

        public static bool ItemChecker(string txt)
        {
            if (string.IsNullOrEmpty(txt))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool AddItemsChecker(string txt, int quantity)
        {
            if (string.IsNullOrEmpty(txt) || quantity == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
