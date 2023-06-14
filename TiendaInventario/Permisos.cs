using Business.TresCapas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaInventario
{
    public partial class Permisos : Form
    {
        public Permisos()
        {
            InitializeComponent();
            ConsultaPermisos();
        }
        private void ConsultaPermisos()
        {
            BPermisos dle = new BPermisos();
            datagridPermisos.DataSource = dle.Permisos();
        }
    }
}
