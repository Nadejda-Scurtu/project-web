using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAplication.Models;

namespace WebAplication.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();

            // Add products to the list
            products.Add(new Product
            {
                ProductId = 1,
                ProductName = "Product 1",
                ProductImage = "/Content/images/product-01.jpg",
                ProductPrice = 75,
                ProductGroup = "men"
            });
            products.Add(new Product
            {
                ProductId = 2,
                ProductName = "Product 2",
                ProductImage = "/Content/images/product-02.jpg",
                ProductPrice = 100,
                ProductGroup = "men"
            });
            products.Add(new Product
            {
                ProductId = 3,
                ProductName = "Product 3",
                ProductImage = "/Content/images/product-03.jpg",
                ProductPrice = 115,
                ProductGroup = "women"
            });
            products.Add(new Product
            {
                ProductId = 4,
                ProductName = "Product 4",
                ProductImage = "/Content/images/product-04.jpg",
                ProductPrice = 30.00,
                ProductGroup = "women"
            });
            products.Add(new Product
            {
                ProductId = 5,
                ProductName = "Product 5",
                ProductImage = "/Content/images/product-05.jpg",
                ProductPrice = 40.20,
                ProductGroup = "women"
            });

            return View(products);
        }
    }
}