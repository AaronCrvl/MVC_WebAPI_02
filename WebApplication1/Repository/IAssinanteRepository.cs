using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IAssinanteRepository
    {
        Assinante ValidarEntrada(Assinante assinante);
        void AdicionarAssinante(Assinante assinante);
        IEnumerable<Assinante> RetornaTodos();
        Assinante RetornarPorId(int id);
    }
}
