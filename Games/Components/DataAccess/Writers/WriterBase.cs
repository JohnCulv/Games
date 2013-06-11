using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Games.Components.DataAccess.Writers
{
    public abstract class WriterBase : ConnectionBase
    {
        protected static string ReturnIdentity
        {
            get
            {
                return "SELECT CAST(SCOPE_IDENTITY() as int)";
            }
        }
        
        protected static void SetIdentity<T>(IDbConnection connection, Action<T> setId)
        {
            var blabla = connection.Query("SELECT @@IDENTITY AS Id").FirstOrDefault();
            
            dynamic identity = connection.Query("SELECT @@IDENTITY AS Id").Single();
            T newId = (T) identity.Id;
            setId(newId);
        }
    }
}