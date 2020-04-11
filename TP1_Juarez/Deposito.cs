using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    public class Deposito
    {
        public int NumeroDeDeposito { get; set; }
        public string NombreDeposito { get; set; }
        public Ciudad NombreDeCiudad { get; set; }
        public Direccion DireccionDeposito { get; set; }
    }
}
