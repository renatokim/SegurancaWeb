using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Site.ViewModel
{
    public class ChamadoInsertViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool ComSqlInjection { get; set; }
    }
}