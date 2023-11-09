using API_Lançamento.Services.Models;
using Api_Lançamentos.Data.Entities;
using Api_Lançamentos.Data.Interfaces;
using Api_Lançamentos.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Lançamento.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LancamentosController : ControllerBase
    {
        [HttpPost]
        public IActionResult AdicionarLancamentoPost(LancamentosPostModel model)
        {
            try
            {
                var lancamento = new Lancamento()
                {
                    IdLancamento = Guid.NewGuid(),
                    Descricao = model.Descricao,
                    Data =  model.Data,
                    Valor = model.Valor,
                    Avulso = model.Avulso,
                    Status = model.Status
                };               

                var lancamentoRepository = new LancamentoRepository();

                lancamentoRepository.AdicionarLancamento(lancamento);

                return StatusCode(201, new { mensagem = "Lançamento cadastrado com sucesso. ", lancamento });
            }

            catch (Exception e)
            {
                return StatusCode(500, new {mensageme = e.Message});
            }
        }

        [HttpPut("{idLancamento}")]
        public IActionResult AtualizarLancamentoPut(LancamentosPutModel model)
        {
            try
            {                    

                var lancamento = new Lancamento()
                {
                    IdLancamento = model.IdLancamento,
                    Descricao = model.Descricao,
                    Data = model.Data,
                    Valor = model.Valor,
                    Avulso = model.Avulso,
                    Status = model.Status,
                };

                var lancamentoRepository = new LancamentoRepository();
                lancamentoRepository.AtualizarLancamento(lancamento);

                return StatusCode(200, new { mensagem = "Lançamento atualizado com sucesso. ", lancamento });

            }
            catch (Exception e)
            {
                return StatusCode(500, new { mensageme = e.Message });
            }
        }

        [HttpDelete("{id}/cancelar")]
        public IActionResult CancelarLancamentoDelete(Guid idLancamento)
        {
            try
            {
                var lancamentoRepository = new LancamentoRepository();
                var lancamento = lancamentoRepository.ObterLancamentoPorId(idLancamento);                 

                lancamentoRepository.CancelarLancamento(lancamento);

                return StatusCode(200, new { mensagem = "Lançamento cancelado com sucesso.", lancamento });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { mensagem = e.Message });
            }
        }

        [HttpGet]
        public IActionResult ListarLancamentosGetData()
        {
            try
            {
                var lancamentoRepository = new LancamentoRepository();
                var lista = new List<LancamentosGetModel>();

                foreach (var item in lancamentoRepository.ListarLancamentos())
                {
                    var model = new LancamentosGetModel()
                    {
                         IdLancamento = item.IdLancamento,
                         Descricao = item.Descricao,
                         Data = item.Data,
                         Valor = item.Valor,
                         Avulso = item.Avulso,
                         Status = item.Status
                    };
                    lista.Add(model);
                }
                return StatusCode(200, lista);

                
            }
            catch (Exception e)
            {
                return StatusCode(500, new { mensagem = e.Message });
            }
        }

        [HttpGet("{id}")]
        public IActionResult ObterLancamentoPorIdGetById(Guid idLancamento)
        {
            try
            {
                var lancamentoRepository = new LancamentoRepository();
                var lancamento = lancamentoRepository.ObterLancamentoPorId(idLancamento);

                var model = new LancamentosGetModel()
                {
                    IdLancamento = lancamento.IdLancamento,
                    Descricao = lancamento.Descricao,
                    Data = lancamento.Data,
                    Valor = lancamento.Valor,
                    Avulso = lancamento.Avulso,
                    Status = lancamento.Status
                };

                return StatusCode(200, model);
            }
            catch (Exception e)
            {
                return StatusCode(500, new { mensagem = e.Message });
            }
        }



    }
}
