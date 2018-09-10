using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class JugadorNE
    {
        JugadorDAO jugadorDao;

        public JugadorNE()
        {
            jugadorDao = new JugadorDAO();

        }

        public DataTable listarJugadores()
        {
            return jugadorDao.ListarJugadores();
        }

        public int registrarJugador(Jugador jugador)
        {
            return jugadorDao.RegistrarJugador(jugador);
        }
    }
}
