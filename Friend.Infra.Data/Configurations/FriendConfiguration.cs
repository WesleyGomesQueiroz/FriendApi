using Friend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Friend.Infra.Data.Configurations
{
    public class FriendConfiguration : IEntityTypeConfiguration<Friends>
    {
        public void Configure(EntityTypeBuilder<Friends> builder)
        {
            builder.ToTable("tb_amigo");

            builder.Property(p => p.Id).HasColumnName("id");
            
            builder.Property(p => p.IdUser).HasColumnName("id_usuario");

            builder.Property(p => p.Name).HasColumnName("nm_nome");

            builder.Property(p => p.Email).HasColumnName("ds_email");

            builder.Property(p => p.DDD).HasColumnName("nr_ddd");

            builder.Property(p => p.Phone).HasColumnName("nr_telefone");

            builder.Property(p => p.Adress).HasColumnName("ds_endereco");

            builder.Property(p => p.Status).HasColumnName("fl_status");

            builder.Property(p => p.DTCreate).HasColumnName("dt_cadastro");

            builder.Property(p => p.DTUpdate).HasColumnName("dt_alteracao");
        }
    }
}
