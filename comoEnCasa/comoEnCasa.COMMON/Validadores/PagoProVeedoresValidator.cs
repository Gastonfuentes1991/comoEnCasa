using comoEnCasa.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Validadores
{
    public class PagoProveedoresValidator:AbstractValidator<PagoProveedores>
    {
        public PagoProveedoresValidator()
        {
            RuleFor(pp => pp.Total).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(pp => pp.Entrega).NotEmpty().GreaterThan(0);
            RuleFor(pp => pp.Pagado).NotEmpty().NotNull();
        }
    }
}
