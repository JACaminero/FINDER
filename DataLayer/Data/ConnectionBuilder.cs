using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DataLayer
{
    public static class ConnectionBuilder
    {
        public static SqlConnection GetDefaultConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["FINDERDB"].ConnectionString;
            return new SqlConnection(connectionString);
        }
        public static SqlConnection GetConnection(string configConnectionName)
        {
            var connectionString = ConfigurationManager.ConnectionStrings[configConnectionName].ConnectionString;
            return new SqlConnection(connectionString);
        }

    }
}
