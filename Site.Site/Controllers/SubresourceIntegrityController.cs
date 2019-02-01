using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Site.Controllers
{
    public class SubresourceIntegrityController : Controller
    {
        //
        // GET: /SubresourceIntegrity/

        public ActionResult Index()
        {
            Response.AppendHeader("Access-Control-Allow-Origin", "*");

            return View();
        }

        //
        // GET: /SubresourceIntegrity/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /SubresourceIntegrity/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SubresourceIntegrity/Create

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
        // GET: /SubresourceIntegrity/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /SubresourceIntegrity/Edit/5

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
        // GET: /SubresourceIntegrity/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SubresourceIntegrity/Delete/5

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
