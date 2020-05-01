using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class Ventas : BaseDTO
    {
        public int IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal ValorTotalVenta { get; set; }
        public byte DescuentoVenta { get; set; }
    }
}
