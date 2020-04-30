using comoEnCasa.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Validadores
{
    public class DetalleVentasValidator:AbstractValidator<DetalleVentas>
    {
        public DetalleVentasValidator()
        {
            RuleFor(dv => dv.CostoVenta).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(dv => dv.Cantidad).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(dv => dv.ValorVenta).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(dv => dv.DescuentoProducto).NotEmpty().NotNull().InclusiveBetween((byte)0,(byte)100);
        }
    }
}
