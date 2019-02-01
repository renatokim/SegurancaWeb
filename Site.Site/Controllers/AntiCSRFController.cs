using AntiCSRF;
using AntiCSRF.Config;
using Site.DTO.Chamado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Site.Site.Controllers
{
    public class AntiCSRFController : Controller
    {
        AntiCSRFConfig nSegundos = new AntiCSRFConfig
        {
            expiryInSeconds = 10
        };

        public ActionResult Index()
        {
            var chamados = new List<DTOChamado>();

            return View(chamados);
        }

        public ActionResult Create()
        {
            var token = AntiCSRFToken.GenerateToken("username", "key", nSegundos);

            ViewBag.Token = token;
            ViewBag.TokenValido = false;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DTOChamado chamado, string token)
        {
            var isValid = AntiCSRFToken.ValidateToken(token, "key", "username", nSegundos);
            ViewBag.Token = token;
            ViewBag.TokenValido = isValid;

            return View();
        }

        public ActionResult CreateInvalid()
        {
            var token = AntiCSRFToken.GenerateToken("username", "key", nSegundos);

            ViewBag.Token = token;
            ViewBag.TokenValido = false;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateInvalid(DTOChamado chamado, string token)
        {
            var isValid = AntiCSRFToken.ValidateToken(token, "key", "username", nSegundos);
            ViewBag.Token = token;
            ViewBag.TokenValido = isValid;

            return View();
        }
    }
}
