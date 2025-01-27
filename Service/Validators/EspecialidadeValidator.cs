using Domain.Entities;
using FluentValidation;

namespace Service.Validators
{
    public class EspecialidadeValidator : AbstractValidator<Especialidade>
    {
        public EspecialidadeValidator()
        {
            // Validação para o Nome da Especialidade
            RuleFor(e => e.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome da especialidade.")
                .NotNull().WithMessage("Por favor, informe o nome da especialidade.")
                .MaximumLength(100).WithMessage("O nome da especialidade não pode exceder 100 caracteres.");
        }
    }
}