using comoEnCasa.COMMON.Entidades;
using comoEnCasa.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.BIZ
{
    public class AlarmasCantidadesManager : GenericManager<AlarmasCantidades>, IAlarmasCantidadesManager
    {
        public AlarmasCantidadesManager(IGenericRepository<AlarmasCantidades> repositorio) : base(repositorio)
        {
        }

        public AlarmasCantidades CantidadProducto(string IdStockProducto, int stock)
        {
            return null;
        }
    }
}
