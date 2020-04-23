using comoEnCasa.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Interfaces
{
    /// <summary>
    /// Proporciona metodos relacionados a los detalles de ventas
    /// </summary>
    interface IDetalleVentasManager:IGenericManager<DetalleVentas>
    {
        /// <summary>
        /// Muestra los productos relacionados a la venta solicitada
        /// </summary>
        /// <param name="idVenta">Id de la venta a la cual se refiere</param>
        /// <returns>Listado de produtos con el id de venta requerido</returns>
        IEnumerable<DetalleVentas> MostrarProductoVenta(int idVenta);
        /// <summary>
        /// Muestra la cantidad vendida del producto 
        /// </summary>
        /// <param name="CodBarra">Id del producto que desea saber la informacion</param>
        /// <returns>listado de las ventas del producto</returns>
        IEnumerable<DetalleVentas> VentaCantProducto(int CodBarra);
        /// <summary>
        /// Muestra la cantidad vendida de un producto en un intervalo definido de tiempo
        /// </summary>
        /// <param name="CodBarra">Id del producto requerido</param>
        /// <param name="Inicio">Fecha inicial del rango</param>
        /// <param name="fin">Fecha final del rango</param>
        /// <returns>Listado con todas las ventas del producto</returns>
        IEnumerable<DetalleVentas> VentaCantProductoIntervalo (int CodBarra, DateTime Inicio, DateTime fin);
    }
}
