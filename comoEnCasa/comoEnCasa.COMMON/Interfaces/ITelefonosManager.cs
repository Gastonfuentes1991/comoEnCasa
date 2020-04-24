using comoEnCasa.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Interfaces
{
    /// <summary>
    /// Proporcionara los metodos relacionado con los telefonos
    /// </summary>
    public interface ITelefonosManager:IGenericManager<Telefonos>
    {
        /// <summary>
        /// Proporcionara los numeros de telefonos de los clientes que cumplan el criterio
        /// </summary>
        /// <param name="criterio">Nombre parcial del cliente</param>
        /// <returns>Telefonos de clientes que su nombre coincida con el criterio</returns>
        IEnumerable<Telefonos> ObtenerTelefonosPorNombre(string criterio);
    }
}
