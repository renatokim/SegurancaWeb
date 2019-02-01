using Site.DTO.Chamado;
using Site.Security;
using Site.Site.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Site.Controllers
{
    public class CryptographyController : Controller
    {
        public ActionResult Index()
        {
            var chamado = new ChamadoCriptografado();

            chamado.Id = 1;

            string plainText = chamado.Id.ToString();    // original plaintext

            string passPhrase = ConfigurationManager.AppSettings["PassPhrase"];        // can be any string
            string saltValue = ConfigurationManager.AppSettings["SaltValue"];        // can be any string
            string hashAlgorithm = "SHA1";             // can be "MD5"
            int passwordIterations = 2;                // can be any number
            string initVector = ConfigurationManager.AppSettings["InitVector"]; // must be 16 bytes
            int keySize = 256;                // can be 192 or 128

            string cipherText = RijndaelSimple.Encrypt
            (
                plainText,
                passPhrase,
                saltValue,
                hashAlgorithm,
                passwordIterations,
                initVector,
                keySize
            );

            plainText = RijndaelSimple.Decrypt
            (
                cipherText,
                passPhrase,
                saltValue,
                hashAlgorithm,
                passwordIterations,
                initVector,
                keySize
            );

            chamado.IdCriptografado = cipherText;

            return View(chamado);
        }

        //
        // GET: /Cryptography/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Cryptography/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cryptography/Create

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
        // GET: /Cryptography/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Cryptography/Edit/5

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
        // GET: /Cryptography/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Cryptography/Delete/5

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
