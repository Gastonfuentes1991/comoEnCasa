using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class Boletas : BaseDTO
    {
        public int NroBoleta { get; set; }
        public int CodBarra { get; set; }
        public short CuitProveedor { get; set; }
    }
}
