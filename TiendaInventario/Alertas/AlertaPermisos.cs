using Business.TresCapas;
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
    public partial class AlertaPermisos : Form
    {
        int _ID;
        public AlertaPermisos(int id)
        {
            InitializeComponent();
            _ID = id;
            Permisos();
        }
        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (txtPermisos.Text == "")
            {
                MessageBox.Show("Debe completar la los espacios requeridos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            BPermisos Bper = new BPermisos();
            Bper.ActualizaPermisos(Convert.ToInt32(_ID), Convert.ToString(txtPermisos.Text));
            this.Hide();
        }
        public void Permisos()
        {
            BPermisos Bper = new BPermisos();
            EPermiso Eper = Bper.ValorPer(_ID);
            txtPermisos.Text = Eper.Descripcion.ToString();
        }
    }
}
