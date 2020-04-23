using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class VtoProductos : BaseDTO
    {
        public int IdVtoPrd { get; set; }
        public int CodBarra { get; set; }
        public DateTime VtoCercano { get; set; }
    }
}
