using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class Precios : BaseDTO
    {
        public int idPrecios { get; set; }
        public int codBarra { get; set; }
        public decimal valor { get; set; }
        public decimal costo { get; set; }


    }
}
