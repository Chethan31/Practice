using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogApp.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public Catagory Catagory { get; set; }
        public List<Supplier> Suppliers { get; set; }=new List<Supplier>();
    }
}
