using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;
using System.Data.Entity.Spatial;

	


namespace ResilientOrg.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public SqlGeography _lat { get; set;}
        public SqlGeography _long { get; set; }
        public DbGeography _lat { get; set; }
        public DbGeography _long { get; set; }
        public DateTime DateCreated { get; set; }
        //not sure what geography point I'm going to be using at this point and time. have put both in will take one set out.

        public ICollection<Post> posts { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
