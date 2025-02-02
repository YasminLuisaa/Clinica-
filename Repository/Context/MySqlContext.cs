using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Mapping;

namespace Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        // DbSets para todas as entidades
        public DbSet<Paciente>? Paciente { get; set; }
        public DbSet<Medico>? Medico { get; set; }
        public DbSet<Consulta>? Consulta { get; set; }
        public DbSet<ProntuarioMedico>? ProntuarioMedico { get; set; }
        public DbSet<Pagamento>? Pagamento { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplicando os mappings
            modelBuilder.Entity<Paciente>(new PacienteMap().Configure);
            modelBuilder.Entity<Medico>(new MedicoMap().Configure);
            modelBuilder.Entity<Consulta>(new ConsultaMap().Configure);
            modelBuilder.Entity<ProntuarioMedico>(new ProntuarioMedicoMap().Configure);
            modelBuilder.Entity<Pagamento>(new PagamentoMap().Configure);
        }
    }
}