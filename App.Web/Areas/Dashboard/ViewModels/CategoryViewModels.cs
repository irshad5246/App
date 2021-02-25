using App.Entities;
using App.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Web.Areas.Dashboard.ViewModels
{
   
        public class CategoryListingModel
        {
            public List<Category> Categories { get; set; }
            public int? CategoryID { get; set; }
            public string SearchTerm { get; set; }
            public Pager Pager { get; set; }
        }
        public class CategoryActionModel
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
    }
