using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Games.Components.DataAccess
{
    public abstract class ConnectionBase
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString;
            }
        }

        public static IDbConnection GetConnection()
        {
             return new SqlConnection(ConnectionString);
        }
    }
}