using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class Precios : BaseDTO
    {
        public int IdPrecios { get; set; }
        public int CodBarra { get; set; }
        public decimal Valor { get; set; }
        public decimal Costo { get; set; }


    }
}
