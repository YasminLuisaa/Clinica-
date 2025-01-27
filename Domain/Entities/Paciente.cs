using Domain.Base;
using Domain.Entities;


namespace Domain.Entities
{
    public class Paciente : BaseEntity<int>
    {
        public Paciente()
        {
            Consultas = new List<Consulta>();
        }

        public Paciente(int id, string? nome, DateTime dataNascimento, string? endereco, string? telefone) : base(id)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefone = telefone;
            Consultas = new List<Consulta>();
        }

        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }

        // Relacionamento com Consultas
        public ICollection<Consulta> Consultas { get; set; }
    }
}