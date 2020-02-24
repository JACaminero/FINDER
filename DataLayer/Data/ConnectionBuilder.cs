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
        /// <summary>
        /// Gets la coneccion por default (la que se llama literalmente "default") de la aplicacion
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetDefaultConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            return new SqlConnection(connectionString);
        }

        /// <summary>
        /// Gets una connecion a una base de datos dado el nombre de la conneccion en el app config
        /// </summary>
        /// <param name="configConnectionName"> El 'name' de la connecion en el archivo config de la app </param>
        
        /// <returns></returns>
        public static SqlConnection GetConnection(string configConnectionName)
        {
            var connectionString = ConfigurationManager.ConnectionStrings[configConnectionName].ConnectionString;
            return new SqlConnection(connectionString);
        }

    }
}
