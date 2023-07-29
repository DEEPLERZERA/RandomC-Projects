using HirokiBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HirokiBackend.Data.Map
{
        public class ContaMap : IEntityTypeConfiguration<ContaModel>
        {
            public void Configure(EntityTypeBuilder<ContaModel> builder)
            {
                builder.HasKey(x => x.id);
                builder.Property(x => x.accountNumber).IsRequired();
                builder.Property(x => x.balance).IsRequired();
                builder.Property(x => x.accountType).IsRequired().HasMaxLength(30);
                builder.Property(x => x.openedDate).IsRequired();
                builder.Property(x => x.userId).IsRequired();

                builder.HasOne(x => x.user);

            }
        }
 }
