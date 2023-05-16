using eUseControl.BusinessLogic.Services;
using eUseControl.Controllers;
using eUseControl.Web.Extensions;
using System;
using System.Web;
using System.Web.Mvc;
using WebAplication.Models;

namespace WebAplication.Controllers
{
    public class AccountController : eUseBaseController
    {
        // GET: Account
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(UserLoginForm form)
        {
            if (ModelState.IsValid)
            {
                var data = new AccountService.LoginData()
                {
                    Email = form.Email,
                    Password = form.Password,
                    IpAddress = Request.UserHostAddress,
                    Time = DateTime.Now
                };

                var loginResp = AccountService.Login(data);
                if (loginResp.Success)
                {
                    var session = loginResp.Entry;

                    // Create Cookie.
                    var cookie = new HttpCookie(SESSION_COOKIE_NAME, session.Token);
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);

                    return Redirect("/");
                }

                ModelState.AddModelError("Password", loginResp.Message);
            }

            return View(form);
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(UserRegisterForm form)
        {
            if (ModelState.IsValid)
            {
                var data = new AccountService.RegisterData()
                {
                    Name = form.Name,
                    Surname = form.Surname,
                    Email = form.Email,
                    Password = form.Password,
                    IpAddress = Request.UserHostAddress,
                    Time = DateTime.Now
                };

                var resp = AccountService.Register(data);
                if (!resp.Success)
                {
                    ModelState.AddModelError("", resp.Message);
                    return View(form);
                }

                return SignIn(new UserLoginForm()
                {
                    Email = form.Email,
                    Password = form.Password,
                    RememberPassword = true
                });
            }

            return View(form);
        }

        public ActionResult Logout()
        {
            // Clear session cookie.
            var cookie = Request.Cookies[SESSION_COOKIE_NAME];
            if (cookie != null)
            {
                // Force expire.
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }

            Session.ClearUser();
            return Redirect("/");
        }
    }
}