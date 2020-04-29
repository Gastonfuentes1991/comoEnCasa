using comoEnCasa.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Validadores
{
    public class AlarmasCantidadesValidator : AbstractValidator<AlarmasCantidades>
    {
        public AlarmasCantidadesValidator()
        {
            
            RuleFor(a => a.CantMinima).NotEmpty().NotNull().GreaterThan(0);
        }
    }
}
