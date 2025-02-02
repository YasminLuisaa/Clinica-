using FluentValidation;
using Domain.Entities;

namespace Service.Validators
{
    public class MedicoValidator : AbstractValidator<Medico>
    {
        public MedicoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.Especialidade)
                .NotEmpty().WithMessage("Por favor informe a especialidade.")
                .NotNull().WithMessage("Por favor informe a especialidade.");

            RuleFor(c => c.CRM)
                .NotEmpty().WithMessage("Por favor informe o CRM.")
                .NotNull().WithMessage("Por favor informe o CRM.");

            RuleFor(c => c.Telefone)
                .NotEmpty().WithMessage("Por favor informe o telefone.")
                .NotNull().WithMessage("Por favor informe o telefone.");
        }
    }
}