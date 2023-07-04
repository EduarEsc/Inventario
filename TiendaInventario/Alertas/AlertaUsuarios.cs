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
    public partial class AlertaUsuarios : Form
    {
        int _ID = 0;
        public AlertaUsuarios(int idUsuario)
        {
            _ID = idUsuario;
            InitializeComponent();
            DescripcionPermiso();
            IUsuario();
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
            CBPermisoEditar.DataSource = lsPer;
            CBPermisoEditar.DisplayMember = "Descripcion";
            CBPermisoEditar.ValueMember = "ID_Permisos";
        }
        public void IUsuario()
        {
            BUsuarios Buser = new BUsuarios();
            EUsuarios U = Buser.Consultausuario(_ID);
            txtAMaternoEditar.Text = U.ApMat;
            txtApaternoEditar.Text = U.ApPat;
            txtNombreeditar.Text = U.Nombre;
            txtContraseñaEditar.Text = U.Contraseña;
            int indiceBuscado = 0;

            for (int i = 0; i < CBPermisoEditar.Items.Count; i++)
            {
                   EPermiso objeto = (EPermiso)CBPermisoEditar.Items[i];

                if (objeto.ID_Permisos == U.ID_Permisos)
                {
                    indiceBuscado = i;
                    break;
                }
            }

            CBPermisoEditar.SelectedIndex = indiceBuscado;


        }
        private void btnEditarUser_Click(object sender, EventArgs e)
        {
            if (txtNombreeditar.Text == "")
            {
                MessageBox.Show("Debe completar los espacios requeridos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtApaternoEditar.Text == "")
            {
                MessageBox.Show("Debe completar la descripción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAMaternoEditar.Text == "")
            {
                MessageBox.Show("Debe completar el codigo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtContraseñaEditar.Text == "")
            {
                MessageBox.Show("Debe completar el precio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                BUsuarios Buser = new BUsuarios();

                EPermiso boxSeleccionado = (EPermiso)CBPermisoEditar.SelectedItem;
                Buser.Actualizausuario(_ID,boxSeleccionado.ID_Permisos, txtNombreeditar.Text, txtApaternoEditar.Text, txtAMaternoEditar.Text, txtContraseñaEditar.Text);
                this.Hide();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }
    }
}
