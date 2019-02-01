using Site.DTO.Chamado;
using Site.Site.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Site.Controllers
{
    public class AntiXSSController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateXSS()
        {
            var chamado = new ChamadoViewModel();
            chamado.ComXSS = true;
            return View(chamado);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult CreateXSS(ChamadoViewModel chamado)
        {
            try
            {
                if (chamado.ComXSS)
                {
                    Response.AppendHeader("X-XSS-Protection", "0");
                }
                else
                {
                    Response.AppendHeader("X-XSS-Protection", "1");
                }

                return View(chamado);
            }
            catch
            {
                return View();
            }
        }
    }
}
