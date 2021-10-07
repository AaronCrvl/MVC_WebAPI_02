using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class AssinanteRepository : IAssinanteRepository
    {
        private readonly AssinanteDbContext contexto;
        public AssinanteRepository(AssinanteDbContext _contexto)
        {
            contexto = _contexto;
        }
        public void AdicionarAssinante(AssinanteModel assinante)
        {
            using (var conexao = contexto.Database.BeginTransaction())
            {
                try
                {
                    contexto.Assinante.Add(assinante);
                    conexao.Commit();
                    contexto.SaveChanges();             
                }
                catch (Exception e)
                {
                    conexao.Rollback();
                    throw e;
                }
            }
        }

        public AssinanteModel RetornarPorId(int id)
        {
            return contexto.Assinante.Find(id);
        }

        public AssinanteModel CancelarAssinante(int id)
        {
            using (var conexao = contexto.Database.BeginTransaction())
            {
                try
                {
                    AssinanteModel UsuarioRemover = (AssinanteModel)contexto.Find(typeof(AssinanteModel), id);
                    UsuarioRemover.DataCancelamento = DateTime.UtcNow;
                    UsuarioRemover.Ativo = false;
                    contexto.SaveChanges();                    
                    return UsuarioRemover;
                }
                catch (Exception e)
                {
                    conexao.Rollback();
                    throw e;
                }
            }
            
        }

        public IEnumerable<AssinanteModel> RetornaTodos()
        {
            return contexto.Assinante.ToList();
        }

        public AssinanteModel ValidarEntrada(AssinanteModel assinante)
        {
            return assinante;
        }
    }
}
