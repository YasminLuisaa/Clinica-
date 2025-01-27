using Domain.Entities;
using FluentValidation;

namespace Service.Validators
{
    public class ConsultaValidator : AbstractValidator<Consulta>
    {
        public ConsultaValidator()
        {
            // Validação para o PacienteId
            RuleFor(c => c.PacienteId)
                .NotEmpty().WithMessage("Por favor, selecione o paciente para a consulta.")
                .NotNull().WithMessage("Por favor, selecione o paciente para a consulta.");

            // Validação para o MedicoId
            RuleFor(c => c.MedicoId)
                .NotEmpty().WithMessage("Por favor, selecione o médico para a consulta.")
                .NotNull().WithMessage("Por favor, selecione o médico para a consulta.");

            // Validação para a Data e Hora da Consulta
            RuleFor(c => c.DataHora)
                .NotEmpty().WithMessage("Por favor, informe a data e horário da consulta.")
                .NotNull().WithMessage("Por favor, informe a data e horário da consulta.")
                .Must(BeAValidDate).WithMessage("Por favor, informe uma data e horário válidos.");

            // Validação para as Observações (opcional, mas limitado a 500 caracteres)
            RuleFor(c => c.Observacoes)
                .MaximumLength(500).WithMessage("As observações não podem exceder 500 caracteres.")
                .When(c => !string.IsNullOrEmpty(c.Observacoes));
        }

        // Método auxiliar para validar a data e hora
        private bool BeAValidDate(DateTime date)
        {
            return date > DateTime.Now;
        }
    }
}