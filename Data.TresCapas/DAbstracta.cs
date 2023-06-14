using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.TresCapas
{
   public abstract class DAbstracta
    {
        private string cadenaConexion;

        public string CadenaConexion
        {
            get { return cadenaConexion = "Data Source = DESKTOP-H6QU3GG; Initial Catalog = InventarioTienda; User ID = EduarEscudero; Password = 2809"; }
            set { cadenaConexion = value; }
        }

    }
}
