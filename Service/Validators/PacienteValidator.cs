using FluentValidation;
using Domain.Entities;

namespace Service.Validators
{
    public class PacienteValidator : AbstractValidator<Paciente>
    {
        public PacienteValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.DataNascimento)
                .NotEmpty().WithMessage("Por favor informe a data de nascimento.")
                .NotNull().WithMessage("Por favor informe a data de nascimento.");

            RuleFor(c => c.Telefone)
                .NotEmpty().WithMessage("Por favor informe o telefone.")
                .NotNull().WithMessage("Por favor informe o telefone.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor informe o email.")
                .NotNull().WithMessage("Por favor informe o email.");
        }
    }
}