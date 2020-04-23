using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class Productos: BaseDTO
    {
        public int codBarra { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }
}
