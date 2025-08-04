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
    public partial class lstSucursal : Form
    {
        public lstSucursal()
        {
            InitializeComponent();
        }

        private void lstSucursal_Load(object sender, EventArgs e)
        {
            string comando = "Select intSucursal as Sucursal, strNombre as Nombre from tblSucursales";

            datosSQL obj = new datosSQL();
            dataGridView1_Sucursal.DataSource = obj.ListarSucursal(comando);
        }

        private void button1_buscar_Click(object sender, EventArgs e)
        {
            string sucrsalbuscar=textBox1_Sucursal.Text;

            string comando = "Select intSucursal as Sucursal, strNombre as Nombre from tblSucursales WHERE strNombre LIKE '" +sucrsalbuscar+"%'";

            datosSQL obj = new datosSQL();
            dataGridView1_Sucursal.DataSource = obj.ListarSucursal(comando);

        }

        private void textBox1_Sucursal_TextChanged(object sender, EventArgs e)
        {
            if(textBox1_Sucursal.Text==string.Empty)
            {
                string comando = "Select intSucursal as Sucursal, strNombre as Nombre from tblSucursales";

                datosSQL obj = new datosSQL();
                dataGridView1_Sucursal.DataSource = obj.ListarSucursal(comando);
            }
        }
    }
}
