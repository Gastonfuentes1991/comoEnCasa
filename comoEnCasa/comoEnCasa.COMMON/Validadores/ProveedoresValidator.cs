using comoEnCasa.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Validadores
{
    public class ProveedoresValidator:AbstractValidator<Proveedores>
    {
        public ProveedoresValidator()
        {
            RuleFor(p => p.CuitProveedor).NotEmpty().NotNull().Length(11);
            RuleFor(p => p.Nombre).NotEmpty().NotNull().MaximumLength(40).MinimumLength(2);
            RuleFor(p => p.Mail).NotNull().EmailAddress();
            RuleFor(p => p.Direccion).NotNull().MaximumLength(240);
            RuleFor(p => p.Info).NotNull().MaximumLength(300);

        }
    }
}
