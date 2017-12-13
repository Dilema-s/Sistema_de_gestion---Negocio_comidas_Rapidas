using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace Sistema_de_gestión___Programación_III
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Acceso acc = new Acceso();

            if (acc.ValidarAcceso(tbUsuario.Text, tbPass.Text))
            {
                Visible = false;
                //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
                Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_Principal").SingleOrDefault();

                // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
                if (frm != null)
                {
                    frm.Select();
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                }
                else
                {
                    frm = new Frm_Principal(tbUsuario.Text);
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                Funciones.mError(this, "Usuario o Contraseña incorrectos.");
            }
        }
    }
}
