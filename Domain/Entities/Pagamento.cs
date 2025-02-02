using Domain.Base;

namespace Domain.Entities
{
    public class Pagamento : BaseEntity<int>
    {
        public Pagamento() { }

        public Pagamento(int id, int pacienteId, int consultaId, DateTime dataHora,
                       decimal valor, string? metodoPagamento) : base(id)
        {
            PacienteId = pacienteId;
            ConsultaId = consultaId;
            DataHora = dataHora;
            Valor = valor;
            MetodoPagamento = metodoPagamento;
        }

        public int PacienteId { get; set; }
        public int ConsultaId { get; set; }
        public DateTime DataHora { get; set; }
        public decimal Valor { get; set; }
        public string? MetodoPagamento { get; set; }

        // Relacionamentos
        public Paciente? Paciente { get; set; }
        public Consulta? Consulta { get; set; }
    }
}