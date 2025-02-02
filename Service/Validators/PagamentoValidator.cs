using FluentValidation;
using Domain.Entities;

namespace Service.Validators
{
    public class PagamentoValidator : AbstractValidator<Pagamento>
    {
        public PagamentoValidator()
        {
            RuleFor(c => c.PacienteId)
                .NotEmpty().WithMessage("Por favor informe o paciente.")
                .NotNull().WithMessage("Por favor informe o paciente.");

            RuleFor(c => c.ConsultaId)
                .NotEmpty().WithMessage("Por favor informe a consulta.")
                .NotNull().WithMessage("Por favor informe a consulta.");

            RuleFor(c => c.DataHora)
                .NotEmpty().WithMessage("Por favor informe a data e hora.")
                .NotNull().WithMessage("Por favor informe a data e hora.");

            RuleFor(c => c.Valor)
                .GreaterThan(0).WithMessage("O valor deve ser maior que zero.");

            RuleFor(c => c.MetodoPagamento)
                .NotEmpty().WithMessage("Por favor informe o método de pagamento.")
                .NotNull().WithMessage("Por favor informe o método de pagamento.");
        }
    }
}