using Domain.Entities;
using FluentValidation;

namespace Service.Validators
{
    public class PacienteValidator : AbstractValidator<Paciente>
    {
        public PacienteValidator()
        {
            // Validação para o Nome do Paciente
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome do paciente.")
                .NotNull().WithMessage("Por favor, informe o nome do paciente.");

            // Validação para a Data de Nascimento
            RuleFor(p => p.DataNascimento)
                .NotEmpty().WithMessage("Por favor, informe a data de nascimento do paciente.")
                .NotNull().WithMessage("Por favor, informe a data de nascimento do paciente.");

            // Validação para o Endereço
            RuleFor(p => p.Endereco)
                .NotEmpty().WithMessage("Por favor, informe o endereço do paciente.")
                .NotNull().WithMessage("Por favor, informe o endereço do paciente.");

            // Validação para o Telefone
            RuleFor(p => p.Telefone)
                .NotEmpty().WithMessage("Por favor, informe o telefone do paciente.")
                .NotNull().WithMessage("Por favor, informe o telefone do paciente.");
        }
    }
}