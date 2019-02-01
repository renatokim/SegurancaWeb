using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Site.Controllers
{
    public class ContentSecurityPolicyController : Controller
    {
        public ActionResult Index()
        {
            Response.AppendHeader("Content-Security-Policy", "style-src *");

            return View();
        }
    }
}
