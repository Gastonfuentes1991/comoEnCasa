using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class PagoProveedores : BaseDTO
    {
        public int IdPagosProv { get; set; }
        public int NroBoleta { get; set; }
        public decimal Deuda { get; set; }
        public decimal Pagado { get; set; }
    }
}
