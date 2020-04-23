using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class Ventas : BaseDTO
    {
        public int idVenta { get; set; }
        public DateTime fechaVenta { get; set; }
        public decimal valorTotalVenta { get; set; }

    }
}
