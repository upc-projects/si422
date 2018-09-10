using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class JugadorDAO
    {
        Conexion conexion = new Conexion();
        SqlConnection sqlConnection = new SqlConnection();

        public DataTable ListarJugadores()
        {
            sqlConnection = conexion.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SP_LISTAR_JUGADORES",sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public int RegistrarJugador(Jugador jugador)
        {
            sqlConnection = conexion.GetConnection();
            sqlConnection.Open();

            using (SqlTransaction tr = sqlConnection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_JUGADOR", sqlConnection, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = jugador.Nombre;
                cmd.Parameters.Add("@APELLIDO", SqlDbType.VarChar).Value = jugador.Apellido;
                cmd.Parameters.Add("@EDAD", SqlDbType.Int).Value = jugador.Edad;
                cmd.Parameters.Add("@TALLA", SqlDbType.Float).Value = jugador.Talla;
                cmd.Parameters.Add("@PESO", SqlDbType.Float).Value = jugador.Peso;
                cmd.Parameters.Add("@CAMISETA", SqlDbType.Int).Value = jugador.Camiseta;

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
