using Domain.Base;

namespace Domain.Entities
{
    public class Medico : BaseEntity<int>
    {
        public Medico() { }

        public Medico(int id, string? nome, string? especialidade, string? crm,
                    string? telefone, string? email) : base(id)
        {
            Nome = nome;
            Especialidade = especialidade;
            CRM = crm;
            Telefone = telefone;
            Email = email;
        }

        public string? Nome { get; set; }
        public string? Especialidade { get; set; }
        public string? CRM { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }

        // Relacionamentos
        public ICollection<Consulta>? Consultas { get; set; }
        public ICollection<ProntuarioMedico>? ProntuariosMedicos { get; set; }
    }
}