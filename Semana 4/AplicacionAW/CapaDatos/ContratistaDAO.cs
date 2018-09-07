using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ContratistaDAO
    {
        Conexion ObjCn = new Conexion();

        SqlConnection Cn = new SqlConnection();

        public DataTable ListarContratista()
        {
            Cn = ObjCn.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTARCONTRATISTA",Cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
