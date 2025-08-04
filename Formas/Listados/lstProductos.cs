using Proyecto1.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proyecto1.Formas.Listados
{
    public partial class lstProductos : Form
    {


        public lstProductos()
        {
            InitializeComponent();
        }

        private void lstProductos_Load(object sender, EventArgs e)
        {
            string comando= "SELECT intProducto as 'Producto',\r\ntblProductos.strNombre AS 'Nombre',\r\ndblPrecio as 'Precio',\r\nstrCodigoBarras as 'Codigo de barras',\r\nintExistencia as 'Existencia',\r\ntblSucursales.strNombre as 'Sucursal',\r\ntblMarcas.strNombre as 'Marca',\r\ntblProveedores.strNombre as 'Proveedor'\r\nfrom tblProductos\r\nLEFT JOIN tblSucursales \r\nON tblProductos.intSucursal=tblSucursales.intSucursal\r\nLEFT JOIN tblMarcas\r\nON tblProductos.intMarca=tblMarcas.intMarca\r\nLEFT JOIN tblProveedores\r\nON tblProductos.intProveedor=tblProveedores.intProveedor";
            datosSQL obj = new datosSQL();
            dataGridView1_productos.DataSource = obj.ListarProductos(comando);
        }

        private void button1_buscar_Click(object sender, EventArgs e)
        {
            string nombre=textBox1_buscar.Text;
            string comando = "SELECT intProducto as 'Producto',\r\ntblProductos.strNombre AS 'Nombre',\r\ndblPrecio as 'Precio',\r\nstrCodigoBarras as 'Codigo de barras',\r\nintExistencia as 'Existencia',\r\ntblSucursales.strNombre as 'Sucursal',\r\ntblMarcas.strNombre as 'Marca',\r\ntblProveedores.strNombre as 'Proveedor'\r\nfrom tblProductos\r\nLEFT JOIN tblSucursales \r\nON tblProductos.intSucursal=tblSucursales.intSucursal\r\nLEFT JOIN tblMarcas\r\nON tblProductos.intMarca=tblMarcas.intMarca\r\nLEFT JOIN tblProveedores\r\nON tblProductos.intProveedor=tblProveedores.intProveedor\r\nWHERE tblProductos.strNombre like '"+nombre+"%'";
            datosSQL obj = new datosSQL();
            dataGridView1_productos.DataSource = obj.ListarProductos(comando);
        }

        private void textBox1_buscar_TextChanged(object sender, EventArgs e)
        {
            if (textBox1_buscar.Text == string.Empty) 
            {
                string comando = "SELECT intProducto as 'Producto',\r\ntblProductos.strNombre AS 'Nombre',\r\ndblPrecio as 'Precio',\r\nstrCodigoBarras as 'Codigo de barras',\r\nintExistencia as 'Existencia',\r\ntblSucursales.strNombre as 'Sucursal',\r\ntblMarcas.strNombre as 'Marca',\r\ntblProveedores.strNombre as 'Proveedor'\r\nfrom tblProductos\r\nLEFT JOIN tblSucursales \r\nON tblProductos.intSucursal=tblSucursales.intSucursal\r\nLEFT JOIN tblMarcas\r\nON tblProductos.intMarca=tblMarcas.intMarca\r\nLEFT JOIN tblProveedores\r\nON tblProductos.intProveedor=tblProveedores.intProveedor";
                datosSQL obj = new datosSQL();
                dataGridView1_productos.DataSource = obj.ListarProductos(comando);
            }
        }
    }
}
