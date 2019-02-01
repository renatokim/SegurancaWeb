using Site.Site.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Site.Site.Controllers
{
    public class RedirectController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.Url = returnUrl;
            return View();
        }

        [HttpPost]
        public ActionResult Login(UsuarioViewModel user)
        {
            FormsAuthentication.SetAuthCookie("Renato", false);

            if (string.IsNullOrEmpty(user.Url))
            {
                return View("Index");
            }
            else
            {
                if (!string.IsNullOrEmpty(user.AntiRedirect))
                {
                    if (user.Whitelist.Contains(user.Url))
                    {
                        return Redirect(user.Url);
                    }
                    else
                    {
                        return View("Error");
                    }
                }
                else
                {
                    return Redirect(user.Url);
                }
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return View("Login");
        }

        [Authorize]
        public ActionResult Details()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.User = User.Identity.Name;
            }

            return View();
        }

        public ActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.User = User.Identity.Name;
            }

            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}
