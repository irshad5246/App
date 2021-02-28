using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
namespace App.Database
{
    public class APPContext : IdentityDbContext<AppUser>
    //public class APPContext : DbContext
    {
        public APPContext() : base("AppConnection")
        {
            System.Data.Entity.Database.SetInitializer<APPContext>(new APPDBInitializer());
            //Database.SetInitializer(new APPDBInitializer());
        }
        public static APPContext Create()
        {
            return new APPContext();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Language> Languages { get; set; }

    }
}
