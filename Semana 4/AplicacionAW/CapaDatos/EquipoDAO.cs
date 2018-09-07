using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class EquipoDAO
    {
        Conexion ObjCn = new Conexion();
        SqlConnection Cn = new SqlConnection(); 

        public DataTable ListarEquipo()
        {
            Cn = ObjCn.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTAEQUIPO", Cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ListarTipoEquipo()
        {
            Cn = ObjCn.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTATIPOEQUIPOS", Cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable ListarEquipos()
        {
            Cn = ObjCn.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTAEQUIPOS", Cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ListarEstadoEquipo()
        {
            Cn = ObjCn.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTAESTADOS", Cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int NuevoEquipo(Equipo equipo)
        {
            Cn = ObjCn.getConecta();
            Cn.Open();
            using (SqlTransaction tr = Cn.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_NUEVOEQUIPO",Cn,tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@TIP", SqlDbType.Int).Value = equipo.TipoEquipo;
                cmd.Parameters.Add("@DES", SqlDbType.VarChar).Value = equipo.Descripcion;
                cmd.Parameters.Add("@PRE", SqlDbType.Money).Value = equipo.Precio;
                cmd.Parameters.Add("@EST", SqlDbType.Int).Value = equipo.EstadoEquipo;

                try
                {
                    int n = cmd.ExecuteNonQuery();
                    tr.Commit();
                    return n;
                }
                catch (Exception e)
                {
                    tr.Rollback();
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

       
        
    }
}
