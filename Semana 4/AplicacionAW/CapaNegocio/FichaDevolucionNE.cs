using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class FichaDevolucionNE
    {

        private FichaDevolucionDAO fichaDevolucionDAO;

        public FichaDevolucionNE()
        {
            fichaDevolucionDAO = new FichaDevolucionDAO();
        }

        public DataTable ListarFichasDevolucion()
        {
            return fichaDevolucionDAO.ListarFichaDevolucion();
        }

        public int NuevaFicha(FichaDevolucion ficha)
        {
            return fichaDevolucionDAO.NuevaFicha(ficha);
        }

        public int ActualizaFicha(FichaDevolucion ficha)
        {
            return fichaDevolucionDAO.ActualizaFicha(ficha);
        }
    }

}
