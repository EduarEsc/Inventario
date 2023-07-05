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
using TiendaInventario.Alertas;

namespace TiendaInventario
{
    public partial class Permisos : Form
    {
        public Permisos()
        {
            InitializeComponent();
            ConsultaPermisos();
        }
        private void datagridPermisos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridPermisos.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                AlertaPermisos Aper = new AlertaPermisos(Convert.ToInt32(datagridPermisos.CurrentRow.Cells["ID_Permisos"].Value.ToString()));
                Aper.ShowDialog();
                ConsultaPermisos();
            }
        }
        private void ConsultaPermisos()
        {
            BPermisos Bper = new BPermisos();
            datagridPermisos.DataSource = Bper.Permisos();
            datagridPermisos.Columns["ID_Permisos"].DisplayIndex = 0;
            datagridPermisos.Columns["Descripcion"].DisplayIndex = 1;
            datagridPermisos.Columns["EDITAR"].DisplayIndex = 2;
            datagridPermisos.Columns[0].HeaderText = "EDITAR";
            datagridPermisos.Columns[1].HeaderText = "ID_Categoria";
            datagridPermisos.Columns[2].HeaderText = "Descripcion";

            txtDescPer.Text = "";
        }
        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDescPer.Text == "")
            {
                MessageBox.Show("Debe completar la los espacios requeridos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                BPermisos Bper = new BPermisos();
                Bper.AgregarPermisos(txtDescPer.Text);
                ConsultaPermisos();
            }
            catch (Exception ion)
            {
                MessageBox.Show(ion.Message);
            }
        }
        private void CBPermisos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
