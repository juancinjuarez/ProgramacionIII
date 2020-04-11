using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    public class Encargado:Persona
    {
        public OrdenDeRetiro NumeroDeOrdenRet { get; set; }
        public OrdenDeAlmacen NumeroDeOrdenAlm { get; set; }
        public int Legajo { get; set; }
        public string Puesto { get; set; }
        public int HorarioIngreso { get; set; }
        public int HorarioSalida { get; set; }
    }
}
