using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;

namespace App.Shared.Helpers
{
   public static class URLHelper
    {
        public static string GetLanguageShortCode()
        {
            return GetValueofRoute("lang");
            //RouteValueDictionary routevalues = HttpContext.Current.Request.RequestContext.RouteData.Values;
            //string value = string.Empty;
            //foreach (var routevalue in routevalues)
            //{
            //    if (routevalue.Key.ToLower() == "lang")
            //    {
            //        value = routevalue.Value.ToString();
            //        break;
            //    }

            //}
            //return value;
        }

        public static string GetValueofRoute(string key)
        {
            RouteValueDictionary routevalues = HttpContext.Current.Request.RequestContext.RouteData.Values;
            string value = string.Empty;
            foreach (var routevalue in routevalues)
            {
                if (routevalue.Key.ToLower() == key)
                {
                    value = routevalue.Value.ToString();
                    break;
                }

            }
            return value;
        }
    }
}
