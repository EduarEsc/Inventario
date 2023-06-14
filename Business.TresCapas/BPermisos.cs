using Data.TresCapas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
