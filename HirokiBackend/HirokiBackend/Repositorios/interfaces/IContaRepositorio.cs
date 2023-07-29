using HirokiBackend.Models;

namespace HirokiBackend.Repositorios.interfaces
{
    public interface IContaRepositorio
    {
        Task<List<ContaModel>> BuscarTodasContas();
        Task<ContaModel> BuscaPorId(int id);
        Task<ContaModel> Adicionar(ContaModel conta);
        Task<ContaModel> Atualizar(ContaModel conta, int id);
        Task<bool> Apagar(int id);
    }
}
