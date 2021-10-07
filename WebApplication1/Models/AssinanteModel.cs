using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AssinanteModel
    {
        public int Id { get; set; }        
        public string Nome { get; set; }        
        public string Senha { get; set; }
        public string Email { get; set; }    
        public DateTime DataInclusao { get; set; }
        public DateTime ? DataCancelamento { get; set; }
        public bool Ativo { get; set; }
    }
}
