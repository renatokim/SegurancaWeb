using Site.DTO.Chamado;
using Site.IServico.Chamados;
using Site.Servico;
using Site.Site.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Site.Controllers
{
    public class AntiSqlInjectionController : Controller
    {
        private readonly IChamadoServico _ChamadoServico = ServiceFactory.CreateInstance<IChamadoServico>();

        public ActionResult Index()
        {
            var chamados = _ChamadoServico.GetAll();
            return View(chamados);
        }

        public ActionResult Create()
        {
            var chamado = new ChamadoInsertViewModel();
            chamado.ComSqlInjection = true;

            return View(chamado);
        }

        [HttpPost]
        public ActionResult Create(DTOChamado chamado, bool ComSqlInjection)
        {
            chamado.Assunto = "Assunto teste";
            chamado.Comentario = "Comentario teste";
            chamado.Data = DateTime.Now;
            chamado.Obs = "Obs teste";

            if (!ComSqlInjection)
            {
                chamado.Descricao = SanitizeString(chamado.Descricao);
            }

            try
            {
                _ChamadoServico.SalvarActiveRecord(chamado);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private string SanitizeString(string expression)
        {
            return expression.ToString()
                    .Replace("<", "")
                    .Replace(">", "")
                    .Replace("\\", "")
                    .Replace("/", "")
                    .Replace("=", "")
                    .Replace("'", "")
                    .Replace("?", "");
        }
    }
}
