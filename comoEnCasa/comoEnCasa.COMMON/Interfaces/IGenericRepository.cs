using comoEnCasa.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace comoEnCasa.COMMON.Interfaces
{

    ///<summary>
    ///Proporciona metodos basicos (CRUD) de acceso a una tabla de base de datos
    ///</summary>
    ///<typeparam name="T">tiopo de entidad (Clase) a la que se refiere una tabla</typeparam>

    public interface IGenericRepository<T> where T:BaseDTO
    {
        /// <summary>
        /// proporciona informacion sobre el error ocurrido en alguna de las operaciones 
        /// </summary>

        string Error { get; }
        /*
         * CRUD => Create(insert), Read(select), Update(update), Delete(delete)
         */
        /// <summary>
        /// Inserta una entidad en la tabla
        /// </summary>
        /// <param name="entidad">Entidad a insertar</param>
        /// <returns>Confirmacion de la insercion</returns>
        bool Create(T entidad);
        /// <summary>
        /// Obtiene todos los registros de la tabla
        /// </summary>
        IEnumerable<T> Read { get; }
        /// <summary>
        /// Actualiza un registro en la tabla en base a la propiedad ID
        /// </summary>
        /// <param name="endidad">Entidad ya modificada, el Id debe existir en la tabla para modificarse</param>
        /// <returns>Confirmacion de la actualizacion</returns>
        bool Update(T endidad);
        /// <summary>
        /// Elimina una entidad en la base de datos deacuerdo al Id relacionado
        /// </summary>
        /// <param name="id">Id de la entidad a eliminar</param>
        /// <returns>Confirmacion de la eliminacion</returns>
        bool Delete(string id);

        //Query->Realizar consultas de acuerdo a la tabla, mediante expresiones lambda
        /// <summary>
        /// Realiza una consulta personalizada a la tabla
        /// </summary>
        /// <param name="predicado">Expresion lambda que defina la consulta</param>
        /// <returns>Conjunto de entidades que cumplen con la consulta</returns>
        IEnumerable<T> Query(Expression<Func<T, bool>> predicado);
        /// <summary>
        /// Obtener una entidad en base a su Id
        /// </summary>
        /// <param name="id">Id de la entidad a obtener</param>
        /// <returns>Entidad completa que le corresponde el Id proporcionado </returns>
        T SeachById(string id);

    }
}
