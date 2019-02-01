using Site.ActiveRecords;
using Site.DTO.Chamado;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Entidade.EntidadeModel
{
    [Tabela("chm_chamado")]
    public class ChamadoModel
    {
        [Campo("id")]
        public string Id { get; set; }

        [Campo("sistema")]
        public string Sistema { get; set; }

        [Campo("data_criacao")]
        public string Data { get; set; }

        [Campo("assunto")]
        public string Assunto { get; set; }

        [Campo("descricao")]
        public string Descricao { get; set; }

        [Campo("obs")]
        public string Obs { get; set; }

        [Campo("prioridade")]
        public string Prioridade { get; set; }

        [Campo("pg")]
        public string Pago { get; set; }

        [Campo("horas")]
        public string Horas { get; set; }

        public static ChamadoModel Transform(DTOChamado chamado)
        {
            var chamadoModel = new ChamadoModel
            {
                Id = chamado.Id.ToString(CultureInfo.InvariantCulture),
                Sistema = chamado.Sistema.ToString(CultureInfo.InvariantCulture),
                Data = chamado.Data.ToString("yyyy-MM-dd"),
                Assunto = chamado.Assunto.ToString(CultureInfo.InvariantCulture),
                Descricao = chamado.Descricao.ToString(CultureInfo.InvariantCulture),
                Obs = chamado.Obs.ToString(CultureInfo.InvariantCulture),
                Prioridade = ((int)chamado.Prioridade).ToString(CultureInfo.InvariantCulture),
                Pago = ((int)chamado.Pago).ToString(CultureInfo.InvariantCulture),
                Horas = chamado.Horas.ToString(CultureInfo.InvariantCulture)
            };

            return chamadoModel;
        }
    }
}
