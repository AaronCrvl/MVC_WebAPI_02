using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("Central/[Controller]")]
    public class AssinanteController
    {
        private readonly IAssinanteRepository AssinanteRepo;

        public AssinanteController(IAssinanteRepository _AssinanteRepo)
        {
            this.AssinanteRepo = _AssinanteRepo;
        }

        [HttpGet("RetornarTodos/")]
        public IEnumerable<AssinanteModel> RetornarTodos()
        {
            return AssinanteRepo.RetornaTodos();
        }

        [HttpGet("RetornarPorId/{id}")]
        public IActionResult RetornarPorId(int Id)
        {
            var UserAx = AssinanteRepo.RetornarPorId(Id);
            if (UserAx == null)
                return new NotFoundResult();
            else
                return new ObjectResult(UserAx);
        }

        [HttpPost("InserirAssinante/")]
        public IActionResult InserirAssinante([FromBody]AssinanteModel assinante)
        {
            var retorno = new ContentResult();
            if (assinante == null)
            {
                return new BadRequestResult();
            }
            else
            {
                assinante.DataInclusao = DateTime.Now;
                AssinanteRepo.AdicionarAssinante(assinante);
                return new OkResult();
            }
        }
        
        [HttpDelete("CancelarAssinante/{id}/{senha}")]
        public IActionResult CancelarAssinante(int id, string senha)
        {
            var UserAx = AssinanteRepo.RetornarPorId(id);
            
            var retorno = new ContentResult();

            if (UserAx == null)
            {
                return new NotFoundResult();
            }
            else
            {
                if (UserAx.Senha == senha)
                {
                    var objRetorno = AssinanteRepo.CancelarAssinante(id);
                    retorno.Content = string.Format("Assinante Cancelado." +                        
                        " Id: {0}" +
                        " Nome: {1} " +
                        " Email: {2} ",
                        objRetorno.Id, objRetorno.Nome, objRetorno.Email);

                    retorno.StatusCode = 200;

                    return new ObjectResult(retorno);
                }
                return new BadRequestResult();
            }               
        }
    }
}
