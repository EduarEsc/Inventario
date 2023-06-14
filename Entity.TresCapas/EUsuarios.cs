using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.TresCapas
{
   public  class EUsuarios
    {
        public int ID_Usuarios { get; set; }
        public int ID_Permisos { get; set; }
        public string Nombre  { get; set; }
        public string ApPat { get; set; }
        public string ApMat { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Contraseña  { get; set; }
    }
}

