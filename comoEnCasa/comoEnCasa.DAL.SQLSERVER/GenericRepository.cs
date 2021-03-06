﻿using comoEnCasa.COMMON.Entidades;
using comoEnCasa.COMMON.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
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

        public IEnumerable<T> Read
        {
            get
            {
                try
                {
                    string sql = string.Format("SELECT * FROM {0}", typeof(T).Name);
                    SqlDataReader r = (SqlDataReader)db.Consulta(sql);
                    List<T> datos = new List<T>();
                    var campos = typeof(T).GetProperties();
                    T dato;
                    Type Ttypo = typeof(T);
                    while (r.Read())
                    {
                        dato = (T)Activator.CreateInstance(typeof(T));
                        for (int i = 0; i < campos.Length; i++)
                        {
                            PropertyInfo prop = Ttypo.GetProperty(campos[i].Name);
                            prop.SetValue(dato, r[i]);
                        }
                        datos.Add(dato);
                    }
                    r.Close();
                    Error = "";
                    return datos;
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    return null;
                }
            }
        }


        public bool Create(T entidad)
        {
            ValidationResult resultadoDeValidacion = validator.Validate(entidad);
            if (resultadoDeValidacion.IsValid)
            {
                string sql1 = "INSERT INTO " + typeof(T).Name + " (";
                string sql2 = ") VALUES (";
                var campos = typeof(T).GetProperties();
                T dato = (T)Activator.CreateInstance(typeof(T));
                Type Ttypo = typeof(T);
                for (int i = 0; i < campos.Length; i++)
                {
                    if (idEsAutonumerico && i == 0)
                    {
                        continue;
                    }
                    sql1 += " " + campos[i].Name;
                    var propiedad = Ttypo.GetProperty(campos[i].Name);
                    var valor = propiedad.GetValue(entidad);
                    switch (propiedad.PropertyType.Name)
                    {
                        case "String":
                            sql2 += "'" + valor + "'";
                            break;
                        case "DateTime":
                            DateTime v = (DateTime)valor;
                            sql2 += string.Format($"convert(datetime,'{v.Year.ToString().Substring(2,2)}/{v.Month}/{v.Day} {v.Hour}:{v.Minute}:{v.Second}',5)");
                            break;
                        default:
                            sql2 += " " + valor;
                            break;
                    }
                    if (i != campos.Length - 1)
                    {
                        sql1 += " ,";
                        sql2 += " ,";
                    }
                }
                return EjecutaComando(sql1 + sql2 + ");");
            }
            else
            {
                Error = "Error de validación:";
                foreach (var item in resultadoDeValidacion.Errors)
                {
                    Error += item.ErrorMessage + ". ";
                }
                return false;
            }
        }

        private bool EjecutaComando(string sql)
        {
            if (db.Comando(sql))
            {
                Error = "";
                return true;
            }
            else
            {
                Error = db.Error;
                return false;
            }
        }

        public bool Delete(string id)
        {
            try
            {
                var campos = typeof(T).GetProperties();
                Type Ttypo = typeof(T);
                string sql = "DELETE FROM " + typeof(T).Name + " WHERE " + campos[0].Name + "=";
                switch (Ttypo.GetProperty(campos[0].Name).PropertyType.Name)
                {
                    case "String":
                        sql += "'" + id + "'";
                        break;
                    default:
                        sql += " " + id;
                        break;
                }
                if (db.Comando(sql + ";"))
                {
                    Error = "";
                    return true;
                }
                else
                {
                    Error = db.Error;
                    return false;
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;

            }
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> predicado)
        {
            try
            {
                Error = "";
                return Read.Where(predicado.Compile());
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }

        public T SeachById(string id)
        {
            try
            {
                var campos = typeof(T).GetProperties();
                Type Ttypo = typeof(T);
                string sql = "SELECT * FROM " + typeof(T).Name + " WHERE " + campos[0].Name + "=";
                switch (Ttypo.GetProperty(campos[0].Name).PropertyType.Name)
                {
                    case "String":
                        sql += "'" + id + "'";
                        break;
                    default:
                        sql += " " + id;
                        break;
                }
                SqlDataReader r = (SqlDataReader)db.Consulta(sql);
                T dato = (T)Activator.CreateInstance(typeof(T));
                int j = 0;
                while (r.Read())
                {
                    dato = (T)Activator.CreateInstance(typeof(T));
                    for (int i = 0; i < campos.Length; i++)
                    {
                        PropertyInfo prop = Ttypo.GetProperty(campos[i].Name);
                        prop.SetValue(dato, r[i]);
                    }
                    j++;
                }
                r.Close();
                if (j > 0)
                {
                    Error = "";
                    return dato;
                }
                else
                {
                    Error = "Id no existente...";
                    return null;
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }

        public bool Update(T entidad)
        {
            try
            {

                string sql1 = "UPDATE " + typeof(T).Name + " SET ";
                string sql2 = " WHERE ";
                string sql = "";
                var campos = typeof(T).GetProperties();
                T dato = (T)Activator.CreateInstance(typeof(T));
                Type Ttypo = typeof(T);
                for (int i = 0; i < campos.Length; i++)
                {
                    var propiedad = Ttypo.GetProperty(campos[i].Name);
                    var valor = propiedad.GetValue(entidad);
                    sql += propiedad.Name + "=";
                    switch (propiedad.PropertyType.Name)
                    {
                        case "String":
                            sql += "'" + valor + "'";
                            break;
                        case "DateTime":
                            DateTime v = (DateTime)valor;
                            sql += string.Format($"convert(datetime,'{v.Year.ToString().Substring(2, 2)}/{v.Month}/{v.Day} {v.Hour}:{v.Minute}:{v.Second}',5)");
                            break;
                        default:
                            sql += " " + valor;
                            break;
                    }
                    if (i == 0)
                    {
                        sql2 += sql;
                    }
                    if (i != campos.Length - 1)
                    {
                        sql += " ,";
                    }
                    sql1 += sql;
                    sql = "";

                }
                if (db.Comando(sql1 + sql2))
                {
                    Error = "";
                    return true;
                }
                else
                {
                    Error = db.Error;
                    return false;
                }
            }
            catch (Exception ex)
            {

                Error = ex.Message;
                return false;
            }
        }
    }
}
