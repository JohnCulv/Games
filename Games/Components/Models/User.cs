using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Games.Components.Models
{
    public class User
    {
        public User() //Used for Dapper dynamic conversion
        { }
        
        public User(string name)
        {
            Name = name;
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
    }
}