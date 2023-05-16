using eUseControl.Controllers;
using System.Collections.Generic;
using System.Web.Mvc;
using WebAplication.Models;

namespace WebAplication.Controllers
{
    public class HomeController : eUseBaseController
    {
        public ActionResult Index()
        {
            var products = new List<Product>();

            // Add products to the list
            products.Add(new Product { 
                ProductId = 1, 
                ProductName = "Product 1",
                ProductImage = "/Content/images/product_1.png",
                ProductPrice = 75 
            });
            products.Add(new Product { 
                ProductId = 2, 
                ProductName = "Product 2",
                ProductImage = "/Content/images/product_2.png",
                ProductPrice = 100 
            });
            products.Add(new Product {
                ProductId = 3,
                ProductName = "Product 3",
                ProductImage = "/Content/images/product_3.png",
                ProductPrice = 115 
            });
            products.Add(new Product
            {
                ProductId = 4,
                ProductName = "Product 4",
                ProductImage = "/Content/images/product_04.jpg",
                ProductPrice = 30.00
            });
            products.Add(new Product
            {
                ProductId = 5,
                ProductName = "Product 5",
                ProductImage = "/Content/images/product_05.jpg",
                ProductPrice = 40.20
            });

            return View(products);
        }
    }
}