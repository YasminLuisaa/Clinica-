namespace App.Models
{
    /// <summary>
    /// Representa o modelo de dados para a Consulta Médica.
    /// </summary>
    public class ConsultaModel
    {
        /// <summary>
        /// Identificador único da consulta.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador do paciente associado à consulta.
        /// </summary>
        public int IdPaciente { get; set; }

        /// <summary>
        /// Nome do paciente associado à consulta.
        /// </summary>
        public string? PacienteNome { get; set; }

        /// <summary>
        /// Identificador do médico responsável pela consulta.
        /// </summary>
        public int IdMedico { get; set; }

        /// <summary>
        /// Nome do médico responsável pela consulta.
        /// </summary>
        public string? MedicoNome { get; set; }

        /// <summary>
        /// Data e horário agendados para a consulta.
        /// </summary>
        public DateTime DataHora { get; set; }

        /// <summary>
        /// Observações ou anotações adicionais sobre a consulta.
        /// </summary>
        public string? Observacoes { get; set; }
    }
}