using eUseControl.BusinessLogic.Services;
using eUseControl.Controllers;
using System.Web.Mvc;

namespace WebAplication.Controllers
{
    public class HomeController : eUseBaseController
    {
        public ActionResult Index()
        {
            var prodService = new ProductService();
            var products = prodService.GetAll();
            return View(products.Entry);
        }
    }
}