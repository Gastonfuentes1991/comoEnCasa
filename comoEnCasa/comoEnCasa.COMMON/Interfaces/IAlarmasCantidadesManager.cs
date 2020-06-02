using comoEnCasa.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.COMMON.Interfaces
{
    /// <summary>
    /// Proporciona metodos relacionado a alarmas de productos
    /// </summary>
    public interface IAlarmasCantidadesManager: IGenericManager<AlarmasCantidades>
    {
        AlarmasCantidades CantidadProducto(string IdStockProducto, int stock);
        
    }
}
