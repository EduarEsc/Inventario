using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.TresCapas
{
    public class DLogin: DAbstracta
    {
        public DataTable ConsultaUsuarios(string user)
        {
            DataTable Dtt = new DataTable();
            SqlConnection NNq = new SqlConnection(CadenaConexion);
            SqlCommand MMq = new SqlCommand(string.Format("Select * From Usuarios where Nombre = '{0}'", user), NNq);
            NNq.Open();
            MMq.ExecuteNonQuery();
            SqlDataAdapter DDr = new SqlDataAdapter(MMq);
            DDr.Fill(Dtt);
            NNq.Close();
            return Dtt;
        }
    }
}
