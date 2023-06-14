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

namespace TiendaInventario.Alertas
{
    public partial class AlertaCategoria : Form
    {
        int _ID;
        public AlertaCategoria(int id)
        {
            InitializeComponent();
            _ID = id;
            Categoria();
        }
        private void Categoria()
        {
            BCategoria Bct = new BCategoria();
            ECategoria Ect = Bct.CCategoria(_ID);
            TBDescripcion.Text = Ect.Descripcion.ToString();
        }
        private void btActualizar_Click(object sender, EventArgs e)
        {
            BCategoria AcCat = new BCategoria();
            AcCat.ActualizaCategoria(Convert.ToInt32(_ID), Convert.ToString(TBDescripcion.Text));
            this.Hide();
        }

        private void AlertaCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
