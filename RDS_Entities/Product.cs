using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDS_Entities
{
   public  class Product:ParentEntities
    {
        public Category Category { get; set; }
        public decimal Price { get; set; }
    }
}
