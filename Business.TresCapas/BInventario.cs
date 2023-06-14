using Data.TresCapas;
using Entity.TresCapas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.TresCapas
{
    public class BInventario
    {
        
        public DataTable Inventario()
        {
            DataTable Ibe = new DataTable();
            DInventario div = new DInventario();
            Ibe = div.ConsultaInventario(); 
            return Ibe;
        }
        public void AgregarInventario(int ID_Producto, int Cantidad)
        {
            DInventario inv = new DInventario();
            int resultados = inv.AgregarInventario(ID_Producto, Cantidad);
            if (resultados == 0)
            {
                MessageBox.Show("No se ha agregado nada al Inventario.");
            }
            else
            {
                MessageBox.Show("Se agrego correctamente al inventario ");
            }
        }
        public void ActulizarInventario(int ID_Inventario, int ID_Producto, int Cantidad)
        {
            DInventario Din = new DInventario();
            int resultados = Din.ActualizarInventario(ID_Inventario, ID_Producto, Cantidad);
            if (resultados == 0) 
            {
                MessageBox.Show("El producto no se actualizo.");
            }
            else
            {
                MessageBox.Show("El producto se actualizo correctamente.");
            }
        }
        public void EliminarInventario(int ID_Inventario)
        {
            DInventario Ind = new DInventario();
            int resultados = Ind.EliminarInventario(ID_Inventario);
            if (resultados == 0)
            {
                MessageBox.Show("El producto no se eliminó.");
            }
            else
            {
                MessageBox.Show("El producto se elimino correctamente.");
            }
        }
        public EInventario Iinventario(int ID_Inventario)
        {
            DataTable DiN = new DInventario().inventarioo(ID_Inventario);
            EInventario Invv = new EInventario();
            foreach (DataRow item in DiN.Rows)
            {
                Invv.ID_Inventario = Convert.ToInt32(item["ID_Inventario"]);
                Invv.Cantidad = Convert.ToInt32(item["Cantidad"]);
            }
            return Invv;
        }
    }
}