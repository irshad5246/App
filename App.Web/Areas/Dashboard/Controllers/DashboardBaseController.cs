using App.Services;
using App.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Web.Areas.Dashboard.Controllers
{
    public class DashboardBaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var languageShortCode = URLHelper.GetLanguageShortCode();

            if (!string.IsNullOrEmpty(languageShortCode))
            {
                AppDataHelper.Currentlanguage = LanguagesService.Instance.GetLanguageByShortCode(languageShortCode);
            }
            if (AppDataHelper.Currentlanguage == null)
            {
                AppDataHelper.Currentlanguage = LanguagesService.Instance.GetDefaultLanguage();
            }

        }

      
    }
}