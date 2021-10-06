using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Views
{
    public class PaginaInicialModel : PageModel
    {        
        public string Retorno { get; set; }

        public void OnGet() { }

        public void OnPostSubmit(AssinanteModel assinante)
        {
            this.Retorno = string.Format("Dados - Nome {0} - Senha {1}", assinante.Nome, assinante.Senha);
        }
    }
}
