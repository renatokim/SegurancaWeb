using Site.DTO.Chamado;
using Site.Site.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Site.Controllers
{
    public class AntiMassAttackController : Controller
    {
        public ActionResult Index()
        {
            var chamados = new List<DTOChamado>();
            return View(chamados);
        }

        public ActionResult CreateComMassAttack()
        {
            var chamado = new ChamadoMassAttackViewModel();
            chamado.Tipo = "COMUM";

            return View(chamado);
        }

        [HttpPost]
        public ActionResult CreateComMassAttack(ChamadoMassAttackViewModel chamado)
        {
            return View(chamado);
        }

        public ActionResult CreateSemMassAttack()
        {
            var chamado = new ChamadoMassAttackViewModel();
            chamado.Tipo = "COMUM";

            return View(chamado);
        }

        [HttpPost]
        public ActionResult CreateSemMassAttack(ChamadoAntiMassAttackViewModel chamado)
        {
            var chamadoComMassAtack = new ChamadoMassAttackViewModel();
            chamadoComMassAtack.Descricao = chamado.Descricao;

            return View(chamadoComMassAtack);
        }
    }
}
