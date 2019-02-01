using Site.DTO.Chamado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Site.Controllers
{
    public class CookieProtectController : Controller
    {
        public ActionResult Index()
        {
            var chamado = new DTOChamado();
            chamado.Id = 1;

            HttpCookie cookieInsecure = new HttpCookie("cookieInsecure");
            cookieInsecure.Value = "HO5fCB5a8jrlB592yNYEjwh";
            cookieInsecure.HttpOnly = false;
            cookieInsecure.Secure = false;

            HttpCookie cookieSafe = new HttpCookie("cookieSafe");
            cookieSafe.Value = "8jrlB592yNYEjwh";
            cookieSafe.HttpOnly = true;
            cookieSafe.Secure = false;

            Response.Cookies.Add(cookieInsecure);
            Response.Cookies.Add(cookieSafe);
            

            Session["session"] = "valorSession";

            return View(chamado);
        }

        public ActionResult Edit(int id)
        {
            ViewBag.CookieInsecure = Request.Cookies["cookieInsecure"];
            ViewBag.CookieSafe = Request.Cookies["cookieSafe"];

            var chamado = new DTOChamado();
            return View(chamado);
        }
    }
}
