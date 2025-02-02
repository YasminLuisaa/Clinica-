using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mapping
{
    public class MedicoMap : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("Medico");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Especialidade)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.CRM)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Telefone)
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Email)
                .HasColumnType("varchar(100)");
        }
    }
}