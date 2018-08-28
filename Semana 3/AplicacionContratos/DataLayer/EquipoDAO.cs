using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataLayer
{
    class EquipoDAO
    {
        Conexion Objcn = new Conexion();
        SqlConnection cn = new SqlConnection();

        public DataTable ListarEquipos()
        {
            cn = Objcn.getConnection();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTAR_EQUIPOS", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void RegistrarEquipo(Equipo eq)
        {
            cn = Objcn.getConnection();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_EQUIPO", cn);
        }
    }
}
