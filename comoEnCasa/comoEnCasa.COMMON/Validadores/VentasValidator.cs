using comoEnCasa.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Validadores
{
    public class VentasValidator:AbstractValidator<Ventas>
    {
        public VentasValidator()
        {
            RuleFor(v => v.FechaVenta).NotEmpty().NotNull();
            RuleFor(v => v.ValorTotalVenta).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(v => v.DescuentoVenta).NotEmpty().NotNull().InclusiveBetween((byte)0, (byte)100);
        }
    }
}
