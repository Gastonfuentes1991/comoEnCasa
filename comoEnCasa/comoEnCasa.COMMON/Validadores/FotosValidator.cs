using comoEnCasa.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Validadores
{
    class FotosValidator:AbstractValidator<Fotos>
    {
        public FotosValidator()
        {
            RuleFor(f => f.Url).NotEmpty().NotNull();
        }
    }
}
