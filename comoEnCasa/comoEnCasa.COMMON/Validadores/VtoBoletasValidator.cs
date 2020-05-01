using comoEnCasa.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Validadores
{
    public class VtoBoletasValidator:AbstractValidator<VtoBoletas>
    {
        public VtoBoletasValidator()
        {
            RuleFor(vb => vb.FechaEmision).NotEmpty().NotNull();// no puede ser mayor a la fecha actual
            RuleFor(vb => vb.FechaVto).NotEmpty().NotNull().GreaterThan(vb => vb.FechaEmision);
        }
    }
}
