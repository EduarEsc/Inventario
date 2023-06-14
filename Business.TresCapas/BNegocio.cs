using Data.TresCapas;
using Entity.TresCapas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.TresCapas
{
   public  class BNegocio
    {
        public EUsuarios Login(string user)
        {
            EUsuarios ss = new EUsuarios();
            DDatos tt = new DDatos();
            DataTable bb = tt.ConsultaUsuarios(user);
            foreach (DataRow item in bb.Rows)
            {
                ss.Nombre = Convert.ToString(item["Nombre"]);
                ss.Contraseña = Convert.ToString(item["Contraseña"]);
                ss.ApPat = Convert.ToString(item["ApPat"]);
                ss.ApMat = Convert.ToString(item["ApMat"]);
            }
            return ss;
        }
        public void Inventario()
        {
            
        }
    }
}
