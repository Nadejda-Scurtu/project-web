﻿using eUseControl.BusinessLogic.Services;
using eUseControl.Controllers;
using eUseControl.Domain.Enums;
using eUseControl.Web.Extensions;
using eUseControl.Web.Filters;
using System.Web.Mvc;

namespace WebAplication.Controllers
{
    public class ViewCartController : eUseBaseController
    {
        // GET: ViewCart
        public ActionResult Index()
        {
            return View();
        }

        [RequireUserLogin]
        [HttpPost]
        public ActionResult AddProduct(int? product_id)
        {
            if (!product_id.HasValue)
                return HttpNoPermission();

            var prodService = new ProductService();
            var prodResp = prodService.GetById(product_id.Value);
            if (!prodResp.Success)
                return HttpNoPermission();

            var product = prodResp.Entry;
            if (product == null)
                return HttpNotFound();

            var user = Session.GetUser();
            var userService = new UserService();
            userService.AddProductToUserCart(user, product);
            return Json(new { success = 1 });
        }

        [RequireUserLogin]
        [HttpPost]
        public ActionResult RemoveProduct(int? product_id)
        {
            if (!product_id.HasValue)
                return HttpNoPermission();

            var prodService = new ProductService();
            var prodResp = prodService.GetById(product_id.Value);
            if (!prodResp.Success)
                return HttpNoPermission();

            var product = prodResp.Entry;
            if (product == null)
                return HttpNotFound();

            var user = Session.GetUser();
            var userService = new UserService();
            userService.RemoveProductToUserCart(user, product);
            return Json(new { success = 1 });
        }
    }
}