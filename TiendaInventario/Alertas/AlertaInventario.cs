using Business.TresCapas;
using Data.TresCapas;
using Entity.TresCapas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaInventario.Alertas
{
    public partial class AlertaInventario : Form
    {
        int _id;
        public AlertaInventario(int ID)
        {
            InitializeComponent();
            _id = ID;
            Iinventario();
        }
        public void Iinventario()
        {
            BInventario Inen = new BInventario();
            EInventario InE = Inen.Iinventario(_id);
            CBClaProd.Text = InE.ID_Producto.ToString();
            tBCant.Text = InE.Cantidad.ToString();

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            BInventario BiN = new BInventario();
            BiN.ActulizarInventario(Convert.ToInt32(_id), Convert.ToInt32(CBClaProd.Text), Convert.ToInt32(tBCant.Text));
            this.Hide();
        }
    }
}
