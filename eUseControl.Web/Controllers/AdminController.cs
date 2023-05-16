using eUseControl.BusinessLogic.Services;
using eUseControl.Domain.Entities;
using System.Web.Mvc;

namespace WebAplication.Controllers
{
    public class AdminController : Controller
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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct([Bind(Exclude = "Id")] Product product)
        {
            if (ModelState.IsValid)
            {
                var resp = ProductService.Add(product);
                if (resp.Success)
                {
                    return RedirectToAction("Dashboard");
                }

                ModelState.AddModelError("", resp.Message);
            }

            return View(product);
        }

        public ActionResult EditProduct()
        {
            return View();
        }
    }
}