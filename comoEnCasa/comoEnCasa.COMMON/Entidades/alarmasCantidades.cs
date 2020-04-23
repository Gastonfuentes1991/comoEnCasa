using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class AlarmasCantidades : BaseDTO
    {
        public int IdAlarma { get; set; }
        public int IdStockProducto { get; set; }
        public byte CantMinima { get; set; }

    }
}
