using HirokiBackend.Models;
using HirokiBackend.Repositorios.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HirokiBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        private readonly ITransacaoRepositorio _transacaoRepositorio;


        public TransacaoController(ITransacaoRepositorio transacaoRepositorio)
        {
            _transacaoRepositorio = transacaoRepositorio;
        }

        [HttpGet("buscarTodasTransacoes")]

        public async Task<ActionResult<List<TransacaoModel>>> BuscarTodasTransacoes()
        {
            List<TransacaoModel> transacoes = await _transacaoRepositorio.BuscarTodasTransacoes();
            return Ok(transacoes);
        }



        [HttpGet("{id}")]

        public async Task<ActionResult<TransacaoModel>> BuscarPorId(int id)
        {
            TransacaoModel transacao = await _transacaoRepositorio.BuscaPorId(id);
            return Ok(transacao);
        }


        [HttpPost("criarTransacao")]

        public async Task<ActionResult<TransacaoModel>> Criar([FromBody] TransacaoModel transacaoModel)
        {
            TransacaoModel transacao = await _transacaoRepositorio.Adicionar(transacaoModel);
            return Ok(transacao);
        }


    }
}
