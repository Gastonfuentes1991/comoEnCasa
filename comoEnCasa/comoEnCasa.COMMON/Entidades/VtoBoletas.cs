using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class VtoBoletas: BaseDTO
    {
        public int IdVtoBoleta { get; set; }
        public int NroBoleta { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVto { get; set; }
    }
}
