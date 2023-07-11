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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            Consultausuarios();
            DescripcionPermiso();

        }

        public void DescripcionPermiso()
        {
            BPermisos Bpermiso = new BPermisos();
            List<EPermiso> lsPer = new List<EPermiso>();

            foreach (DataRow item in Bpermiso.Permisos().Rows)
            {
                EPermiso p = new EPermiso();
                p.ID_Permisos = Convert.ToInt32(item["ID_Permisos"]);
                p.Descripcion = item["Descripcion"].ToString();
                lsPer.Add(p);
            }
            CBPermiso.DataSource = lsPer;
            CBPermiso.DisplayMember = "Descripcion";
            CBPermiso.ValueMember = "ID_Permisos";
        }
        private void Consultausuarios()
        {
            BUsuarios Buser = new BUsuarios();
            datagridUser.DataSource = Buser.ConsultaUsuarios();
            datagridUser.Columns["ID_Usuarios"].DisplayIndex = 0;
            datagridUser.Columns["Descripcion"].DisplayIndex = 1;
            datagridUser.Columns["Nombre"].DisplayIndex = 2;
            datagridUser.Columns["ApPat"].DisplayIndex = 3;
            datagridUser.Columns["ApMat"].DisplayIndex = 4;
            datagridUser.Columns["FechaIngreso"].DisplayIndex = 5;
            datagridUser.Columns["Contraseña"].DisplayIndex = 6;
            datagridUser.Columns["Editar"].DisplayIndex = 7;
            datagridUser.Columns[0].HeaderText = "Editar";
            datagridUser.Columns[1].HeaderText = "Clave usuario";
            datagridUser.Columns[2].HeaderText = "Permiso";
            datagridUser.Columns[3].HeaderText = "Nombre";
            datagridUser.Columns[4].HeaderText = "Apaterno";
            datagridUser.Columns[5].HeaderText = "Amaterno";
            datagridUser.Columns[6].HeaderText = "fecha";
            datagridUser.Columns[7].HeaderText = "Contraseña";


            txtNombre.Text = "";
            txtAMaterno.Text = "";
            txtApaterno.Text = "";
            txtContraseña.Text = "";
        }
        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            
            
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe completar el espacio requerido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (txtApaterno.Text == "")
            {
                MessageBox.Show("Debe completar el espacio requerido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (txtAMaterno.Text == "")
            {
                MessageBox.Show("Debe completar el espacio requerido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Debe completar el espacio requerido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                BUsuarios Buser = new BUsuarios();

                EPermiso boxSeleccionado = (EPermiso)CBPermiso.SelectedItem;
                Buser.Agregarusuario(boxSeleccionado.ID_Permisos, txtNombre.Text,txtApaterno.Text,txtAMaterno.Text,txtContraseña.Text);
                Consultausuarios();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }

        private void datagridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridUser.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                AlertaUsuarios Auser = new AlertaUsuarios(Convert.ToInt32(datagridUser.CurrentRow.Cells["ID_Usuarios"].Value.ToString()));
                Auser.ShowDialog();
                Consultausuarios();
            }
        }
    }
}
