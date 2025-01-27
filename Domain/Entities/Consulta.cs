using Domain.Base;
using Domain.Entities;

namespace Domain.Entities
{
    public class Consulta : BaseEntity<int>
    {
        public Consulta()
        {
        }

        public Consulta(int id, int pacienteId, int medicoId, DateTime dataHora, string? observacoes) : base(id)
        {
            PacienteId = pacienteId;
            MedicoId = medicoId;
            DataHora = dataHora;
            Observacoes = observacoes;
        }

        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public DateTime DataHora { get; set; }
        public string? Observacoes { get; set; }

        // Relacionamento com Paciente
        public Paciente? Paciente { get; set; }

        // Relacionamento com Médico
        public Medico? Medico { get; set; }
    }
}