using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class Telefonos : BaseDTO
    {
        public int IdTelefono { get; set; }
        public int CuitProveedor { get; set; }
        public int NumeroTelefono { get; set; }
    }
}
