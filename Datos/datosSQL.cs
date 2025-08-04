using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Datos
{
    public class datosSQL
    {
        public string InsertaMarca(Marca obj)
        {
            string respuesta = "";
            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = "Insert Into tblMarcas(intMarca, strNombre, intActivo) Values(" +
                             "'" + obj.MarcaID + "', " +
                             "'" + obj.Nombre + "', " +
                             "'" + obj.Activo + "')";

                conn = Conexion.crearInstancia().crearConexion();

                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    respuesta = "OK";
                }
                else
                {
                    respuesta = "No se pudo registrar la información.";
                }

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return respuesta;
        }
        public DataTable ListarMarcas(string comando)
        {
            SqlDataReader lista;
            DataTable dtTabla = new DataTable();

            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = comando;

                //string sql = "Select intMarca as Marca, strNombre as Nombre from tblMarcas";
                conn = Conexion.crearInstancia().crearConexion();

                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();

                lista = command.ExecuteReader();

                dtTabla.Load(lista);
                return dtTabla;
            }
            catch (Exception ex) 
            {
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
        }

        public DataTable BuscarMarcas(string marca)
        {
            SqlDataReader lista;
            DataTable dtTabla = new DataTable();

            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = "Select * From tblMarcas Where strNombre Like '%" + marca + "%' Or intMarca Like '%" + marca + "%'";
                conn = Conexion.crearInstancia().crearConexion();

                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();

                lista = command.ExecuteReader();

                dtTabla.Load(lista);
                return dtTabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public string InsertaSucursal(Sucursal obj)
        {
            string respuesta = "";
            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = "Insert Into tblSucursales(intSucursal, strNombre, intActivo) Values(" +
                             "'" + obj.SucursalID + "', " +
                             "'" + obj.Nombre + "', " +
                             "'" + obj.Activo + "')";

                conn =  Conexion.crearInstancia().crearConexion();

                SqlCommand command = new SqlCommand (sql, conn);
                conn.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    respuesta = "OK";
                }
                else
                {
                    respuesta = "No se pudo registrar la información.";
                }

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return respuesta;
        }

        public DataTable ListarSucursal(string comando)
        {
            SqlDataReader lista;
            DataTable dtTabla = new DataTable();

            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = comando;
                //string sql = "Select intSucursal as Sucursal, strNombre as Nombre from tblSucursales";
                conn = Conexion.crearInstancia().crearConexion();

                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();

                lista = command.ExecuteReader();

                dtTabla.Load(lista);
                return dtTabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public DataTable BuscaSucursal(string sucursal)
        {
            SqlDataReader lista;
            DataTable dtTabla = new DataTable();

            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = "Select * From tblSucursales Where intSucursal LIKE '%" + sucursal +"%' or strNombre LIKE '%"+sucursal+"%'";
                conn = Conexion.crearInstancia().crearConexion();

                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();

                lista = command.ExecuteReader();

                dtTabla.Load(lista);
                return dtTabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public string InsertaProveedor(Proveedor obj)
        {
            string respuesta = "";
            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = "Insert Into tblProveedores(intProveedor, strNombre, intActivo) Values(" +
                             "'" + obj.ProveedorID + "', " +
                             "'" + obj.Nombre + "', " +
                             "'" + obj.Activo + "')";

                conn = Conexion.crearInstancia().crearConexion();

                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    respuesta = "OK";
                }
                else
                {
                    respuesta = "No se pudo registrar la información.";
                }

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return respuesta;
        }
        public DataTable BuscaProveedor(string Proveedor)
        {
            SqlDataReader lista;
            DataTable dtTabla = new DataTable();

            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = "Select * From tblProveedores Where intProveedor LIKE '" + Proveedor + "%' OR strNombre Like '%" + Proveedor + "%'";
                conn = Conexion.crearInstancia().crearConexion();

                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();

                lista = command.ExecuteReader();

                dtTabla.Load(lista);
                return dtTabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public DataTable ListarProveedores(string comando)
        {
            SqlDataReader lista;
            DataTable dtTabla = new DataTable();

            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = comando;
                //string sql = "Select intProveedor as Proveedor, strNombre as Nombre from tblProveedores";
                conn = Conexion.crearInstancia().crearConexion();

                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();

                lista = command.ExecuteReader();

                dtTabla.Load(lista);
                return dtTabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public string InsertaProducto(Producto obj)
        {
            string respuesta = "";
            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = "Insert Into tblProductos(intProducto, strNombre, dblPrecio,strCodigoBarras,intExistencia,intSucursal,intMarca,intProveedor,intActivo) Values(" +
                             "'" + obj.Producto_id + "', " +
                             "'" + obj.Producto_nombre + "', " +
                             "'" + obj.Producto_precio + "', " +
                             "'" + obj.Producto_codigobarras +"',"+
                             "'" + obj.Producto_existencia + "', " +
                             "'" + obj.Producto_sucursal + "', " +
                             "'" + obj.Producto_marca + "', " +
                             "'" + obj.Producto_proveedor + "', " +
                             "'" + obj.Producto_activo + "')";

                conn = Conexion.crearInstancia().crearConexion();

                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    respuesta = "OK";
                }
                else
                {
                    respuesta = "No se pudo registrar la información.";
                }

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return respuesta;
        }

        public DataTable ListarProductos(string comando)
        {
            SqlDataReader lista;
            DataTable dtTabla = new DataTable();

            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = comando;
                conn = Conexion.crearInstancia().crearConexion();

                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();

                lista = command.ExecuteReader();

                dtTabla.Load(lista);
                return dtTabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

    }

}

