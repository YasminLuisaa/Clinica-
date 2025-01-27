using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mapping
{
    public class MedicoMap : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            // Define o nome da tabela no banco de dados
            builder.ToTable("Medicos");

            // Configura a chave primária
            builder.HasKey(m => m.Id);

            // Configura a propriedade Nome como obrigatória com tamanho máximo de 100 caracteres
            builder.Property(m => m.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            // Configura a propriedade CRM como obrigatória com tamanho máximo de 20 caracteres
            builder.Property(m => m.CRM)
                .IsRequired()
                .HasColumnType("varchar(20)");

            // Configura a propriedade Telefone com tamanho máximo de 20 caracteres
            builder.Property(m => m.Telefone)
                .HasColumnType("varchar(20)");

            // Configura a propriedade EspecialidadeId como obrigatória
            builder.Property(m => m.EspecialidadeId)
                .IsRequired();

            // Relacionamento muitos-para-um com Especialidade
            builder.HasOne(m => m.Especialidade)
                .WithMany(e => e.Medicos)
                .HasForeignKey(m => m.EspecialidadeId);

            // Relacionamento um-para-muitos com Consultas
            builder.HasMany(m => m.Consultas)
                .WithOne(c => c.Medico)
                .HasForeignKey(c => c.MedicoId);
        }
    }
}