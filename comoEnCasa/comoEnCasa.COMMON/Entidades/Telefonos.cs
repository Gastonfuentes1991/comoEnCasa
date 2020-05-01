using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class Telefonos : BaseDTO
    {
        public int IdTelefono { get; set; }
        public string CuitProveedor { get; set; }
        public string NumeroTelefono { get; set; }
    }
}
