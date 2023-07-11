using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.TresCapas
{
    public class DProductos: DAbstracta
    {

        public int AgregaProducto(int ID_Categoria, string NombreProducto, string Caracteristicas, string CodigoBarra, string Precio)
        {
            SqlConnection Coo = new SqlConnection(CadenaConexion);
            SqlCommand Maa = new SqlCommand(String.Format("Insert Into Producto (ID_Categoria, NombreProducto, Caracteristicas, CodigoBarra, Precio) Values ({0}, '{1}', '{2}', '{3}', {4})", ID_Categoria, NombreProducto, Caracteristicas, CodigoBarra, Precio), Coo); ;
            Coo.Open();
            int agr = 0;
            agr=Maa.ExecuteNonQuery();
            Coo.Close();            
            return agr;
        }
        public DataTable ConsultaProductos()
        {
            DataTable DPR = new DataTable();    
            SqlConnection Tii = new SqlConnection(CadenaConexion);
            SqlCommand Ann = new SqlCommand("Select * from Producto", Tii);
            Tii.Open();
            Ann.ExecuteNonQuery();
            SqlDataAdapter Trr = new SqlDataAdapter(Ann);
            Trr.Fill(DPR);
            Tii.Close();
            return DPR;
        }
        public int ActualizarProducto(int ID_Producto, int ID_Categoria, string NombreProducto, string Caracteristicas, string CodigoBarra, string Precio)
        {
            
            SqlConnection Acn = new SqlConnection(CadenaConexion);
            SqlCommand Acm = new SqlCommand(string.Format("Update Producto set ID_Categoria = {1}, NombreProducto = '{2}', Caracteristicas = '{3}', CodigoBarra = '{4}', Precio = {5} where ID_Producto = {0}", ID_Producto, ID_Categoria, NombreProducto, Caracteristicas, CodigoBarra, Precio.Replace(",",".")), Acn);
            SqlDataAdapter Adt = new SqlDataAdapter(Acm);
            Acn.Open();
            int result = Acm.ExecuteNonQuery();

            
            Acn.Close();
            return result;
        }
        public int EliminarProducto(int ID_Producto)
        {
            DataTable Pel = new DataTable();
            SqlConnection Pll = new SqlConnection(CadenaConexion);
            SqlCommand Pmm = new SqlCommand(string.Format("Delete from Producto Where ID_Producto = {0}", ID_Producto), Pll);
            Pll.Open();
            int rll = 0;
            rll = Pmm.ExecuteNonQuery();
            Pll.Close();
            return rll;
        }
        public DataTable producto(int ID_Producto)
        {
            DataTable ProEl = new DataTable();
            SqlConnection Pon = new SqlConnection(CadenaConexion);
            SqlCommand Pmm = new SqlCommand(string.Format("Select * from Producto Where ID_Producto = {0}", ID_Producto), Pon);
            Pon.Open();
            Pmm.ExecuteNonQuery();
            SqlDataAdapter Pee = new SqlDataAdapter(Pmm);
            Pee.Fill(ProEl);
            Pon.Close();
            return ProEl; 
        }
    }
}
