using App.Entities;
using App.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{

    public class LanguagesService
    {
        #region Singleton
        public static LanguagesService Instance
        {
            get
            {
                if (instance == null) instance = new LanguagesService();

                return instance;
            }
        }
        private static LanguagesService instance { get; set; }

        private LanguagesService()
        {
        }

        #endregion
        public Language GetDefaultLanguage()
        {
            var context = new APPContext();
            return context.Languages.FirstOrDefault(x=>x.IsDefault);
        }
      
        public Language GetLanguageByShortCode(string shortCode)
        {
            var context = new APPContext();
            return context.Languages.FirstOrDefault(x => x.ShortCode==shortCode);
        }
        public List<LanguageResource> GetLanguageResources()
        {
            var context = new APPContext();
            return context.LanguageResources.ToList();
        }

    }
}

