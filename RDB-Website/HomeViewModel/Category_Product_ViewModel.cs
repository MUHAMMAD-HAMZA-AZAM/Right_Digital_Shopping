using RDS_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDB_Website.HomeViewModel
{
    public class Category_Product_ViewModel
    {
        public List<Category> Categories{ get; set; }
        public List<Product> Products { get; set; }

    }
}