using Domain.Base;


namespace Domain.Entities
{
    public class Medico : BaseEntity<int>
    {
        public Medico()
        {
            Consultas = new List<Consulta>();
        }

        public Medico(int id, string? nome, string? crm, string? telefone, int especialidadeId) : base(id)
        {
            Nome = nome;
            CRM = crm;
            Telefone = telefone;
            EspecialidadeId = especialidadeId;
            Consultas = new List<Consulta>();
        }

        public string? Nome { get; set; }
        public string? CRM { get; set; }
        public string? Telefone { get; set; }
        public int EspecialidadeId { get; set; }

        // Relacionamento com Especialidade
        public Especialidade? Especialidade { get; set; }

        // Relacionamento com Consultas
        public ICollection<Consulta> Consultas { get; set; }
    }
}