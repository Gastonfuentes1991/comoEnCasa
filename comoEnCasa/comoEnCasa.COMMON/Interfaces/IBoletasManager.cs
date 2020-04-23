using comoEnCasa.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Interfaces
{
    /// <summary>
    /// Proporciona metodos relacionado con las boletas
    /// </summary>
    public interface IBoletasManager : IGenericManager<Boletas>
    {
        /// <summary>
        /// Trae todas las boletas de un mismo cliente
        /// </summary>
        /// <param name="Cuit">Id identificador del cliente que quiera consultar</param>
        /// <returns>Retorna las boletas del cliente requerido</returns>
        IEnumerable<Boletas> BoletasPorClientes(int Cuit);

    }
}
