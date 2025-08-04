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
    public partial class catMarca : Form
    {
        public catMarca()
        {
            InitializeComponent();
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
            txtNombre.Clear();
            chkActivo.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string respuesta = "";

            try
            {
                if (txtCodigo.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar el código,", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigo.Text=string.Empty;
                    return;

                }

                if (txtNombre.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar el mombre,", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Text=string.Empty;
                    return;
                }

                Marca obj=new Marca();
                obj.MarcaID=int.Parse(txtCodigo.Text);
                obj.Nombre = txtNombre.Text;

                if(chkActivo.Checked==true)
                {
                    obj.Activo = 1;
                }
                else
                {
                    obj.Activo = 0;

                }

                datosSQL ds = new datosSQL();

                respuesta = ds.InsertaMarca(obj); //Agregr funcion en datosSQL

                if (respuesta=="OK")
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
