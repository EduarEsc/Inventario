using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.TresCapas
{
    public class DCategoria: DAbstracta
    {
        public DataTable ConsultaCategorias()
        {
            DataTable BLE = new DataTable();
            SqlConnection Onn = new SqlConnection(CadenaConexion);
            SqlCommand DDn = new SqlCommand("Select * from Categoria", Onn);
            Onn.Open();
            DDn.ExecuteNonQuery();
            SqlDataAdapter Rtt = new SqlDataAdapter(DDn);
            Rtt.Fill(BLE);
            Onn.Close();
            return BLE;
        }
        public int AgregarCategoria(string Descripcion)
        {
            SqlConnection QQn = new SqlConnection(CadenaConexion);
            SqlCommand QQm = new SqlCommand(String.Format("Insert Into Categoria(Descripcion) Values('{0}')", Descripcion), QQn);
            QQn.Open();
            int err = 0;
            err = QQm.ExecuteNonQuery();
            QQn.Close();
            return err;
        }
        public int ActualizaCategoria(int id, string descr)
        {
            SqlConnection Ell = new SqlConnection(CadenaConexion);
            SqlCommand Emm = new SqlCommand(String.Format("update Categoria set Descripcion = '{1}' where ID_Categoria =  {0}", id, descr), Ell);
            Ell.Open();
            int ell = 0;
            ell = Emm.ExecuteNonQuery();
            Ell.Close();
            return ell;
        }
        public int EliminarCategoria(int ID_Categoria)
        {
            DataTable DeL = new DataTable();
            SqlConnection Ell = new SqlConnection(CadenaConexion);
            SqlCommand Emm = new SqlCommand(String.Format("Delete from Categoria Where ID_Categoria = {0}", ID_Categoria),Ell);
            Ell.Open();
            int ell = 0;
            ell = Emm.ExecuteNonQuery();
            Ell.Close();
            return ell;
        }
        public DataTable Valor(int ID_Categoria)
        {
            DataTable DCT = new DataTable();
            SqlConnection Vnn = new SqlConnection(CadenaConexion);
            SqlCommand Vmm = new SqlCommand(String.Format("Select * from Categoria Where ID_Categoria = {0}", ID_Categoria), Vnn);
            Vnn.Open();
            Vmm.ExecuteNonQuery();
            SqlDataAdapter Vtt = new SqlDataAdapter(Vmm);
            Vtt.Fill(DCT);
            Vnn.Close();
            return DCT;
        }
    }
}
