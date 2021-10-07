using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IAssinanteRepository
    {
        AssinanteModel ValidarEntrada(AssinanteModel assinante);
        void AdicionarAssinante(AssinanteModel assinante);
        IEnumerable<AssinanteModel> RetornaTodos();
        AssinanteModel RetornarPorId(int id);
        AssinanteModel CancelarAssinante(int id);
    }
}
