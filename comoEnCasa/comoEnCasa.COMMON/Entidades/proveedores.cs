using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class Proveedores : BaseDTO
    {
        public int CuitProveedor { get; set; }
        public string Nombre { get; set; }
        public string Mail{ get; set; }
        public string Direccion { get; set; }
        public string Info { get; set; }

    }
}
