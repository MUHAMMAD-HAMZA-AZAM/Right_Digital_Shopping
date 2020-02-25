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
    public class ProductServices
    {
        public Product GetProduct(int Id)
        {
            using (var context = new RDS_Context())
            {
                return context.Products.Find(Id);
            }
        }

        public List<Product> GetProducts()
        {
            using (var context = new RDS_Context())
            {
                return context.Products.ToList();
            }
        }
        public void SaveProduct(Product product)
        {
            using (var context = new RDS_Context())
            {
                context.Products.Add(product);
                context.SaveChanges();
               
                }
            }
        public void UpdateProduct(Product product)
        {
            using (var context = new RDS_Context())
            {
                context.Entry(product).State = EntityState.Modified;
                context.SaveChanges();

            }
        }
        public void DeleteProduct(Product product)
        {
            using (var context = new RDS_Context())
            {
                context.Entry(product).State = EntityState.Deleted;
                context.SaveChanges();

            }
        }
        
    }
}
