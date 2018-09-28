using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProductModel
{
    public class Product
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public float Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

    }
}
