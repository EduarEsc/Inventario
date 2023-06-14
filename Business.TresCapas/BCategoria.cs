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
    public class BCategoria
    {
        public void AgregarCategoria(string Descripcion)
        {
            DCategoria cad = new DCategoria();
            int resultados = cad.AgregarCategoria(Descripcion);
            if (resultados == 0)
            {
                MessageBox.Show("La categoria no se a definido.");
            }
            else
            {
                MessageBox.Show("La categoria se establecio correctamente.");
            }
        }
        public DataTable Categoria()
        {
            DCategoria teg = new DCategoria();
            DataTable Dle = teg.ConsultaCategorias();
            return Dle;
        }
        public ECategoria CCategoria(int ID_Categoria)
        {
            DataTable Dcv = new DCategoria().Valor(ID_Categoria);
            ECategoria Ectr = new ECategoria();
            foreach (DataRow item in Dcv.Rows)
            {
                Ectr.ID_Categoria = Convert.ToInt32(item["ID_Categoria"]);
                Ectr.Descripcion = (item["Descripcion"]).ToString();
            }
            return Ectr;
        }

        public void EliminarCategoria(int ID_Categoria)
        {
            DCategoria eLL = new DCategoria();
            int resultados = eLL.EliminarCategoria(ID_Categoria);
            if (resultados == 0)
            {
                MessageBox.Show("La categoria no se elimino.");
            }
            else
            {
                MessageBox.Show("La categoria se eliminado correctamente.");
            }
        }
        public void ActualizaCategoria(int id, string descr)
        {
            DCategoria eLL = new DCategoria();
            int resultados = eLL.ActualizaCategoria(id,descr);
            if (resultados == 0)
            {
                MessageBox.Show("La categoria no se actualizo.");
            }
            else
            {
                MessageBox.Show("La categoria se actualizo correctamente.");
            }
        }
    }
}
