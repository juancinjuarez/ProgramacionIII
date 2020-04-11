using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public float Peso { get; set; }
        public float Precio { get; set; }
        public Marca MarcaProducto { get; set; }
    }
}
