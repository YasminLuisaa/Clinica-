namespace App.Models
{
    /// <summary>
    /// Representa o modelo de dados para o Médico.
    /// </summary>
    public class MedicoModel
    {
        /// <summary>
        /// Identificador único do médico.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome completo do médico.
        /// </summary>
        public string? Nome { get; set; }

        /// <summary>
        /// Número do Conselho Regional de Medicina (CRM).
        /// </summary>
        public string? CRM { get; set; }

        /// <summary>
        /// Número de telefone para contato.
        /// </summary>
        public string? Telefone { get; set; }

        /// <summary>
        /// Identificador da especialidade médica do médico.
        /// </summary>
        public int IdEspecialidade { get; set; }

        /// <summary>
        /// Nome da especialidade médica.
        /// </summary>
        public string? EspecialidadeNome { get; set; }
    }
}