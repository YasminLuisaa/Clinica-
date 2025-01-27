using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mapping
{
    public class EspecialidadeMap : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            // Define o nome da tabela no banco de dados
            builder.ToTable("Especialidades");

            // Configura a chave primária
            builder.HasKey(e => e.Id);

            // Configura a propriedade Nome como obrigatória com tamanho máximo de 100 caracteres
            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            // Relacionamento um-para-muitos com Medicos
            builder.HasMany(e => e.Medicos)
                .WithOne(m => m.Especialidade)
                .HasForeignKey(m => m.EspecialidadeId);
        }
    }
}