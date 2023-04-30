using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.User.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAplication.Models;

namespace WebAplication.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ISession _session;

        public RegisterController()
        {
            var bl = new BusinessLogic();
            _session = bl.GetSessionBL();
        }

        // GET: Register
        public ActionResult Index()
        {
            return View("Register");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserRegister register)
        {
            if (ModelState.IsValid)
            {
                URegisterData data = new URegisterData
                {
                    Name = register.Name,
                    Surname = register.Surname,
                    Email = register.Email,
                    Password = register.Password
                };
                var userRegister = _session.UserRegister(data);
                if (userRegister.Status)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userRegister.StatusMsg);
                    return View("Register");
                }
            }
            return View("Register");
        }
    }
}