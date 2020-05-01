using comoEnCasa.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Validadores
{
    public class StockProductosValidator:AbstractValidator<StockProductos>
    {
        public StockProductosValidator()
        {
            RuleFor(sp => sp.Cantidad).NotEmpty().NotNull().GreaterThan((short)0);
        }
    }
}
