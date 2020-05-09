using comoEnCasa.COMMON.Entidades;
using comoEnCasa.COMMON.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace comoEnCasa.DAL.SQLSERVER
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseDTO
    {

        private DBSqlServ db;
        private bool idEsAutonumerico;
        private AbstractValidator<T> validator;
        public GenericRepository(AbstractValidator<T> validator, bool idEsAutonumerico = true)
        {
            this.validator = validator;
            this.idEsAutonumerico = idEsAutonumerico;
            db = new DBSqlServ();
        }

        public string Error { get; private set; }

        public IEnumerable<T> Read => throw new NotImplementedException();

        public bool Create(T entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public T SeachById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(T endidad)
        {
            throw new NotImplementedException();
        }
    }
}
