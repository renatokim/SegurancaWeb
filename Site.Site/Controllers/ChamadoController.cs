using Site.DTO.Chamado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Site.Controllers
{
    public class ChamadoController : Controller
    {
        public ActionResult AntiCSRF()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AntiCSRF(DTOChamado chamado)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Chamado/

        public ActionResult Index()
        {
            var chamados = new List<DTOChamado>();

            return View(chamados);
        }

        //
        // GET: /Chamado/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Chamado/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Chamado/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Chamado/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Chamado/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Chamado/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Chamado/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
