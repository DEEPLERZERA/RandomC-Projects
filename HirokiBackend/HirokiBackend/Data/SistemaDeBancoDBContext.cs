using HirokiBackend.Data.Map;
using HirokiBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace HirokiBackend.Data
{
    public class SistemaDeBancoDBContext : DbContext
    {
        public SistemaDeBancoDBContext(DbContextOptions<SistemaDeBancoDBContext> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Users { get; set; }

        public DbSet<ContaModel> Accounts { get; set; }

        public DbSet<TransacaoModel> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ContaMap());
            modelBuilder.ApplyConfiguration(new TransacaoMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
