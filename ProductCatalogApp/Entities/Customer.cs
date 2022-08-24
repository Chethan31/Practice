using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogApp.Entities
{
    public class Customer : Person
    {
        public string CustomerType { get; set; }
        public double Discount { get; set; }
    }
}
