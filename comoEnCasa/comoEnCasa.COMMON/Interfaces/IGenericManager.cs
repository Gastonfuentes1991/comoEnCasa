using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Interfaces
{
    /// <summary>
    /// Proporciona metodos estandarizados para el acceso a tablas; Cada manager creado debe implementar de esta interfase
    /// </summary>
    /// <typeparam name="T">Tipo de entidad de la cual se implementa el Manager</typeparam>
    public interface IGenericManager<T> where T: Entidades.BaseDTO
    {
        /// <summary>
        /// Proporcina el error relacionado despues de alguna operacion
        /// </summary>
        string Error { get; }
        /// <summary>
        /// Inserta una entidad en la tabla
        /// </summary>
        /// <param name="entidad">Entidad a insertar</param>
        /// <returns>Confirmacion de la Insercion</returns>
        bool Insertar(T entidad);
        /// <summary>
        /// Obtiene todos los registros de la tabla
        /// </summary>
        IEnumerable<T> ObtenerTodos { get; }
        /// <summary>
        /// Actualiza un registro en la tabla en base a su propiedad Id
        /// </summary>
        /// <param name="entidad">Entidad ya modificada, el Id debe existir en la tabla</param>
        /// <returns>Confirmacion de la actualizacion</returns>
        bool Actualizar(T entidad); 
        /// <summary>
        /// Elimina una entidad en base al Id proporcionado
        /// </summary>
        /// <param name="entidad">Id de la entidad a eliminar</param>
        /// <returns>Confirmacion de eliminacion</returns>
        bool Eliminar(string Id);
        /// <summary>
        /// Obtiene un elemento de acuerdo a su Id
        /// </summary>
        /// <param name="id">Id del elemento a obtener</param>
        /// <returns>Entidad completa correspondiente al Id proporcionado</returns>
        T BuscarPorId(string id);
    }
}
