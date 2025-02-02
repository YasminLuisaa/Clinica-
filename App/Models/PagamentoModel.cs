namespace App.Models
{
    public class PagamentoModel
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public string? NomePaciente { get; set; } // Relacionamento com Paciente
        public int IdConsulta { get; set; }
        public DateTime DataHoraConsulta { get; set; } // Relacionamento com Consulta
        public DateTime DataHoraPagamento { get; set; }
        public decimal Valor { get; set; }
        public string? MetodoPagamento { get; set; }
    }
}