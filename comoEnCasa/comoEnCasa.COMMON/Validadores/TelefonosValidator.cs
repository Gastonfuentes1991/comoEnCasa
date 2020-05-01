using comoEnCasa.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Validadores
{
    public class TelefonosValidator:AbstractValidator<Telefonos>
    {
        public TelefonosValidator()
        {
            RuleFor(t => t.NumeroTelefono).NotNull().MinimumLength(7).MaximumLength(20);
        }
    }
}
