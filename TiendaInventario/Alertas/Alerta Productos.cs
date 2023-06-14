using Business.TresCapas;
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

namespace TiendaInventario.Alertas
{
    public partial class Alerta_Productos : Form
    {
        int _ID;
        public Alerta_Productos(int id)
        {
            InitializeComponent();
            _ID = id;
            Producto();
        }        
        public void Producto()
        {
            BProducto Bpr = new BProducto();
            EProducto Epd = Bpr.Producto(_ID);
            TxCategoria.Text = Epd.Id_Categoria.ToString();
            TxProducto.Text = Epd.NombreProducto.ToString();
            TxDescripcion.Text = Epd.Caracteristicas.ToString();
            TxCodigo.Text = Epd.CodigoBarra.ToString();
            TxPrecio.Text = Epd.Precio.ToString();
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            BProducto Nmat = new BProducto();
            Nmat.ActualizarProducto(Convert.ToInt32(_ID), Convert.ToInt32(TxCategoria.Text), TxProducto.Text, TxDescripcion.Text, TxCodigo.Text, TxPrecio.Text);
            this.Hide();
            
        }

        private void Alerta_Productos_Load(object sender, EventArgs e)
        {

        }

        private void TxProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
