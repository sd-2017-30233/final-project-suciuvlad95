using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class StoreContext : DbContext
    {
       
        public DbSet<Asigurare> Asigurare { get; set; }
       

        public System.Data.Entity.DbSet<WebApplication1.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Asigurator> Asigurator { get; set; }
        public System.Data.Entity.DbSet<WebApplication1.Models.ContractAsig> ContractAsig { get; set; }

        //public System.Data.Entity.DbSet<Log.Models.UserAccount> UserAccounts { get; set; }
    }
}