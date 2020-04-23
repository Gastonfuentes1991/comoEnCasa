using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class StockProductos : BaseDTO
    {
        public int IdStockProducto { get; set; }
        public int CodBarra { get; set; }
        public short Cantidad { get; set; }
    }
}
