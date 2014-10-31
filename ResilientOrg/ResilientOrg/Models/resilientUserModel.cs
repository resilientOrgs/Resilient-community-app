using ResilientOrg.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace ResilientOrg.Views.Home
{

    public class resilientUserModel : DbContext
    {
        // Your context has been configured to use a 'resilientUserModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ResilientOrg.Views.Home.resilientUserModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'resilientUserModel' 
        // connection string in the application configuration file.

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Message> Messages { get; set; }


        public resilientUserModel()
            : base("name=resilientUserModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}