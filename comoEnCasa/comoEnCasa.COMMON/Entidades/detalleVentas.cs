using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class DetalleVentas : BaseDTO
    {
        public int idDetalle { get; set; }
        public int idVenta { get; set; }
        public int codBarra { get; set; }
        public decimal costoVenta { get; set; }
        public int cantidad { get; set; }
        public decimal valorVenta { get; set; }
    }
}
