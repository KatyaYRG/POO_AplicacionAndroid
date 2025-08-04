using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
           
            
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new catSucursal();
            forma.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new Formas.Catalogos.catMarca();
            forma.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogo = new Formas.Catalogos.catProductos();
            catalogo.Show();
        }

        private void marcasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Listado=new Formas.Listados.lstMarcas();
            Listado.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogo=new Formas.Catalogos.catProveedores();
            catalogo.Show();
        }

        private void sucursalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Listado = new Formas.Listados.lstSucursal();
            Listado.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Listado = new Formas.Listados.lstProveedores();
            Listado.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form listado=new Formas.Listados.lstProductos();
            listado.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
