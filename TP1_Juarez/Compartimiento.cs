using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    public class Compartimiento
    {
        public int NumeroDeCompartimiento { get; set; }
        public OrdenDeRetiro NumeroDeOrden { get; set; }
        public OrdenDeAlmacen NumeroDeOrdenAlmacen { get; set; }
        public Lado NumeroDeLado { get; set; }
        public Producto CodigoProducto { get; set; }
    }
}
