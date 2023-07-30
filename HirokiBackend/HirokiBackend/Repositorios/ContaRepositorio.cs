using HirokiBackend.Data;
using HirokiBackend.Models;
using HirokiBackend.Repositorios.interfaces;
using Microsoft.EntityFrameworkCore;

namespace HirokiBackend.Repositorios
{
    public class ContaRepositorio : IContaRepositorio
    {

        private readonly SistemaDeBancoDBContext _dbContext;

        public ContaRepositorio(SistemaDeBancoDBContext sistemaDeBancoDBContext)
        {
            _dbContext = sistemaDeBancoDBContext;
        }

        public async Task<ContaModel> Adicionar(ContaModel conta)
        {
            await _dbContext.Accounts.AddAsync(conta);
            await _dbContext.SaveChangesAsync();
            return conta;
        }

        public async Task<ContaModel> Atualizar(ContaModel conta, int id)
        {
            ContaModel contaPorId = await BuscaPorId(id);

            if (contaPorId == null)
            {
                throw new Exception($"Conta por ID: {id} não foi encontrando no banco de dados.");
            }

            contaPorId.accountNumber = conta.accountNumber;
            contaPorId.balance = conta.balance;
            contaPorId.accountType = conta.accountType;
            contaPorId.openedDate = conta.openedDate;
            contaPorId.userId = conta.userId;

            _dbContext.Accounts.Update(contaPorId);
            await _dbContext.SaveChangesAsync();

            return contaPorId;
        }

        public async Task<ContaModel> BuscaPorId(int id)
        {
            ContaModel contaId = await _dbContext.Accounts.Include(x => x.user).FirstOrDefaultAsync(x => x.id == id);

            if (contaId == null)
            {
                throw new Exception($"Conta para o ID: {id} não foi encontrado no banco de dados.");
            }

            return await _dbContext.Accounts.Include(x => x.user).FirstOrDefaultAsync(x => x.id == id);

        }

        public async Task<List<ContaModel>> BuscarTodasContas()
        {
            return await _dbContext.Accounts.Include(x => x.user).ToListAsync();
        }

        public async Task<bool> Apagar(int id)
        {
            ContaModel contaPorId = await BuscaPorId(id);

            if (contaPorId == null)
            {
                throw new Exception($"Conta para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Accounts.Remove(contaPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

    }
}
