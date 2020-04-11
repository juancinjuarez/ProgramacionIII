using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    public class Cliente:Persona
    {
        public OrdenDeAlmacen NumeroDeOrdenAlm { get; set; }
        public OrdenDeRetiro NumeroDeOrdenRetiro { get; set; }
        public Direccion direccion { get; set; }
        public Pasillo NumeroDePasillo { get; set; }
        public Compartimiento NumeroDeCompartimiento { get; set; }
        public string Email { get; set; }
        public int NumCliente { get; set; }
        public int Telefono { get; set; }
    }
}
