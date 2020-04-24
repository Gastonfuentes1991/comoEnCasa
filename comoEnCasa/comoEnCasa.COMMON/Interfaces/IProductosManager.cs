using comoEnCasa.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Interfaces
{
    /// <summary>
    /// Proporcionara los metodos relacionados a los productos
    /// </summary>
    public interface IProductosManager:IGenericManager<Productos>
    {
        IEnumerable<Productos> BuscarProductosPorNombre(string criterio);

        Productos BuscarProductoPorNombreExacto(string nombre);
    }
}
