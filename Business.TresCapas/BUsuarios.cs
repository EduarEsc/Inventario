using Data.TresCapas;
using Entity.TresCapas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.TresCapas
{
    public class BUsuarios
    {
        public BUsuarios()
        {

        }
        public void Agregarusuario(int ID_permiso, string nombre, string apaterno, string amaterno, string contraseña)
        {
            DUsuarios Duser = new DUsuarios();
            int resultados = Duser.AgregarUsuario(ID_permiso, nombre, apaterno, amaterno, contraseña);
            if (resultados == 0)
            {
                MessageBox.Show("El usurio no se ha registrado correctamente.");
            }
            else
            {
                MessageBox.Show("El usurio se ha registrado correctamente.");
            }
        }
        public DataTable ConsultaUsuarios()
        {
            DUsuarios Duser = new DUsuarios();
            DataTable dt = Duser.ConsultaUsuarios();
            return dt;
        }
        public EUsuarios Consultausuario(int IdUsuario)
        {
            DataTable dt = new DUsuarios().ConsultaUsuario(IdUsuario);
            EUsuarios Euser = new EUsuarios();
            foreach (DataRow item in dt.Rows)
            {
                Euser.ID_Usuarios = Convert.ToInt32(item["ID_Usuarios"]);
                Euser.ID_Permisos = Convert.ToInt32(item["ID_Permisos"]);
                Euser.Nombre = (string)(item["Nombre"]);
                Euser.ApPat = (item["ApPat"]).ToString();
                Euser.ApMat = (item["ApMat"]).ToString();
                Euser.Contraseña = (item["Contraseña"]).ToString();
            }
            return Euser;
        }
        public void Actualizausuario(int id, int ID_permiso, string nombre, string apaterno, string amaterno, string contraseña)
        {
            DUsuarios Duser = new DUsuarios();
            int resultados = Duser.ActualizaUsurio(id, ID_permiso, nombre, apaterno, amaterno, contraseña);
            if (resultados == 0)
            {
                MessageBox.Show("El usurio no fue actualizado.");
            }
            else
            {
                MessageBox.Show("El usurio actualizado correctamente.");
            }
        }
    }
}
