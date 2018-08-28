using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;
using EntityLayer;

namespace BusinessLayer
{
    public class EquipoNegocio
    {
        private EquipoDAO equipoDAO;

        public EquipoNegocio()
        {
            equipoDAO = new EquipoDAO();
        }

        public DataTable ListarEquipo()
        {
            return equipoDAO.ListarEquipos();
        }

        public void RegistrarEquipo(Equipo eq)
        {
            equipoDAO.RegistrarEquipo(eq);
        }

    }
}
