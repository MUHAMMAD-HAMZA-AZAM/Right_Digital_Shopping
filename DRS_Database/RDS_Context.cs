using RDS_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDS_Database
{
   public  class RDS_Context :DbContext
    {
        public DbSet<Category> Categories{get;set;}
        public DbSet<Product> Products { get; set; }

    }
}
