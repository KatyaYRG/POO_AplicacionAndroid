using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Modelos
{
    public class Producto
    {
        public int Producto_id { get; set; }
        public string Producto_nombre { get; set; }
        public float Producto_precio { get; set; }
        public string Producto_codigobarras {  get; set; }
        public int Producto_existencia { get; set; }
        public int Producto_sucursal { get; set; }
        public int Producto_marca { get; set; }
        public int Producto_proveedor { get; set; }
        public int Producto_activo { get; set; }
    }
}
