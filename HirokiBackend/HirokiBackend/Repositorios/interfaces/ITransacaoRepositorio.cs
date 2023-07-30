using HirokiBackend.Models;

namespace HirokiBackend.Repositorios.interfaces
{
    public interface ITransacaoRepositorio
    {
        Task<List<TransacaoModel>> BuscarTodasTransacoes();
        Task<TransacaoModel> BuscaPorId(int id);
        Task<TransacaoModel> Adicionar(TransacaoModel transacao);
    }
}
