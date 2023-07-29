using HirokiBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HirokiBackend.Data.Map
{
        public class TransacaoMap : IEntityTypeConfiguration<TransacaoModel>
    {
        public void Configure(EntityTypeBuilder<TransacaoModel> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.accountId).IsRequired();
            builder.Property(x => x.transactionType).IsRequired().HasMaxLength(30);
            builder.Property(x => x.amount).IsRequired();
            builder.Property(x => x.date).IsRequired();
            builder.Property(x => x.otherAccount).IsRequired();

            builder.HasOne(x => x.account);
        }
    }
}
