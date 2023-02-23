using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace mobile
{
    class connection_class
    {
        public static SqlConnection NewCon;
        public static string con = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        public static SqlConnection GetSqlConnection()
        {
            NewCon = new SqlConnection(con);
            return NewCon;
        }

        /*class Con_Class
        {
            public static string connection = @"Data Source=RASHI;initial catalog=MobileDB;integrated security=true";

        }
        */

    }
}

