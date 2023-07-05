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
   public class BPermisos
    {
        public DataTable Permisos()
        {
            DataTable Ple = new DataTable();
            DPermisos dper = new DPermisos();
            Ple = dper.ConsultaPermisos();
            return Ple;
        }
        public void AgregarPermisos( string Descripcion)
        {
            DPermisos Dper = new DPermisos();
            int resultados = Dper.AgregarPermisos(Descripcion);
            if (resultados == 1)
            {
                MessageBox.Show("El permiso se ha establecido correctamente.");
            }
            else
            {
                MessageBox.Show("El permiso no se ha establecido correctamente.");
            }
        }
        public void ActualizaPermisos(int id, string descr)
        {
            DPermisos Dper = new DPermisos();
            int resultados = Dper.ActualizaPermisos(id, descr);
            if (resultados == 0)
            {
                MessageBox.Show("La categoria no se actualizo.");
            }
            else
            {
                MessageBox.Show("La categoria se actualizo correctamente.");
            }
        }
        public EPermiso ValorPer(int ID_Permisos)
        {
            DataTable dt = new DPermisos().ValorPER(ID_Permisos);
            EPermiso Eper = new EPermiso();
            foreach (DataRow item in dt.Rows)
            {
                Eper.ID_Permisos = Convert.ToInt32(item["ID_Permisos"]);
                Eper.Descripcion = (item["Descripcion"]).ToString();
            }
            return Eper;
        }
    }
}
