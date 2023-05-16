using System.Web;
using System;
using System.Web.Mvc;
using WebAplication.Models;
using eUseControl.BusinessLogic.Services;
using eUseControl.Controllers;
using eUseControl.Web.Extensions;

namespace WebAplication.Controllers
{
    public class AccountController : eUseBaseController
    {
        // GET: Account
        public ActionResult SignIn()
        {
            return View();
        }

        // POST /Auth/Login
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