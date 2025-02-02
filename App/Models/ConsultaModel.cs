namespace App.Models
{
    public class ConsultaModel
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public string? NomePaciente { get; set; } // Relacionamento com Paciente
        public int IdMedico { get; set; }
        public string? NomeMedico { get; set; } // Relacionamento com Medico
        public DateTime DataHora { get; set; }
        public string? Status { get; set; }
        public string? Motivo { get; set; }
    }
}