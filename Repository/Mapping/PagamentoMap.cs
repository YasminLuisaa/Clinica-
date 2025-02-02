using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mapping
{
    public class PagamentoMap : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("Pagamento");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.PacienteId)
                .IsRequired();

            builder.Property(prop => prop.ConsultaId)
                .IsRequired();

            builder.Property(prop => prop.DataHora)
                .IsRequired();

            builder.Property(prop => prop.Valor)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(prop => prop.MetodoPagamento)
                .IsRequired()
                .HasColumnType("varchar(20)");

            // Relacionamentos
            builder.HasOne(prop => prop.Paciente);
            builder.HasOne(prop => prop.Consulta);
        }
    }
}