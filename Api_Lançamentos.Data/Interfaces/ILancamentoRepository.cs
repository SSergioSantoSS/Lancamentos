using Api_Lançamentos.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Lançamentos.Data.Interfaces
{
    public interface ILancamentoRepository
    {  

        void AdicionarLancamento(Lancamento lancamento);
        void AtualizarLancamento(Lancamento lancamento);
        void CancelarLancamento(Lancamento lancamento);

        List<Lancamento> ListarLancamentos();
        Lancamento ObterLancamentoPorId(Guid idLancamento);



        
    }
}


