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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void btReMen_Click(object sender, EventArgs e)
        {
            menuPrincipal menuPrincipal = new menuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
