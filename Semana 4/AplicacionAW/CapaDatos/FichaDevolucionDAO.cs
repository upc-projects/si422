using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class FichaDevolucionDAO
    {

        Conexion ObjCn = new Conexion();

        SqlConnection Cn = new SqlConnection();

        public DataTable ListarFichaDevolucion()
        {
            Cn = ObjCn.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTAFICHADEVOLUCION", Cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


       
        public int NuevaFicha(FichaDevolucion ficha)
        {

           Cn = ObjCn.getConecta();
           Cn.Open();

            using (SqlTransaction tr = Cn.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_NUEVAFICHADEDEVOLUCION", Cn, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ICO", SqlDbType.Int).Value = ficha.ObjContratista.IdContratista;
                cmd.Parameters.Add("@ICL", SqlDbType.Int).Value = ficha.ObjCliente.IdCliente;
                cmd.Parameters.Add("@IEQ", SqlDbType.Int).Value = ficha.ObjEquipo.IdEquipo;
                cmd.Parameters.Add("@FDE", SqlDbType.Date).Value = ficha.Fecha;
                cmd.Parameters.Add("@MOR", SqlDbType.Money).Value = ficha.Mora;

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


        public int ActualizaFicha(FichaDevolucion ficha)
        {

           

            return 0;
        }

    }
}
