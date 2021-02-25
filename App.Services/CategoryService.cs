using App.Entities;
using App.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{

    public class CategoryService
    {
        #region Singleton
        public static CategoryService Instance
        {
            get
            {
                if (instance == null) instance = new CategoryService();

                return instance;
            }
        }
        private static CategoryService instance { get; set; }

        private CategoryService()
        {
        }

        #endregion
        public List<Category> GetAllCategories()
        {
            var context = new APPContext();
            return context.Categories.ToList();
        }
        public List<Category> SearchCategories(string searchTerm, int pageNo, int recordSize)
        {
            var context = new APPContext();

            var categories = context.Categories.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                categories = categories.Where(a => a.Name.ToLower().Contains(searchTerm.ToLower()));
            }

            var skipCount = (pageNo - 1) * recordSize;
            return categories.OrderBy(x => x.Name).Skip(skipCount).Take(recordSize).ToList();

            //return accomodationTypes.ToList();
        }
        public int SearchCategoriesCount(string searchTerm)
        {
            var context = new APPContext();

            var category = context.Categories.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                category = category.Where(a => a.Name.ToLower().Contains(searchTerm.ToLower()));
            }


            return category.Count();
        }
        public Category GetCategoriesById(int ID)
        {
            var context = new APPContext();
            return context.Categories.Find(ID);
        }
        public bool SaveCategories(Category category)
        {
            var context = new APPContext();
            context.Categories.Add(category);
            return context.SaveChanges() > 0;
        }
        public bool UpdateCategories(Category category)
        {
            var context = new APPContext();
            context.Entry(category).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges() > 0;
        }
        public bool DeleteCategories(Category category)
        {
            var context = new APPContext();
            context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
            return context.SaveChanges() > 0;
        }
    }
}

