using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Database
{
  public  class APPDBInitializer :CreateDatabaseIfNotExists<APPContext> 
    {
        protected override void Seed(APPContext context)
        {
            CreateLanguages(context);
        }

        private void CreateLanguages(APPContext context)
        {
            context.Languages.Add(new Entities.Language()
            {
                Name="English",
                ShortCode= "en",
                IsDefault=true,
                CreatedOn=DateTime.Now
            });
            context.Languages.Add(new Entities.Language()
            {
                Name = "Arabic",
                ShortCode = "ar",
                IsRTL=true,
                CreatedOn = DateTime.Now
            });
            context.Languages.Add(new Entities.Language()
            {
                Name = "Hindi",
                ShortCode = "hi",
                CreatedOn = DateTime.Now
            });
            context.Languages.Add(new Entities.Language()
            {
                Name = "Urdu",
                ShortCode = "ur",
                IsRTL = true,
                CreatedOn = DateTime.Now
            });
        }
    }
}
