using Domain.Entities;
using FluentValidation;
using System;

namespace Domain.Validator
{
    public class ReporteValidator : AbstractValidator<Reporte>
    {
        public ReporteValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .NotEqual(new Guid());

            RuleFor(x => x.ReportName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(20)
                .Matches("/^[A-Za-z ]+$/");


        }
    }
}
