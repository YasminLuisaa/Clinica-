using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mapping
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("Paciente");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.DataNascimento)
                .IsRequired();

            builder.Property(prop => prop.Endereco)
                .HasColumnType("varchar(200)");

            builder.Property(prop => prop.Telefone)
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Email)
                .HasColumnType("varchar(100)");
        }
    }
}