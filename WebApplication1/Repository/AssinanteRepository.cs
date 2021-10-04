using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Repository
{
    public class AssinanteRepository : IAssinanteRepository
    {
        private readonly AssinanteDbContext contexto;
        public AssinanteRepository(AssinanteDbContext _contexto)
        {
            contexto = _contexto;
        }
        public void AdicionarAssinante(Assinante assinante)
        {
            contexto.Add(assinante);
            contexto.SaveChanges();
        }

        public Assinante RetornarPorId(int id)
        {
            return contexto.Assinante.Find(id);            
        }

        public IEnumerable<Assinante> RetornaTodos()
        {
            return contexto.Assinante.ToList();
        }

        public Assinante ValidarEntrada(Assinante assinante)
        {
            return assinante;
        }
    }
}
