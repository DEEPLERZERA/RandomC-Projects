using HirokiBackend.Models;

namespace HirokiBackend.Repositorios.interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<UsuarioModel> BuscaPorId(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<UsuarioModel> Login(string username, int password);
    }
}
