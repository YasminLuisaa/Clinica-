namespace App.Models
{
    /// <summary>
    /// Representa o modelo de dados para o Paciente.
    /// </summary>
    public class PacienteModel
    {
        /// <summary>
        /// Identificador único do paciente.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome completo do paciente.
        /// </summary>
        public string? Nome { get; set; }

        /// <summary>
        /// Data de nascimento do paciente.
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Endereço residencial do paciente.
        /// </summary>
        public string? Endereco { get; set; }

        /// <summary>
        /// Número de telefone para contato.
        /// </summary>
        public string? Telefone { get; set; }

        /// <summary>
        /// Identificador da cidade associada ao paciente.
        /// </summary>
        public int IdCidade { get; set; }

        /// <summary>
        /// Nome da cidade associada ao paciente.
        /// </summary>
        public string? CidadeNome { get; set; }
    }
}