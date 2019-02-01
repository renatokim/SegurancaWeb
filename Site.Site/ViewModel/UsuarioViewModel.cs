using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Site.ViewModel
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel()
        {
            Whitelist = new List<string>();
            Whitelist.Add("/Redirect/Details");
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Url { get; set; }
        public string AntiRedirect { get; set; }
        public IList<string> Whitelist { get; set; }
    }
}