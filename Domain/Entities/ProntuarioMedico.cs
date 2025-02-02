using Domain.Base;

namespace Domain.Entities
{
    public class ProntuarioMedico : BaseEntity<int>
    {
        public ProntuarioMedico() { }

        public ProntuarioMedico(int id, int pacienteId, int medicoId, DateTime dataHora,
                              string? descricao, string? prescricao) : base(id)
        {
            PacienteId = pacienteId;
            MedicoId = medicoId;
            DataHora = dataHora;
            Descricao = descricao;
            Prescricao = prescricao;
        }

        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public DateTime DataHora { get; set; }
        public string? Descricao { get; set; }
        public string? Prescricao { get; set; }

        // Relacionamentos
        public Paciente? Paciente { get; set; }
        public Medico? Medico { get; set; }
    }
}