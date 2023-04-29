using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAplication.Controllers
{
    public class AccountController : Controller
    {
        private readonly ISession _session;

        public AccountController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }

        // GET: Account
        public ActionResult SignIn()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Index(UserLogin login)
        //{
        //    if (ModelState.IsValid) 
        //    {
        //        ULoginData data = new ULoginData
        //        {
        //            Credential = login.Credential,
        //            Password = login.Password,
        //            LoginIP = login.LoginIP,
        //            LoginDateTime = DateTime.Now
        //        };
        //
        //        var userLogin = _session.UserLogin(data);
        //        if (userLogin.Status)
        //        {
        //            // ADD COOKIE
        //
        //            return RedirectToAction("Index", "Home");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", userLogin.statusMsg);
        //            return View();
        //        }
        //    }
        //    return View();
        //}



        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignOut()
        {
            return View();
        }
    }
}