using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Entidades
{
    public class Productos: BaseDTO
    {
        public int CodBarra { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
