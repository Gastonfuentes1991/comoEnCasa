using comoEnCasa.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Interfaces
{
    /// <summary>
    /// Proporciona los metodos relacionados con las ventas
    /// </summary>
    public interface IVentasManager:IGenericManager<Ventas>
    {
        /// <summary>
        /// Proporciona el listado de las ventas realizadas en el dia 
        /// </summary>
        /// <returns>todas las ventas que se realizaron</returns>
        IEnumerable<Ventas> VentasDiarias();
        /// <summary>
        /// Proporciona el listado de todas las ventas del periodo requerido
        /// </summary>
        /// <param name="FechaIni">Fecha inicial</param>
        /// <param name="FechaFin">Fecha final</param>
        /// <returns>Todas las ventas registradas en el periodo elejido</returns>
        IEnumerable<Ventas> VentasPeriodo(DateTime FechaIni, DateTime FechaFin);
        /// <summary>
        /// Proporciona la informacion del movimiento de dinero total en el dia de la fecha requerida
        /// </summary>
        /// <param name="FechaElejida"></param>
        /// <returns>Retorna valor bruto, costo y ganancias del dia que solicito</returns>
        Ventas BalanceFechaExacta(DateTime FechaElejida);

    }
}
