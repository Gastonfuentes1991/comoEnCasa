using System;
using System.Linq;
using comoEnCasa.COMMON.Entidades;
using comoEnCasa.COMMON.Interfaces;
using comoEnCasa.COMMON.Validadores;
using comoEnCasa.DAL.SQLSERVER;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace comoEnCasa.Test
{
    [TestClass]
    public class UnitTestDAL
    {
        IGenericRepository<Productos> productosRepository;
        Random r;
        public UnitTestDAL()
        {
            r = new Random();
            productosRepository = new GenericRepository<Productos>(new ProductosValidator()); 

        }
        [TestMethod]
        public void TestMethodProductos()
        {
            Productos p = CrearProductoDePrueba();
            int cantidadProductos = productosRepository.Read.Count();
            Assert.IsTrue(productosRepository.Create(p),productosRepository.Error);
            Assert.AreEqual(cantidadProductos + 1, productosRepository.Read.Count(),"No se inserto el registro");
            int ultimoId = productosRepository.Read.Max(j => j.CodBarra);
            
        }

        private Productos CrearProductoDePrueba()
        {
            return new Productos()
            {
                Nombre = "Producto de prueba " + r.Next(),
                Descripcion = "Informacion producto y  " + r.Next() 

            };
        }
    }
}
