using HirokiBackend.Data;
using HirokiBackend.Models;
using HirokiBackend.Repositorios.interfaces;
using Microsoft.EntityFrameworkCore;

namespace HirokiBackend.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private readonly SistemaDeBancoDBContext _dbContext;

        public UsuarioRepositorio(SistemaDeBancoDBContext sistemaDeBancoDBContext)
        {
            _dbContext = sistemaDeBancoDBContext;
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Users.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            if(usuario.username == null)
            {
                throw new Exception("Coloque o username!");
            }

            if (usuario.firstName == null)
            {
                throw new Exception("Coloque o firstName!");
            }

            if (usuario.lastName == null)
            {
                throw new Exception("Coloque o lastName!");
            }

            if (usuario.phone == null)
            {
                throw new Exception("Coloque o phone!");
            }

            if (usuario.address == null)
            {
                throw new Exception("Coloque o address!");
            }

            if (usuario.email == null)
            {
                throw new Exception("Coloque o email!");
            }

            if (usuario.password == null)
            {
                throw new Exception("Coloque o password!");
            }

            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscaPorId(id);

            if(usuarioPorId == null)
            {
                throw new Exception($"Usuário por ID: {id} não foi encontrando no banco de dados.");
            }

            usuarioPorId.firstName = usuario.firstName;
            usuarioPorId.lastName = usuario.lastName;
            usuarioPorId.email = usuario.email;
            usuarioPorId.phone = usuario.phone;
            usuarioPorId.address = usuario.address;
            usuarioPorId.username = usuario.username;
            usuarioPorId.password = usuario.password;

            _dbContext.Users.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return usuarioPorId;
        }

        public async Task<UsuarioModel> BuscaPorId(int id)
        {
            UsuarioModel usuarioId = await _dbContext.Users.FirstOrDefaultAsync(x => x.id == id);

            if (usuarioId == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }


            return await _dbContext.Users.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<UsuarioModel> Login(string username, int password)
        {

            UsuarioModel usuarioLogin = await _dbContext.Users.FirstOrDefaultAsync(x => x.username == username && x.password == password);

            if(usuarioLogin == null)
            {
                throw new Exception("Username ou senha incorretos!");
            }

            return await _dbContext.Users.FirstOrDefaultAsync(x => x.username == username && x.password == password);
        }
    }
}
