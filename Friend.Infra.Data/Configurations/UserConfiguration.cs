using Friend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Friend.Infra.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("tb_usuario");

            builder.Property(p => p.Id).HasColumnName("id");
            
            builder.Property(p => p.Name).HasColumnName("nm_nome");
            
            builder.Property(p => p.Email).HasColumnName("ds_email");
            
            builder.Property(p => p.Document).HasColumnName("ds_cpf");
            
            builder.Property(p => p.Password).HasColumnName("ds_senha");
            
            builder.Property(p => p.DTCreate).HasColumnName("dt_cadastro");
            
            builder.Property(p => p.DTUpdate).HasColumnName("dt_alteracao");
        }
    }
}
