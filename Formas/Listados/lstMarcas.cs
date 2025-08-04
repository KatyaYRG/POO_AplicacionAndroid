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
    public partial class lstMarcas : Form
    {
        public lstMarcas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1_buscar.Text;
            string comando = "Select intMarca as Marca, strNombre as Nombre from tblMarcas WHERE strNombre like '"+nombre+"%'";
            datosSQL obj = new datosSQL();
            dataGridView1_marcas.DataSource = obj.ListarMarcas(comando);
        }

        private void lstMarcas_Load(object sender, EventArgs e)
        {
            string comando= "Select intMarca as Marca, strNombre as Nombre from tblMarcas";
            datosSQL obj = new datosSQL();
            dataGridView1_marcas.DataSource = obj.ListarMarcas(comando);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_buscar_TextChanged(object sender, EventArgs e)
        {
            if(textBox1_buscar.Text==string.Empty)
            {
                string comando = "Select intMarca as Marca, strNombre as Nombre from tblMarcas";
                datosSQL obj = new datosSQL();
                dataGridView1_marcas.DataSource = obj.ListarMarcas(comando);
            }
        }
    }
}
