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
    public class EditProductUploadForm
    {
        public HttpPostedFileBase Image0 { get; set; }
        public HttpPostedFileBase Image1 { get; set; }
        public HttpPostedFileBase Image2 { get; set; }
        public int ProductId { get; set; }
    }


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
                var resp = ProductService.Add(product);
                if (resp.Success)
                {
                    return RedirectToAction("ListProducts");
                }

                ModelState.AddModelError("", resp.Message);
            }

            return View(product);
        }

        public ActionResult ListProducts()
        {
            var prodResp = ProductService.GetAll();
            if (!prodResp.Success)
                return HttpNotFound();

            return View(prodResp.Entry);
        }

        public ActionResult EditProduct(int id)
        {
            var prodResp = ProductService.GetById(id);
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
                var resp = ProductService.Add(product);
                if (resp.Success)
                {
                    return RedirectToAction("ListProducts");
                }

                ModelState.AddModelError("", resp.Message);
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProductUploadImage(EditProductUploadForm form)
        {
            var prodResp = ProductService.GetById(form.ProductId);
            if (!prodResp.Success)
                return HttpNoPermission();

            var product = prodResp.Entry;
            if (product == null)
                return HttpNotFound();

            for (var i = 0; i < 3; i++)
            {
                HttpPostedFileBase file = null;

                switch(i)
                {
                    case 0:
                        file = form.Image0; break;
                    case 1:
                        file = form.Image1; break;
                    case 2:
                        file = form.Image2; break;
                }

                if (file == null)
                    continue;

                byte[] bytes = new byte[file.ContentLength];
                using (BinaryReader theReader = new BinaryReader(file.InputStream))
                {
                    bytes = theReader.ReadBytes(file.ContentLength);
                }
                string base64 = Convert.ToBase64String(bytes);
                var image = $"data:{file.ContentType};base64,{base64}";

                switch (i)
                {
                    case 0: product.Image0 = image; break;
                    case 1: product.Image1 = image; break;
                    case 2: product.Image2 = image; break;
                }
            }

            ProductService.Edit(product);
            return RedirectToAction("EditProduct", new {id = product.Id});
        }
    }
}