using comoEnCasa.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Interfaces
{
    /// <summary>
    /// Proporciona los metodos relacionados a los precios
    /// </summary>
    public interface IPreciosManager: IGenericManager<Precios>
    {
        /// <summary>
        /// Trea los precios en el rango seleccionado
        /// </summary>
        /// <param name="PrecioMin">Inicio del rango</param>
        /// <param name="PrecioMax">fin del rango</param>
        /// <returns>Retorna todos los productos en el rango de precio deseado</returns>
        IEnumerable<Precios> RangosPrecio(double PrecioMin, double PrecioMax);
    }
}
