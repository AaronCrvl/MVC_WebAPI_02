using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("api/[Controller]")]
    public class AssinanteController
    {
        private readonly IAssinanteRepository AssinanteRepo;

        public AssinanteController(IAssinanteRepository _AssinanteRepo)
        {
            this.AssinanteRepo = _AssinanteRepo;
        }

        [HttpGet]
        public IEnumerable<Assinante> RetornarTodos()
        {
            return AssinanteRepo.RetornaTodos();
        }

        [HttpGet("{id}")]
        public IActionResult RetornarPorId(long Id)
        {
            var UserAx = AssinanteRepo.RetornarPorId(Id);
            if (UserAx == null)
                return null;
            else
                return new ObjectResult(UserAx);
        }
    }
}
