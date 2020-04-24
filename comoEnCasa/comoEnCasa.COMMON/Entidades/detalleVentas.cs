using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class DetalleVentas : BaseDTO
    {
        public int IdDetalle { get; set; }
        public int IdVenta { get; set; }
        public int CodBarra { get; set; }
        public decimal CostoVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorVenta { get; set; }
        public byte DescuentoProducto { get; set; }
    }
}
