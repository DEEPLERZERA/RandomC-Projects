using HirokiBackend.Models;
using HirokiBackend.Repositorios.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HirokiBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly IContaRepositorio _contaRepositorio;


        public ContaController(IContaRepositorio contaRepositorio)
        {
            _contaRepositorio = contaRepositorio;
        }

        [HttpGet("listar")]

        public async Task<ActionResult<List<ContaModel>>> ListarContas()
        {
            List<ContaModel> contas = await _contaRepositorio.BuscarTodasContas();
            return Ok(contas);
        }



        [HttpGet("{id}")]

        public async Task<ActionResult<ContaModel>> BuscarPorId(int id)
        {
            ContaModel conta = await _contaRepositorio.BuscaPorId(id);
            return Ok(conta);
        }

        [HttpPost("criar")]

        public async Task<ActionResult<ContaModel>> Criar([FromBody] ContaModel contaModel)
        {
            ContaModel conta = await _contaRepositorio.Adicionar(contaModel);
            return Ok(conta);
        }

        [HttpPut("atualizarConta/{id}")]

        public async Task<ActionResult<ContaModel>> Atualizar([FromBody] ContaModel contaModel, int id)
        {
            contaModel.id = id;
            ContaModel conta = await _contaRepositorio.Atualizar(contaModel, id);
            return Ok(conta);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<ContaModel>> Apagar(int id)
        {
            bool apagado = await _contaRepositorio.Apagar(id);
            return Ok(apagado);
        }



    }
}
