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
using TiendaInventario.Alertas;

namespace TiendaInventario
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
            ConsultaCategorias();
        }

        public void ConsultaCategorias()
        {
            BCategoria bct = new BCategoria();
            datagridCategoria.DataSource = bct.Categoria();
            datagridCategoria.Columns["ID_Categoria"].DisplayIndex = 0;
            datagridCategoria.Columns["Descripcion"].DisplayIndex = 1;
            datagridCategoria.Columns["EDITAR"].DisplayIndex = 2;
            datagridCategoria.Columns["ELIMINAR"].DisplayIndex = 3;
            datagridCategoria.Columns[0].HeaderText = "EDITAR";
            datagridCategoria.Columns[1].HeaderText = "ELIMINAR";
            datagridCategoria.Columns[2].HeaderText = "ID_Categoria";
            datagridCategoria.Columns[3].HeaderText = "Descripcion";            
            tBDesc.Text = "";            
        }
        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (tBDesc.Text == "")
            {
                MessageBox.Show("Debe completar la los espacios requeridos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                BCategoria tgo = new BCategoria();
                tgo.AgregarCategoria(tBDesc.Text);
                ConsultaCategorias();
            }
            catch (Exception ion)
            {
                MessageBox.Show(ion.Message);
            }
        }

        private void datagridCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int ID = Convert.ToInt32(datagridCategoria.SelectedRows[0].Cells[0].Value);
            //string categoria = Convert.ToString(datagridCategoria.SelectedRows[0].Cells[1].Value);
            //AlertaCategoria AlC = new AlertaCategoria(ID, categoria);
            //AlC.ShowDialog();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {

        }

        private void datagridCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridCategoria.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                AlertaCategoria Act = new AlertaCategoria(Convert.ToInt32(datagridCategoria.CurrentRow.Cells["ID_Categoria"].Value.ToString()));
                Act.ShowDialog();
                ConsultaCategorias();
            }
            else if (datagridCategoria.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                new BCategoria().EliminarCategoria(Convert.ToInt32(datagridCategoria.CurrentRow.Cells["ID_Categoria"].Value.ToString()));
                ConsultaCategorias();
            }
        }

        private void tBDesc_KeyPress(object sender, KeyPressEventArgs e)
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
