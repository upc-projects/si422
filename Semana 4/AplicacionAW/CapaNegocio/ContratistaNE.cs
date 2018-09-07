using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ContratistaNE
    {

        private ContratistaDAO contratistaDAO;

        public ContratistaNE()
        {
            contratistaDAO = new ContratistaDAO();
        }

        public DataTable ListarContratista()
        {
            return contratistaDAO.ListarContratista();
        }
    }
}
