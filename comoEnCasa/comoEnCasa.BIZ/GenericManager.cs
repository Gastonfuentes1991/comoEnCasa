using comoEnCasa.COMMON.Entidades;
using comoEnCasa.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace comoEnCasa.BIZ
{
    public abstract class GenericManager<T> : IGenericManager<T> where T : BaseDTO
    {
        internal IGenericRepository<T> repository;
        public GenericManager(IGenericRepository<T> repositorio)
        {
            repository = repositorio;
        }
        public string Error { get
            {
                return repository.Error;
            }
        }

        public IEnumerable<T> ObtenerTodos
        {
            get
            {
                
                    return repository.Read;
                
            }

        }

        public bool Actualizar(T entidad)
        {
           return repository.Update(entidad);
               
        }

        public T BuscarPorId(string id)
        {
            return repository.SeachById(id);
                
        }

        public bool Eliminar(string Id)
        {
            return repository.Delete(Id);
                
        }

        public bool Insertar(T entidad)
        {
           return repository.Create(entidad);
            
        }
    }
}
