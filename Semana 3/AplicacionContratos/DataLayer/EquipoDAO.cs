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
    public class EquipoDAO
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

            try
            {
                cn = Objcn.getConnection();
                cn.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_EQUIPO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("tipoequipo", SqlDbType.VarChar).Value = eq.TipoEquipo;
                cmd.Parameters.Add("estadoequipo", SqlDbType.VarChar).Value = eq.EstadoEquipo;
                cmd.Parameters.Add("descripcionequipo", SqlDbType.VarChar).Value = eq.Descripcion;

                cmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                throw e;
            }


        }
    }
}
