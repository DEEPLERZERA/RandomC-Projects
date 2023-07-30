using HirokiBackend.Data;
using HirokiBackend.Models;
using HirokiBackend.Repositorios.interfaces;
using Microsoft.EntityFrameworkCore;

namespace HirokiBackend.Repositorios
{
    public class TransacaoRepositorio : ITransacaoRepositorio
    {

        private readonly SistemaDeBancoDBContext _dbContext;

        public TransacaoRepositorio(SistemaDeBancoDBContext sistemaDeBancoDBContext)
        {
            _dbContext = sistemaDeBancoDBContext;
        }

        public async Task<TransacaoModel> Adicionar(TransacaoModel Transacao)
        {
            await _dbContext.Transactions.AddAsync(Transacao);
            await _dbContext.SaveChangesAsync();
            return Transacao;
        }

        public async Task<TransacaoModel> BuscaPorId(int id)
        {
            TransacaoModel TransacaoId = await _dbContext.Transactions.Include(x => x.account).FirstOrDefaultAsync(x => x.id == id);

            if (TransacaoId == null)
            {
                throw new Exception($"Transacao para o ID: {id} não foi encontrado no banco de dados.");
            }

            return await _dbContext.Transactions.Include(x => x.account).FirstOrDefaultAsync(x => x.id == id);

        }

        public async Task<List<TransacaoModel>> BuscarTodasTransacoes()
        {
            return await _dbContext.Transactions.Include(x => x.account).ToListAsync();
        }

    }
}
