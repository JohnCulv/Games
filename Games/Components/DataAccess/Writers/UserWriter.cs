using Dapper;
using Games.Components.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Games.Components.DataAccess.Writers
{
    public class UserWriter : WriterBase
    {
        public static void CreateUser(User user)
        {
            using (IDbConnection connection = GetConnection())
            {
                string query = "INSERT INTO GamesDB.dbo.[User] (Name) " +
                      "VALUES(@Name);" + ReturnIdentity;
                int Id = connection.Query<int>(query, new { Name = user.Name }).Single();
                user.Id = Id;
            }
        }
    }
}