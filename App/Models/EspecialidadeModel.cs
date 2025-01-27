namespace App.Models
{
    /// <summary>
    /// Representa o modelo de dados para a Especialidade Médica.
    /// </summary>
    public class EspecialidadeModel
    {
        /// <summary>
        /// Identificador único da especialidade.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da especialidade médica (ex.: Cardiologia, Dermatologia).
        /// </summary>
        public string? Nome { get; set; }
    }
}