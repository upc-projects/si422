using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class FichaDevolucion
    {
        
        public int IdFicha { get; set; }

        public Contratista ObjContratista { get; set; }
        public Cliente ObjCliente { get; set; }
        public Equipo ObjEquipo { get; set; }


        public DateTime Fecha { get; set; }
        public double Mora { get; set; }

    }
}
