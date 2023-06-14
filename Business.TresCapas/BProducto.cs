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
    public class BProducto
    {
        public void AgregaProducto(int ID_Categoria, string NombreProducto, string Caracteristicas, string CodigoBarra, string Precio)
        {
            DProductos dpo = new DProductos();
            int Resultado = dpo.AgregaProducto(ID_Categoria, NombreProducto, Caracteristicas, CodigoBarra, Precio);
            if (Resultado == 0)
            {
                MessageBox.Show("El producto no se agrego correctamente.");
            }
            else
            {
                MessageBox.Show("El producto fue agregado correctamente.");
            }
        }
        public void ActualizarProducto(int ID_Producto, int ID_Categoria, string NombreProducto, string Caracteristicas, string CodigoBarra, string Precio)
        {

            DProductos Dto = new DProductos();
            int Resultado = Dto.ActualizarProducto(ID_Producto, ID_Categoria, NombreProducto, Caracteristicas, CodigoBarra, Precio);
            if (Resultado == 0)
            {
                MessageBox.Show("El producto no se actualizo correctamente.");
            }
            else
            {
                MessageBox.Show("El producto se actualizo correctamente.");
            }
        } 
        public DataTable Productos()
        {
            DProductos dpr = new DProductos();
            DataTable tle = dpr.ConsultaProductos();
            return tle;
        }
        public void EliminarProductos(int ID_Producto)
        {
            DProductos dpr = new DProductos();
            int resultados = dpr.EliminarProducto(ID_Producto);
            if (resultados == 0)
            {
                MessageBox.Show("El producto no se elimino.");
            }
            else
            {
                MessageBox.Show("El producto se a eliminado correctamente.");
            }
        }
        public EProducto Producto(int ID_Producto)
        {
            DataTable DTpr = new DProductos().producto(ID_Producto);
            EProducto EpR = new EProducto();
            foreach (DataRow item in DTpr.Rows)
            {
                EpR.ID_Producto = Convert.ToInt32(item["ID_Producto"]);
                EpR.Id_Categoria = Convert.ToInt32(item["ID_Categoria"]);
                EpR.NombreProducto = (item["NombreProducto"]).ToString();
                EpR.Caracteristicas = (item["Caracteristicas"]).ToString();
                EpR.CodigoBarra = (item["CodigoBarra"]).ToString();
                EpR.Precio = Convert.ToDecimal(item["Precio"]);
            }
            return EpR;
        }
    }
}
