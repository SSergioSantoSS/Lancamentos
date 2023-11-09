using Api_Lançamentos.Data.Contexts;
using Api_Lançamentos.Data.Entities;
using Api_Lançamentos.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Lançamentos.Data.Repositories
{
    public class LancamentoRepository : ILancamentoRepository
    {
        public void AdicionarLancamento(Lancamento lancamento)
        {
            using (var sqlServerContext = new SqlServerContext())
            {
                sqlServerContext.Lancamentos.Add(lancamento);
                sqlServerContext.SaveChanges();
            }           
        }

        public void AtualizarLancamento(Lancamento lancamento)
        {
            using (var sqlServerContext = new SqlServerContext())
            {
                sqlServerContext.Lancamentos.Entry(lancamento).State = EntityState.Modified;
                sqlServerContext.SaveChanges();
            }
        }

        public void CancelarLancamento(Lancamento lancamento)
        {
            using (var sqlServerContext = new SqlServerContext())
            {
                sqlServerContext.Lancamentos.Remove(lancamento);
                sqlServerContext.SaveChanges();                

            }
        }

        public List<Lancamento> ListarLancamentos()
        {
            using (var sqlServerContext = new SqlServerContext())
            {
                return sqlServerContext.Lancamentos
                    .OrderBy(l => l.Data)                   
                    .ToList();
            }            
        }

        public Lancamento ObterLancamentoPorId(Guid idLancamento)
        {
            using (var sqlServerContext = new SqlServerContext())
            {
                return sqlServerContext.Lancamentos.Find(idLancamento);
            }
        }
    }  
}
