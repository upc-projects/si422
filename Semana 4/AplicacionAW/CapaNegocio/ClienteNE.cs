using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ClienteNE
    {

        private ClienteDAO clienteDAO;
        public ClienteNE()
        {
            clienteDAO = new ClienteDAO();
        }

        public DataTable ListarCliente()
        {
            return clienteDAO.ListarCliente();
        }

    }
}
