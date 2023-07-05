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
using TiendaInventario.Alertas;

namespace TiendaInventario
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            ConsultaInventario();
            ClaveProducto();
        }
        
        private void datagridInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridInventario.Columns[e.ColumnIndex].Name == "Editar")
            {
                AlertaInventario Ainv = new AlertaInventario(Convert.ToInt32(datagridInventario.CurrentRow.Cells["ID_Inventario"].Value.ToString()));
                Ainv.ShowDialog();
                ConsultaInventario();
            }
            else if (datagridInventario.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                new BInventario().EliminarInventario(Convert.ToInt32(datagridInventario.CurrentRow.Cells["ID_Inventario"].Value.ToString()));
                ConsultaInventario();
            }
        }

        private void ConsultaInventario()
        {
            BInventario Biv = new BInventario();
            datagridInventario.DataSource = Biv.Inventario();
            datagridInventario.Columns["ID_Inventario"].DisplayIndex = 0;
            datagridInventario.Columns["NombreProducto"].DisplayIndex = 1;
            datagridInventario.Columns["Descripcion"].DisplayIndex = 2;
            datagridInventario.Columns["Cantidad"].DisplayIndex = 3;
            datagridInventario.Columns["Editar"].DisplayIndex = 4;
            datagridInventario.Columns["Eliminar"].DisplayIndex = 5;
            datagridInventario.Columns[0].HeaderText = "Editar";
            datagridInventario.Columns[1].HeaderText = "Eliminar";
            datagridInventario.Columns[2].HeaderText = "Clave Inventario";
            datagridInventario.Columns[3].HeaderText = "Nombre Producto";
            datagridInventario.Columns[4].HeaderText = "Categoria";
            datagridInventario.Columns[5].HeaderText = "Cantidad";

            CBProd.Text = "";
            tBCantidad.Text = "";
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            string Cantidad;
            Cantidad = tBCantidad.Text;
            EProducto ProductoSeleccionado = (EProducto)CBProd.SelectedItem;
            if (Cantidad == "")
            {
                MessageBox.Show("Debe completar la los espacios requeridos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                BInventario Binn = new BInventario();
                Binn.AgregarInventario(ProductoSeleccionado.ID_Producto, Convert.ToInt32(tBCantidad.Text));
                ConsultaInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void tBCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255 ))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        public void ClaveProducto()
        {
            
            List<EProducto> Lin = new List<EProducto>();
            BProducto bProducto = new BProducto();
            
            foreach  (DataRow item in bProducto.Productos().Rows)
            {
                EProducto iNV = new EProducto();
                iNV.NombreProducto = Convert.ToString(item["NombreProducto"]);
                iNV.ID_Producto = Convert.ToInt32(item["ID_Producto"]);
                Lin.Add(iNV);
            }
            CBProd.DataSource = Lin;
            CBProd.DisplayMember = "NombreProducto";
            CBProd.ValueMember = "ID_Producto";
        }
        private void Inventario_Load(object sender, EventArgs e)
        {

        }
    }
}
