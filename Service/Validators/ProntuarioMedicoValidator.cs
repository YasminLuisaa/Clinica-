using FluentValidation;
using Domain.Entities;

namespace Service.Validators
{
    public class ProntuarioMedicoValidator : AbstractValidator<ProntuarioMedico>
    {
        public ProntuarioMedicoValidator()
        {
            RuleFor(c => c.PacienteId)
                .NotEmpty().WithMessage("Por favor informe o paciente.")
                .NotNull().WithMessage("Por favor informe o paciente.");

            RuleFor(c => c.MedicoId)
                .NotEmpty().WithMessage("Por favor informe o médico.")
                .NotNull().WithMessage("Por favor informe o médico.");

            RuleFor(c => c.DataHora)
                .NotEmpty().WithMessage("Por favor informe a data e hora.")
                .NotNull().WithMessage("Por favor informe a data e hora.");

            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Por favor informe a descrição.")
                .NotNull().WithMessage("Por favor informe a descrição.");
        }
    }
}