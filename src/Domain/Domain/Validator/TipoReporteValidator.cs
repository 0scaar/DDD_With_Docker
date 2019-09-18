using Domain.Entities;
using FluentValidation;
using System;

namespace Domain.Validator
{
    public class TipoReporteValidator : AbstractValidator<TipoReporte>
    {
        public TipoReporteValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .NotEqual(new Guid());

            RuleFor(x => x.Tipo)
                .NotEmpty().WithMessage(x => $"O campo {x.Tipo} não pode ser vazio")
                .NotNull().WithMessage(x => $"O campo {x.Tipo} não pode ser nulo")
                .Length(0, 20).WithMessage(x => $"O campo {x.Tipo} só pode ter como máximo 20 carateres")
                .Matches("/^[A-Za-z ]+$/").WithMessage(x => $"O campo {x.Tipo} só pode ter letras e espaços");
        }
    }
}
