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

namespace Proyecto1.Formas.Listados
{
    public partial class lstProveedores : Form
    {
        public lstProveedores()
        {
            InitializeComponent();
        }

        private void lstProveedores_Load(object sender, EventArgs e)
        {
            string comando = "Select intProveedor as Proveedor, strNombre as Nombre from tblProveedores";
            datosSQL obj = new datosSQL();
            dataGridView1_proveedor.DataSource = obj.ListarProveedores(comando);
        }

        private void button1_buscar_Click(object sender, EventArgs e)
        {
            string marcabuscar=textBox1_buscar.Text;

            string comando = "Select intProveedor as Proveedor, strNombre as Nombre from tblProveedores WHERE strNombre like '"+marcabuscar+"%'";
            datosSQL obj = new datosSQL();
            dataGridView1_proveedor.DataSource = obj.ListarProveedores(comando);
        }

        private void textBox1_buscar_TextChanged(object sender, EventArgs e)
        {
            if(textBox1_buscar.Text==string.Empty)
            {
                string comando = "Select intProveedor as Proveedor, strNombre as Nombre from tblProveedores";
                datosSQL obj = new datosSQL();
                dataGridView1_proveedor.DataSource = obj.ListarProveedores(comando);
            }
        }
    }
}
