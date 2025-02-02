using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mapping
{
    public class ProntuarioMedicoMap : IEntityTypeConfiguration<ProntuarioMedico>
    {
        public void Configure(EntityTypeBuilder<ProntuarioMedico> builder)
        {
            builder.ToTable("ProntuarioMedico");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.PacienteId)
                .IsRequired();

            builder.Property(prop => prop.MedicoId)
                .IsRequired();

            builder.Property(prop => prop.DataHora)
                .IsRequired();

            builder.Property(prop => prop.Descricao)
                .HasColumnType("varchar(500)");

            builder.Property(prop => prop.Prescricao)
                .HasColumnType("varchar(500)");

            // Relacionamentos
            builder.HasOne(prop => prop.Paciente);
            builder.HasOne(prop => prop.Medico);
        }
    }
}