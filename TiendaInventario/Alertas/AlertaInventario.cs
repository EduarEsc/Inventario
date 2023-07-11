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
            listaCategoria();
            Iinventario();

        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (CBClaProd.Text == "")
            {
                MessageBox.Show("Debe completar la los espacios requeridos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            BInventario BiN = new BInventario();
            BiN.ActulizarInventario(Convert.ToInt32(_id), Convert.ToInt32(CBClaProd.Text), Convert.ToInt32(tBCant.Text));
            this.Hide();
        }
        public void listaCategoria()
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
            CBClaProd.DataSource = lsCat;
            CBClaProd.DisplayMember = "Descripcion";
            CBClaProd.ValueMember = "ID_Categoria";
        }
        public void Iinventario()
        {
            BInventario Inen = new BInventario();
            EInventario InE = Inen.Iinventario(_id);
            CBClaProd.Text = InE.ID_Producto.ToString();
            tBCant.Text = InE.Cantidad.ToString();

        }
    }
}
