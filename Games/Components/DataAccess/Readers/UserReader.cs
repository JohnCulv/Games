using Dapper;
using Games.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Games.Components.DataAccess;

namespace Games.Components.Readers
{
    public class UserReader : ConnectionBase
    {
        public static User GetUserByName(string name)
        {
            using (IDbConnection connection = GetConnection())
            {
                const string query = "SELECT Id, Name " +
                      "FROM GamesDB.dbo.[User] " +
                      "WHERE Name = @Name";
                return connection.Query<User>(query, new { Name = name }).FirstOrDefault();
            }

        }
    }
}