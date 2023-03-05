using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAplication.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public double ProductPrice { get; set; }
        public string ProductGroup { get; set; }
    }
}