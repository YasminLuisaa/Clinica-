using Domain.Entities;
using FluentValidation;

namespace Service.Validators
{
    public class MedicoValidator : AbstractValidator<Medico>
    {
        public MedicoValidator()
        {
            // Validação para o Nome do Médico
            RuleFor(m => m.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome do médico.")
                .NotNull().WithMessage("Por favor, informe o nome do médico.");

            // Validação para o CRM
            RuleFor(m => m.CRM)
                .NotEmpty().WithMessage("Por favor, informe o CRM do médico.")
                .NotNull().WithMessage("Por favor, informe o CRM do médico.");

            // Validação para o Telefone
            RuleFor(m => m.Telefone)
                .NotEmpty().WithMessage("Por favor, informe o telefone do médico.")
                .NotNull().WithMessage("Por favor, informe o telefone do médico.");

            // Validação para o EspecialidadeId
            RuleFor(m => m.EspecialidadeId)
                .NotEmpty().WithMessage("Por favor, selecione a especialidade do médico.")
                .NotNull().WithMessage("Por favor, selecione a especialidade do médico.");
        }
    }
}