using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.Common
{
    public class GlobalConfig
    {
        
            
            public static void InitializeConnections()
            {
                SqlConnection sql = new SqlConnection();
            }
            public static string CnnString(string name)
            {
                return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }
        }
}


