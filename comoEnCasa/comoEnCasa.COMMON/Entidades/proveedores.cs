using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class Proveedores : BaseDTO
    {
        public int CuitProveedor { get; set; }
        public string Nombre { get; set; }
        public string mail{ get; set; }
        public string Direccion { get; set; }
        public string info { get; set; }

    }
}
