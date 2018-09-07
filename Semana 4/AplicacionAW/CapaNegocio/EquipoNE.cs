using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class EquipoNE
    {
        private EquipoDAO equipoDAO;
        public EquipoNE()
        {
            equipoDAO = new EquipoDAO();
        }

        public DataTable ListarEquipo()
        {
            return equipoDAO.ListarEquipo();
        }

        public DataTable ListarEstadoEquipo()
        {
            return equipoDAO.ListarEstadoEquipo();
        }

        public DataTable ListarTipoEquipo()
        {
            return equipoDAO.ListarTipoEquipo();
        }

        public DataTable ListaEquipos()
        {
            return equipoDAO.ListarEquipos();
        }

        public int NuevoEquipo(Equipo equipo)
        {
            return equipoDAO.NuevoEquipo(equipo);
        }



       
    }
}
