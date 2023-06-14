using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.TresCapas
{
   public  class DPermisos: DAbstracta
    {
        public DataTable ConsultaPermisos()
        {
            DataTable BBL = new DataTable();
            SqlConnection PPn = new SqlConnection(CadenaConexion);
            SqlCommand PPm = new SqlCommand("Select * from Permiso", PPn);
            PPn.Open();
            PPm.ExecuteNonQuery();
            SqlDataAdapter TTr = new SqlDataAdapter(PPm);
            TTr.Fill(BBL);
            PPn.Close();
            return BBL;
        }
    }
}
