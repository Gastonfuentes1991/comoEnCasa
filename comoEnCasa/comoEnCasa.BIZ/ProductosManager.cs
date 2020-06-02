using comoEnCasa.COMMON.Entidades;
using comoEnCasa.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace comoEnCasa.BIZ
{
    public class ProductosManager : GenericManager<Productos>, IProductosManager
    {
        public ProductosManager(IGenericRepository<Productos> repositorio) : base(repositorio)
        {
        }

        public Productos BuscarProductoPorNombreExacto(string nombre)
        {
            return repository.Query(p => p.Nombre == nombre).SingleOrDefault();
            
        }

        public IEnumerable<Productos> BuscarProductosPorNombre(string criterio)
        {
            //ToLower convierte todo a minuscula para que Leche y leche o LeChE sean lo mismo = leche
            return repository.Query(p => p.Nombre.ToLower().Contains(criterio.ToLower()));
        }
    }
}
