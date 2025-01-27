using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mapping
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            // Define o nome da tabela no banco de dados
            builder.ToTable("Pacientes");

            // Configura a chave primária
            builder.HasKey(p => p.Id);

            // Configura a propriedade Nome como obrigatória com tamanho máximo de 100 caracteres
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            // Configura a propriedade DataNascimento como obrigatória
            builder.Property(p => p.DataNascimento)
                .IsRequired();

            // Configura a propriedade Endereco com tamanho máximo de 200 caracteres
            builder.Property(p => p.Endereco)
                .HasColumnType("varchar(200)");

            // Configura a propriedade Telefone com tamanho máximo de 20 caracteres
            builder.Property(p => p.Telefone)
                .HasColumnType("varchar(20)");

            // Relacionamento um-para-muitos com Consultas
            builder.HasMany(p => p.Consultas)
                .WithOne(c => c.Paciente)
                .HasForeignKey(c => c.PacienteId);
        }
    }
}