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
    public partial class catProveedores : Form
    {
        public catProveedores()
        {
            InitializeComponent();

        }

        private void catProveedores_Load(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            textNombre.Text = string.Empty;
            checkBox1.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string respuesta = "";

            try
            {
                if(txtCodigo.Text==string.Empty)
                {
                    MessageBox.Show("Falta ingresar el codigo.", "Proyecto1 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigo.Text=string.Empty;
                    return;
                }

                if(textNombre.Text==string.Empty)
                {
                    MessageBox.Show("Falta ingresar el nombre.","Proyecto 1",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textNombre.Text=string.Empty;
                    return;
                }

                Proveedor obj = new Proveedor();

                obj.ProveedorID=int.Parse(txtCodigo.Text);
                obj.Nombre=textNombre.Text;

                if(checkBox1.Checked==true)
                {
                    obj.Activo = 1;
                }
                else
                {
                    obj.Activo = 0;
                }

                datosSQL ds=new datosSQL();

                respuesta = ds.InsertaProveedor(obj); //Agregar funcion en datosSQL.css

                if (respuesta == "OK")
                {
                    MessageBox.Show("Información registrada.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Limpiar();
                    txtCodigo.Focus();
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
    }
}
