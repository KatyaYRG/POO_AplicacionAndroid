using Proyecto1.Datos;
using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class catSucursal : Form
    {
        public catSucursal()
        {
            InitializeComponent();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            try
            {
                if (txtNumero.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar la clave.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero.Text = string.Empty;
                    return;
                }

                if (txtNombre.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar el nombre.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Text = string.Empty;
                    return;
                }

                Sucursal obj = new Sucursal();
                
                obj.SucursalID = int.Parse(txtNumero.Text);
                obj.Nombre = txtNombre.Text; 
                
                if (chkActivo.Checked == true)
                {
                    obj.Activo = 1;
                }
                else
                {
                    obj.Activo = 0;
                }

                datosSQL ds = new datosSQL();
                
                respuesta = ds.InsertaSucursal(obj);

                if (respuesta == "OK")
                {
                    MessageBox.Show("Información registrada.", "Proyecto 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Limpiar();
                    txtNumero.Focus();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Limpiar()
        {
            txtNumero.Text = string.Empty;
            txtNombre.Clear();
            chkActivo.Checked = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
