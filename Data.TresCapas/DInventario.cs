using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.TresCapas
{
    public class DInventario: DAbstracta
    {
        public DataTable ConsultaInventario()
        {
            DataTable Inl = new DataTable();
            SqlConnection oNN = new SqlConnection(CadenaConexion);
            SqlCommand oMM = new SqlCommand("select I.ID_Inventario, P.NombreProducto, c.Descripcion, I.Cantidad from Inventario I  inner Join Producto p on I.ID_Producto = p.ID_Producto inner Join Categoria C on p.ID_Categoria = c.ID_Categoria", oNN);
            oNN.Open();
            oMM.ExecuteNonQuery();
            SqlDataAdapter Trr = new SqlDataAdapter(oMM);
            Trr.Fill(Inl);
            oNN.Close();
            return Inl;
        }
        public int AgregarInventario(int ID_Producto, int Cantidad)
        {
            SqlConnection Inn = new SqlConnection(CadenaConexion);
            SqlCommand Imm = new SqlCommand(string.Format("Insert Into Inventario (ID_Producto, Cantidad) Values({0},{1})", ID_Producto, Cantidad), Inn);
            Inn.Open();
            int nnV = 0;
            nnV = Imm.ExecuteNonQuery();
            Inn.Close();
            return nnV;
        }

        public int ActualizarInventario(int ID_Inventario, int ID_Producto, int Cantidad)
        {
            SqlConnection Sin = new SqlConnection(CadenaConexion);
            SqlCommand Sim = new SqlCommand(String.Format("update Inventario set ID_Producto = {0}, Cantidad = {1} Where ID_Inventario = {2}", ID_Producto, Cantidad, ID_Inventario), Sin);
            Sin.Open();
            int Inn = 0;
            Inn = Sim.ExecuteNonQuery();
            Sin.Close();
            return Inn;
        }
        public int EliminarInventario(int ID_Inventario)
        {
            SqlConnection NNi = new SqlConnection(CadenaConexion);
            SqlCommand MMi = new SqlCommand(String.Format("delete Inventario Where ID_Inventario = {0}", ID_Inventario), NNi);
            NNi.Open();
            int Eel = 0;
            Eel = MMi.ExecuteNonQuery();
            NNi.Close();
            return Eel;
        }
        public DataTable inventarioo(int ID_Inventario)
        {
            DataTable InvDT = new DataTable();
            SqlConnection SInn = new SqlConnection(CadenaConexion);
            SqlCommand SImm = new SqlCommand(string.Format("select * from Inventario where ID_Inventario = {0}", ID_Inventario), SInn);
            SInn.Open();
            SImm.ExecuteNonQuery();
            SqlDataAdapter Pee = new SqlDataAdapter(SImm);
            Pee.Fill(InvDT);
            SInn.Close();
            return InvDT;
        }
        public DataTable InventariO(int ID_Inventario)
        {
            DataTable DatInv = new DataTable();
            SqlConnection SInn = new SqlConnection(CadenaConexion);
            SqlCommand SImm = new SqlCommand(string.Format("select * from Inventario where ID_Inventario = {0}", ID_Inventario), SInn);
            SInn.Open();
            SImm.ExecuteNonQuery();
            SqlDataAdapter Pee = new SqlDataAdapter(SImm);
            Pee.Fill(DatInv);
            SInn.Close();
            return DatInv;
        }
    } 
}
