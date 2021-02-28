using App.Entities;
using App.Services;
using App.Shared.Helpers;
using App.Web.Areas.Dashboard.ViewModels;
using App.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace App.Web.Areas.Dashboard.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Dashboard/Categories
        public ActionResult Index(string searchTerm, int? categoryID, int? pageNo)
        {
            CategoryListingModel model = new CategoryListingModel();
            int recordSize = 9;
            pageNo = pageNo ?? 1;
            model.SearchTerm = searchTerm;

            model.Categories = CategoryService.Instance.SearchCategories(searchTerm, pageNo.Value, recordSize);
           var totalRecord = CategoryService.Instance.SearchCategoriesCount(searchTerm);
            model.Pager = new Pager(totalRecord, pageNo, recordSize);

            return View(model);

        }
        [HttpGet]
        public ActionResult Action(int? ID)
        {
            CategoryActionModel model = new CategoryActionModel();
            if (ID.HasValue)//we are trying to edit record
            {
                var category = CategoryService.Instance.GetCategoriesById(ID.Value);
                model.ID = category.ID;
                model.Name = category.Name;
                model.Description = category.Description;
            }
            //else no need
            //{

            //}

            return PartialView("_Action", model);
        }
        [HttpPost]
        public JsonResult Action(CategoryActionModel model)
        {
            var result = false;
            JsonResult json = new JsonResult();

            if (model.ID > 0) // We try to edit record
            {
                var category = CategoryService.Instance.GetCategoriesById(model.ID);
                category.Name = model.Name;
                category.Description = model.Description;
                result = CategoryService.Instance.UpdateCategories(category);

            }
            else // We try to create record
            {
                Category category = new Category();
                category.Name = model.Name;
                category.Description = model.Description;

                result = CategoryService.Instance.SaveCategories(category);
            }


            if (result)
            {
                json.Data = new { Success = true };
            }
            else
            {
                json.Data = new { Success = false, Message = "Unable to Perform action on Accomodation type" };
            }
            return json;
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            CategoryActionModel model = new CategoryActionModel();
            var category = CategoryService.Instance.GetCategoriesById(ID);
            model.ID = category.ID;
            return PartialView("_Delete", model);
        }

        [HttpPost]
        public JsonResult Delete(CategoryActionModel model)
        {
            var result = false;
            JsonResult json = new JsonResult();

            var accomodatioType = CategoryService.Instance.GetCategoriesById(model.ID);

            result = CategoryService.Instance.DeleteCategories(accomodatioType);


            if (result)
            {
                json.Data = new { Success = true };
            }
            else
            {
                json.Data = new { Success = false, Message = "Unable to Perform action on Accomodation type" };
            }
            return json;
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var languageShortCode = GetLanguageShortCodeFromeURL();

            if (!string.IsNullOrEmpty(languageShortCode))
            {
                AppDataHelper.Currentlanguage = LanguagesService.Instance.GetLanguageByShortCode(languageShortCode);
            }
            if (AppDataHelper.Currentlanguage == null)
            {
                AppDataHelper.Currentlanguage = LanguagesService.Instance.GetDefaultLanguage();
            }
          
        }

        public string GetLanguageShortCodeFromeURL()
        {
            RouteValueDictionary routevalues = HttpContext.Request.RequestContext.RouteData.Values;
            string value = string.Empty;
            foreach (var routevalue in routevalues)
            {
                if (routevalue.Key.ToLower() =="lang")
                {
                    value = routevalue.Value.ToString();
                    break;
                }

            }
            return value;
        }


    }

    
}