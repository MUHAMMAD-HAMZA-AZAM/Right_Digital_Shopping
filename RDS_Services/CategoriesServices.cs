using RDS_Database;
using RDS_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RDS_Services
{
    public class CategoriesServices
    {
        public Category GetCategory(int Id)
        {
            using (var context = new RDS_Context())
            {
                return context.Categories.Find(Id);
            }
        }

        public List<Category> GetCategories()
        {
            using (var context = new RDS_Context())
            {
                return context.Categories.ToList();
            }
        }
        public void SaveCategory(Category category)
        {
            using (var context = new RDS_Context())
            {
                context.Categories.Add(category);
                context.SaveChanges();
               
                }
            }
        public void UpdateCategory(Category category)
        {
            using (var context = new RDS_Context())
            {
                context.Entry(category).State = EntityState.Modified;
                context.SaveChanges();

            }
        }
        public void DeleteCategory(Category category)
        {
            using (var context = new RDS_Context())
            {
                context.Entry(category).State = EntityState.Deleted;
                context.SaveChanges();

            }
        }
        
    }
}
