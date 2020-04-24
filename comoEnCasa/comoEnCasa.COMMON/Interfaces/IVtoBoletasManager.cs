using comoEnCasa.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Interfaces
{
    /// <summary>
    /// Proporciona los metodos relacionado a los vencimiento de las boletas
    /// </summary>
    public interface IVtoBoletasManager:IGenericManager<VtoBoletas>
    {
        /// <summary>
        /// Envia una notificacion Con las boletas que estan por vencimiento cercano
        /// </summary>
        /// <returns>Boletas vencimiento proximo</returns>
        IEnumerable<VtoBoletas> AlarmaVtoEnDiezDias();

        //IEnumerable<VtoBoletas> ();
    }
}
