using eUseControl.BusinessLogic.Services;
using eUseControl.Controllers;
using eUseControl.Domain.Entities;
using System.IO;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace WebAplication.Controllers
{
    public class AdminController : eUseBaseController
    {
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Notifications()
        {
            return View();
        }
        public ActionResult Orders()
        {
            return View();
        }
        public ActionResult UserProfile()
        {
            return View();
        }

        public ActionResult AddProduct()
        {
            return View("EditProduct");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                var prodService = new ProductService();
                var resp = prodService.Add(product);
                if (resp.Success)
                    return RedirectToAction("ListProducts");

                ModelState.AddModelError("", resp.Message);
            }

            return View("EditProduct", product);
        }

        public ActionResult ListProducts()
        {
            var prodService = new ProductService();
            var prodResp = prodService.GetAll();
            if (!prodResp.Success)
                return HttpNotFound();

            return View(prodResp.Entry);
        }

        public ActionResult EditProduct(int id)
        {
            var prodService = new ProductService();
            var prodResp = prodService.GetById(id);
            if (!prodResp.Success)
                return HttpNotFound();

            var prod = prodResp.Entry;
            return View(prod);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                var prodService = new ProductService();
                var resp = prodService.Edit(product);
                if (resp.Success)
                {
                    return RedirectToAction("ListProducts");
                }

                ModelState.AddModelError("", resp.Message);
            }

            return View(product);
        }

        public ActionResult DeleteProduct(int id)
        {
            var prodService = new ProductService();
            var prodResp = prodService.GetById(id);
            if (!prodResp.Success)
                return HttpNotFound();

            var prod = prodResp.Entry;
            return View(prod);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("DeleteProduct")]
        public ActionResult DeleteProductConfirm(int id)
        {
            if (ModelState.IsValid)
            {
                var prodService = new ProductService();
                var prodResp = prodService.GetById(id);
                if (!prodResp.Success)
                    return HttpNotFound();

                var product = prodResp.Entry;
                var resp = prodService.Delete(product);

                ModelState.AddModelError("", resp.Message);
            }

            return RedirectToAction("ListProducts");
    }
}