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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            ConsultaProductos();
            DescripcionCategoria();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            string Producto;
            Producto = tBProducto.Text;
            if (Producto == "")
            {
                MessageBox.Show("Debe completar los espacios requeridos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string Descripcion;
            Descripcion = tBDesc.Text;
            if (Descripcion == "")
            {
                MessageBox.Show("Debe completar la descripción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string Codigo;
            Codigo = tBCodi.Text;
            if (Codigo == "")
            {
                MessageBox.Show("Debe completar el codigo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string Precio;
            Precio = tBPrec.Text;
            if (Precio == "")
            {
                MessageBox.Show("Debe completar el precio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                BProducto bpo = new BProducto();

                ECategoria boxSeleccionado = (ECategoria)CBCategoria.SelectedItem;
                bpo.AgregaProducto(boxSeleccionado.ID_Categoria, tBProducto.Text, tBDesc.Text, tBCodi.Text, 
                    tBPrec.Text);
                ConsultaProductos();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                
            }            
        }
        private void ConsultaProductos()
        {
            BProducto bProducto = new BProducto();
            datagritProductos.DataSource = bProducto.Productos();
            datagritProductos.Columns["ID_Producto"].DisplayIndex = 0;
            datagritProductos.Columns["ID_Categoria"].DisplayIndex = 1;
            datagritProductos.Columns["NombreProducto"].DisplayIndex = 2;
            datagritProductos.Columns["Caracteristicas"].DisplayIndex = 3;
            datagritProductos.Columns["CodigoBarra"].DisplayIndex = 4;
            datagritProductos.Columns["Precio"].DisplayIndex = 5;
             datagritProductos.Columns["Editar"].DisplayIndex = 6;
            datagritProductos.Columns["Eliminar"].DisplayIndex = 7;
            datagritProductos.Columns[0].HeaderText = "Editar";
            datagritProductos.Columns[1].HeaderText = "Eliminar";
            datagritProductos.Columns[2].HeaderText = "Clave Producto";
            datagritProductos.Columns[3].HeaderText = "Clave Categoria";
            datagritProductos.Columns[4].HeaderText = "Producto";
            datagritProductos.Columns[5].HeaderText = "Descripcion";
            datagritProductos.Columns[6].HeaderText = "Codigo";
            datagritProductos.Columns[7].HeaderText = "Precio";
            
            
            tBProducto.Text = "";
            tBDesc.Text = "";
            tBCodi.Text = "";
            tBPrec.Text = "";
        }
        private void datagritProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void datagritProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(datagritProductos.Columns[e.ColumnIndex].Name == "Editar")
            {
                Alerta_Productos Apr = new Alerta_Productos(Convert.ToInt32(datagritProductos.CurrentRow.Cells["ID_Producto"].Value.ToString()));
                Apr.ShowDialog();
                ConsultaProductos();
            }
            else if(datagritProductos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                new BProducto().EliminarProductos(Convert.ToInt32(datagritProductos.CurrentRow.Cells["ID_Producto"].Value.ToString()));
                ConsultaProductos();
            }
            
        }
        public void DescripcionCategoria()
        {
            BCategoria Bct = new BCategoria();
            List<ECategoria> lsCat = new List<ECategoria>();
           
            foreach (DataRow item in Bct.Categoria().Rows)
            {
                ECategoria cat = new ECategoria();
                cat.ID_Categoria = Convert.ToInt32(item["ID_Categoria"]);
                cat.Descripcion = item["Descripcion"].ToString();
                lsCat.Add(cat);
            }
            CBCategoria.DataSource = lsCat;
            CBCategoria.DisplayMember = "Descripcion";
            CBCategoria.ValueMember = "ID_Categoria";
        }
        private void CBCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Agregue el formato correcto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void tBProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Agregue el formato correcto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void tBDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Agregue el formato correcto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void tBCodi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Agregue el formato correcto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void tBPrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 248) || (e.KeyChar >= 252 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }        
}

