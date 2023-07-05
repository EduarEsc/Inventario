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
            SqlCommand PPm = new SqlCommand("Select * from Permisos", PPn);
            PPn.Open();
            PPm.ExecuteNonQuery();
            SqlDataAdapter TTr = new SqlDataAdapter(PPm);
            TTr.Fill(BBL);
            PPn.Close();
            return BBL;
        }
        public int AgregarPermisos(string DescP)
        {
            SqlConnection con = new SqlConnection(CadenaConexion);
            SqlCommand com = new SqlCommand(String.Format("Insert Into Permisos(Descripcion) Values('{0}')", DescP), con);
            con.Open();
            int resultado = 0;
            resultado = com.ExecuteNonQuery();
            con.Close();
            return resultado;
        }
        public int ActualizaPermisos(int idP, string DescP)
        {
            SqlConnection con = new SqlConnection(CadenaConexion);
            SqlCommand com = new SqlCommand(String.Format("update Permisos set Descripcion = '{1}' where ID_Permisos =  {0}", idP, DescP), con);
            con.Open();
            int resultado = 0;
            resultado = com.ExecuteNonQuery();
            con.Close();
            return resultado;
        }
        public DataTable ValorPer(int ID_Permisos)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(CadenaConexion);
            SqlCommand com = new SqlCommand(String.Format("Select * from Permisos Where ID_Permisos = {0}", ID_Permisos), con);
            con.Open();
            com.ExecuteNonQuery();
            SqlDataAdapter dta = new SqlDataAdapter(com);
            dta.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable ValorPER(int ID_Permisos)
        {
            DataTable dtVal = new DataTable();
            SqlConnection con = new SqlConnection(CadenaConexion);
            SqlCommand com = new SqlCommand(String.Format("Select * from Permisos Where ID_Permisos = {0}", ID_Permisos), con);
            con.Open();
            com.ExecuteNonQuery();
            SqlDataAdapter dta = new SqlDataAdapter(com);
            dta.Fill(dtVal);
            con.Close();
            return dtVal;
        }
    }
}
  