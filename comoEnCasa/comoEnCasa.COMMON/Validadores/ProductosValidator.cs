using comoEnCasa.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Validadores
{
    public class ProductosValidator : AbstractValidator<Productos>
    {
        public ProductosValidator()
        {
            RuleFor(p => p.Nombre).NotEmpty().NotNull().MaximumLength(100).MinimumLength(3);
            RuleFor(p => p.Descripcion).NotNull().MaximumLength(240);
        }
    }
}
