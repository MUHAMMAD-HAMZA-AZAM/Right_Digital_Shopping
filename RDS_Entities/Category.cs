using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDS_Entities
{
   public class Category: ParentEntities
    {
        
        public List<Product> Products { get; set; }
    }
}
