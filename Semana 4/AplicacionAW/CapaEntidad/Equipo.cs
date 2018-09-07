using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Equipo
    {
        public int IdEquipo { get; set; }
        public string Descripcion { get; set; }
        public double Precio  { get; set; }
        public string TipoEquipo { get; set; }
        public string EstadoEquipo { get; set; }
    }
}
