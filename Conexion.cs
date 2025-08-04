using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string User;
        private string Password;

        private bool Seguridad;

        private static Conexion conn = null;

        /*private Conexion() 
        {
            this.Base = "dbProyectoPOO";
            this.Servidor = "LAPTOP-25NG5QK6";
            this.User = "sa";
            this.Password = "123";
            this.Seguridad = true;
        }*/

        private Conexion()
        {
            this.Base = "dbProyectoPOO";
            this.Servidor = "DESKTOP-06SSARM\\MSSQLSERVER01";
            this.User = "sa";
            this.Password = "123";
            this.Seguridad = true;
        }

        public SqlConnection crearConexion()
        {
            SqlConnection stringConn = new SqlConnection();
            try
            {
                stringConn.ConnectionString = "Server = " + this.Servidor + "; Database = " + this.Base + ";";

                if (this.Seguridad)
                {
                    stringConn.ConnectionString = stringConn.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    stringConn.ConnectionString = stringConn.ConnectionString + "User Id = " + this.User + "; Password = " + this.Password;
                }

            }
            catch (Exception ex) 
            {
                stringConn = null;
                throw ex;
            }

            return stringConn;
        }

        public static Conexion crearInstancia()
        {
            if (conn == null)
            {
                conn = new Conexion();
            }

            return conn;
        }
    }
}
