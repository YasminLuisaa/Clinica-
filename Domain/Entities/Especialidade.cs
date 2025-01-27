using Domain.Base;

namespace Domain.Entities
{
    public class Especialidade : BaseEntity<int>
    {
        public Especialidade()
        {
            Medicos = new List<Medico>();
        }

        public Especialidade(int id, string? nome) : base(id)
        {
            Nome = nome;
            Medicos = new List<Medico>();
        }

        public string? Nome { get; set; }

        // Relacionamento com Médicos
        public ICollection<Medico> Medicos { get; set; }
    }
}