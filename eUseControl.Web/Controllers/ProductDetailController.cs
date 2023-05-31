using eUseControl.BusinessLogic.Services;
using eUseControl.Controllers;
using System.Web.Mvc;

namespace WebAplication.Controllers
{
    public class ProductDetailController : eUseBaseController
    {
        // GET: ProductDetail
        public ActionResult Index(int? id)
        {
            if (!id.HasValue)
                return HttpNotFound();

            var prodresp = ProductService.GetById(id.Value);
            if (!prodresp.Success)
                return HttpNoPermission();

            var product = prodresp.Entry;
            if (product == null)
                return HttpNotFound();

            return View(product);
        }
    }
}