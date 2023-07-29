using HirokiBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HirokiBackend.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.firstName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.lastName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.address).IsRequired().HasMaxLength(150);
            builder.Property(x => x.phone).IsRequired();
            builder.Property(x => x.email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.username).IsRequired().HasMaxLength(100);
            builder.Property(x => x.password).IsRequired();

        }
    }
}
