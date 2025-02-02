using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mapping
{
    public class ConsultaMap : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("Consulta");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.PacienteId)
                .IsRequired();

            builder.Property(prop => prop.MedicoId)
                .IsRequired();

            builder.Property(prop => prop.DataHora)
                .IsRequired();

            builder.Property(prop => prop.Status)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Motivo)
                .HasColumnType("varchar(200)");

            // Relacionamentos
            builder.HasOne(prop => prop.Paciente);
            builder.HasOne(prop => prop.Medico);
        }
    }
}