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
    {
        public APPContext() 
            : base("AppConnection")
        {

        }
        public static APPContext Create()
        {
            return new APPContext();
        }

        public DbSet<Category> Categories { get; set; }
      
    }
}
