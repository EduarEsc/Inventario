using Business.TresCapas;
using Data.TresCapas;
using Entity.TresCapas;
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
    public partial class menuPrincipal : Form
    {
        EUsuarios usuarios;
       

        public menuPrincipal()
        {
            InitializeComponent();
        }

        public menuPrincipal(EUsuarios es)
        {
            InitializeComponent();
            usuarios = es;
            labelRegresa.Text = usuarios.Nombre + " " + usuarios.ApPat + " " + usuarios.ApMat;
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void labelRegresa_Click(object sender, EventArgs e)
        {

        }

        private void btInventario_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            inv.ShowDialog();
        }

        private void btProducto_Click(object sender, EventArgs e)
        {
            Productos pro = new Productos();
            pro.ShowDialog();
        }

        private void btVenta_Click(object sender, EventArgs e)
        {
            Venta ven = new Venta();
            ven.ShowDialog();
        }

        private void btCate_Click(object sender, EventArgs e)
        {
            Categorias cate = new Categorias();
            cate.ShowDialog();
        }

        private void btPermisos_Click(object sender, EventArgs e)
        {
            Permisos perm = new Permisos();
            perm.ShowDialog();
        }
    }
}
