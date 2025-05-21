using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace iktatoMySQL
{
    public class DBConnectionsClass
    {
        public static string GetConnectionString_1()
        {
            SqlConnectionStringBuilder constBuilder = new SqlConnectionStringBuilder();
            constBuilder.DataSource = ConfigurationManager.AppSettings["server"];
            constBuilder.InitialCatalog = ConfigurationManager.AppSettings["database"];
            constBuilder.UserID = ConfigurationManager.AppSettings["user"];
            constBuilder.Password = ConfigurationManager.AppSettings["password"];

            constBuilder.IntegratedSecurity = true;
            constBuilder.ConnectTimeout = 30;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = constBuilder.ConnectionString;
            return cn.ConnectionString;

        }

        public static string GetConnectionString_2(string connectionName)
        {
            try
            {
                string connectiontSring = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
                return connectiontSring;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"hiba történt: {ex.Message}");
                return null;
            }
        }
    }
}
