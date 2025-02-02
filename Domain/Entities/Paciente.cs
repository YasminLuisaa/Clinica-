using Domain.Base;

namespace Domain.Entities
{
    public class Paciente : BaseEntity<int>
    {
        public Paciente() { }

        public Paciente(int id, string? nome, DateTime dataNascimento, string? endereco,
                      string? telefone, string? email) : base(id)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }

        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }

        // Relacionamentos
        public ICollection<Consulta>? Consultas { get; set; }
        public ICollection<ProntuarioMedico>? ProntuariosMedicos { get; set; }
        public ICollection<Pagamento>? Pagamentos { get; set; }
    }
}