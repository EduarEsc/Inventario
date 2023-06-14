using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.TresCapas
{
   public class EProducto
    {
        public int ID_Producto { get; set; }
        public int Id_Categoria { get; set; }
        public string NombreProducto { get; set; }
        public string Caracteristicas  { get; set; }
        public string CodigoBarra { get; set; }
        public decimal Precio { get; set; }
    }
}
