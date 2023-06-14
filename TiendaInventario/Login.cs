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

namespace TiendaInventario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            BNegocio nee = new BNegocio();
            EUsuarios os = nee.Login(tbClave.Text);
            if (os.Contraseña == tbContra.Text)
            {
                menuPrincipal mp = new menuPrincipal(os);
                mp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("La clave o contraseña son erroneas, favor de cambiarlas e intentar de nuevo.");

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
