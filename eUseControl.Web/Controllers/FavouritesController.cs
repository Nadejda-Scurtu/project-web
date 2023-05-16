using System.Web.Mvc;

namespace WebAplication.Controllers
{
    public class FavouritesController : Controller
    {
        // GET: Favourites
        public ActionResult Index()
        {
            return View();
        }
    }
}