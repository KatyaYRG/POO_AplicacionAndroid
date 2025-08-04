using Proyecto1.Datos;
using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Formas.Catalogos
{
    public partial class catProductos : Form
    {
        public catProductos()
        {
            InitializeComponent();
        }

        private void catProductos_Load(object sender, EventArgs e)
        {

        }

        private void textSucursal_Leave(object sender, EventArgs e)
        {
            DataTable dtRespuesta = new DataTable();
            if(textSucursal.Text==string.Empty)
            {
                return;
            }

            datosSQL ds = new datosSQL();

            dtRespuesta = ds.BuscaSucursal(textSucursal.Text);

            if(dtRespuesta.Rows.Count==0)
            {
                MessageBox.Show("El número de sucursal no existe.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSucursal.Text = string.Empty;
                textSucursal.Focus();
                return;
            }
            else
            {
                textBox9.Text = dtRespuesta.Rows[0][1].ToString();
            }
        }

        private void textSucursal_TextChanged(object sender, EventArgs e)
        {
            textBox9.Text=string.Empty;
        }

        private void textBox_marca_Leave(object sender, EventArgs e)
        {
            DataTable dtRespuesta = new DataTable();
            if (textBox_marca.Text == string.Empty)
            {
                return;
            }

            datosSQL ds = new datosSQL();

            dtRespuesta = ds.BuscarMarcas(textBox_marca.Text);

            if (dtRespuesta.Rows.Count == 0)
            {
                MessageBox.Show("El número de marca no existe.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_marca.Text = string.Empty;
                textBox_marca.Focus();
                return;
            }
            else
            {
                textBox10.Text = dtRespuesta.Rows[0][1].ToString();
            }
        }

        private void textBox_proveedor_Leave(object sender, EventArgs e)
        {
            DataTable dtRespuesta = new DataTable();
            if (textBox_proveedor.Text == string.Empty)
            {
                return;
            }

            datosSQL ds = new datosSQL();

            dtRespuesta = ds.BuscaProveedor(textBox_proveedor.Text);

            if (dtRespuesta.Rows.Count == 0)
            {
                MessageBox.Show("El número de proveedor no existe.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_proveedor.Text = string.Empty;
                textBox_proveedor.Focus();
                return;
            }
            else
            {
                textBox11.Text = dtRespuesta.Rows[0][1].ToString();
            }
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            string respuesta = "";

            try
            {
                if (textNumero.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar el Número.", "Proyecto1 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textNumero.Text = string.Empty;
                    return;
                }

                if (textNombre.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar el Nombre.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textNombre.Text = string.Empty;
                    return;
                }
                if (textPrecio.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar el Precio.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textPrecio.Text = string.Empty;
                    return;
                }

                if (textCodigo.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar el Codigo.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textCodigo.Text = string.Empty;
                    return;
                }
                if (textExistencia.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar las existencias.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textExistencia.Text = string.Empty;
                    return;
                }
                if (textSucursal.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar la Sucursal.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textSucursal.Text = string.Empty;
                    return;
                }
                if (textBox_marca.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar la Marca.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_marca.Text = string.Empty;
                    return;
                }
                if (textBox_proveedor.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar el proveedor.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_proveedor.Text = string.Empty;
                    return;
                }

                Producto obj = new Producto();

                obj.Producto_id = int.Parse(textNumero.Text);
                obj.Producto_nombre = textNombre.Text;
                obj.Producto_precio = float.Parse(textPrecio.Text);
                obj.Producto_codigobarras=textCodigo.Text;
                obj.Producto_existencia=int.Parse(textExistencia.Text);
                obj.Producto_sucursal = int.Parse(textSucursal.Text);
                obj.Producto_marca = int.Parse(textBox_marca.Text);
                obj.Producto_proveedor = int.Parse(textBox_proveedor.Text);

                if (checkBox1.Checked == true)
                {
                    obj.Producto_activo = 1;
                }
                else
                {
                    obj.Producto_activo = 0;
                }

                datosSQL ds = new datosSQL();

                respuesta = ds.InsertaProducto(obj); //Agregar funcion en datosSQL.css HECHO!!!

                if (respuesta == "OK")
                {
                    MessageBox.Show("Información registrada.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Limpiar();
                    textNumero.Focus();
                }
                else
                {
                    MessageBox.Show(respuesta, "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Limpiar()
        {
            textNumero.Text = string.Empty;
            textNombre.Text = string.Empty;
            textPrecio.Text = string.Empty;
            textCodigo.Text = string.Empty; 
            textExistencia.Text = string.Empty;
            textSucursal.Text = string.Empty; 
            textBox9.Text = string.Empty;
            textBox_marca.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox_proveedor.Text = string.Empty;
            textBox11.Text = string.Empty;
            checkBox1.Checked = false;
        }


        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_borrar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
    }
}
