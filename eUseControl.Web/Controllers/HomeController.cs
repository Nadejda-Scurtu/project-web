using eUseControl.BusinessLogic.Services;
using eUseControl.Controllers;
using System.Web.Mvc;

namespace WebAplication.Controllers
{
    public class HomeController : eUseBaseController
    {
        public ActionResult Index()
        {
            var products = ProductService.GetAll();
            return View(products.Entry);
        }
    }
}