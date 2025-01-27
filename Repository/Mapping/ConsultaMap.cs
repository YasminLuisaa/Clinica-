using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mapping
{
    public class ConsultaMap : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            // Define o nome da tabela no banco de dados
            builder.ToTable("Consultas");

            // Configura a chave primária
            builder.HasKey(c => c.Id);

            // Configura a propriedade PacienteId como obrigatória
            builder.Property(c => c.PacienteId)
                .IsRequired();

            // Configura a propriedade MedicoId como obrigatória
            builder.Property(c => c.MedicoId)
                .IsRequired();

            // Configura a propriedade DataHora como obrigatória
            builder.Property(c => c.DataHora)
                .IsRequired();

            // Configura a propriedade Observacoes com tamanho máximo de 500 caracteres e permite nulo
            builder.Property(c => c.Observacoes)
                .HasColumnType("varchar(500)")
                .IsRequired(false);

            // Relacionamento muitos-para-um com Paciente
            builder.HasOne(c => c.Paciente)
                .WithMany(p => p.Consultas)
                .HasForeignKey(c => c.PacienteId);

            // Relacionamento muitos-para-um com Medico
            builder.HasOne(c => c.Medico)
                .WithMany(m => m.Consultas)
                .HasForeignKey(c => c.MedicoId);
        }
    }
}