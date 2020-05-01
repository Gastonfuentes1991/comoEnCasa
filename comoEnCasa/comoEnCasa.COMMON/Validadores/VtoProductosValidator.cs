using comoEnCasa.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Validadores
{
    public class VtoProductosValidator:AbstractValidator<VtoProductos>
    {
        public VtoProductosValidator()
        {
            RuleFor(vp => vp.VtoCercano).NotNull().NotEmpty();//debe ser mayor a la fecha actual
        }
    }
}
