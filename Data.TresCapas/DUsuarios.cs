using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.TresCapas
{
    public class DUsuarios: DAbstracta
    {
        public int AgregarUsuario(int ID_permiso, string nombre, string apaterno, string amaterno, string contraseña)
        {
            SqlConnection con = new SqlConnection(CadenaConexion);
            SqlCommand com = new SqlCommand(String.Format("Insert into Usuarios (ID_Permisos, Nombre, ApPat, ApMat, FechaIngreso, Contraseña) Values ({0}, '{1}','{2}', '{3}', '{4}', '{5}')",ID_permiso, nombre,apaterno,amaterno,DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),contraseña), con);
            con.Open();
            int res = 0;
            res = com.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public DataTable ConsultaUsuarios()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(CadenaConexion);
            SqlCommand com = new SqlCommand("Select u.ID_Usuarios, p.Descripcion, u.Nombre, u.ApPat, u.ApMat, u.FechaIngreso, u.Contraseña from Usuarios u inner join Permisos p on u.ID_Permisos = p.ID_Permisos", con);
            con.Open();
            com.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public int ActualizaUsurio(int id, int ID_permiso, string nombre, string apaterno, string amaterno, string contraseña)
        {
            SqlConnection con = new SqlConnection(CadenaConexion);
            SqlCommand com = new SqlCommand(String.Format("update Usuarios set ID_Permisos = {0}, Nombre = '{1}', ApPat = '{2}', ApMat = '{3}', FechaIngreso = '{4}', Contraseña ='{5}' where ID_Usuarios =  {6}", ID_permiso, nombre, apaterno, amaterno, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), contraseña, id), con);
            con.Open();
            int res = 0;
            res = com.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public DataTable ConsultaUsuario(int ID_Usuario)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(CadenaConexion);
            SqlCommand com = new SqlCommand(String.Format("Select * from Usuarios Where ID_Usuarios = {0}", ID_Usuario), con);
            con.Open();
            com.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
