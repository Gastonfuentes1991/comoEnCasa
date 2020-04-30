using comoEnCasa.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Validadores
{
    public class BoletasValidator:AbstractValidator<Boletas>
    {
        public BoletasValidator()
        {
            RuleFor(b => b.CantidadProd).NotNull().GreaterThanOrEqualTo((short)0);
            RuleFor(b => b.CostoUnitario).NotNull().NotEmpty().GreaterThan((double)0);
        }
    }
}
