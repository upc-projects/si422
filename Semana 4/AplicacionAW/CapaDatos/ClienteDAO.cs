using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClienteDAO
    {
        Conexion ObjCn = new Conexion();

        SqlConnection Cn = new SqlConnection();

        public DataTable ListarCliente()
        {
            Cn = ObjCn.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTACLIENTES", Cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
