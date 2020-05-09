using comoEnCasa.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace comoEnCasa.DAL.SQLSERVER
{
    class DBSqlServ : IDB
    {
        private SqlConnection conexion;

        public DBSqlServ()
        {
            string server = "";
            string database = "";
            string uid = "";
            string password = "";
            conexion = new SqlConnection(string.Format("SERVER={0};DATABASE={1}; UID={2};PASSWORD={3};SslMode= none;", server, database, uid, password));
            Conectar();
        }

        private bool Conectar()
        {
            try
            {
                conexion.Open();
                Error = "";
                return true;

            }
            catch(SqlException ex)
            {
                Error = ex.Message;
                return false;
            }
        }

        public string Error {get; private set;}

        public bool Comando(string command)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(command, conexion);
                cmd.ExecuteNonQuery();
                Error = "";
                return true;
            }
            catch(Exception ex)
            {
                Error = ex.Message;
                return false;                
            }
        }

        public object Consulta(string consulta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataReader dr = cmd.ExecuteReader();
                Error = "";
                return dr;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;

            }
        }
        ~DBSqlServ()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
