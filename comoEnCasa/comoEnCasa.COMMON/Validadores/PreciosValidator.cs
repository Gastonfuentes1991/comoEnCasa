using comoEnCasa.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Validadores
{
    class PreciosValidator : AbstractValidator<Precios>
    {
        public PreciosValidator()
        {
            RuleFor(p => p.Valor).NotEmpty().NotNull().GreaterThan(p => p.Costo);
            RuleFor(p => p.Costo).NotEmpty().NotNull().GreaterThan(0);
        }
    }
}
