using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    public class OrdenDeAlmacen
    {
        public Encargado Operario { get; set; }
        public Cliente NumeroCliente { get; set; }
        public int NumeroDeOrden { get; set; }
        public DateTime FechaOrden { get; set; }
        public string Descripcion { get; set; }
    }
}
