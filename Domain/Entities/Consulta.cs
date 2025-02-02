using Domain.Base;

namespace Domain.Entities
{
    public class Consulta : BaseEntity<int>
    {
        public Consulta() { }

        public Consulta(int id, int pacienteId, int medicoId, DateTime dataHora,
                      string? status, string? motivo) : base(id)
        {
            PacienteId = pacienteId;
            MedicoId = medicoId;
            DataHora = dataHora;
            Status = status;
            Motivo = motivo;
        }

        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public DateTime DataHora { get; set; }
        public string? Status { get; set; }
        public string? Motivo { get; set; }

        // Relacionamentos
        public Paciente? Paciente { get; set; }
        public Medico? Medico { get; set; }
        public Pagamento? Pagamento { get; set; }
    }
}