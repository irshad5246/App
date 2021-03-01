using App.Entities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Shared.Helpers
{
  public static  class LocalizationHelper
    {
        //public static string value;

        public static ConcurrentDictionary<string,string> ResourceDictionary { get; set; }
      
        public static void LoadResources(List<LanguageResource> languageResources)
        {
            if (languageResources != null && languageResources.Count > 0)
            {
                ResourceDictionary = new ConcurrentDictionary<string, string>(languageResources.ToDictionary(x => x.Key, x => x.Value));
            }
            else ResourceDictionary = new ConcurrentDictionary<string, string>();
        }
       
        public static string Localizedstring(this string key)
        {
            string value = "";
            var currentLanguageID = AppDataHelper.Currentlanguage.ID;

            var resourceKey = string.Format("{0}_{1}", currentLanguageID, key);

            ResourceDictionary.TryGetValue(resourceKey, out value);

            if(string.IsNullOrEmpty(value))
            {
                value = key;
            }

            return value;
        }
    }
}
