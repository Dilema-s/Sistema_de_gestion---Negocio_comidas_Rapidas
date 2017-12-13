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
    public partial class Frm_ActualizarContraseña : Form
    {
        public Frm_ActualizarContraseña()
        {
            InitializeComponent();
        }

        private void btnAceptarNewPass_Click(object sender, EventArgs e)
        {
            Acceso acc = new Acceso();

            if (acc.ValidarAcceso(tbUsuario.Text, tbOldPass.Text))
            {
                if (Validaciones.ValidadPassword(tbNewPass.Text, tbReNewPass.Text))
                {
                    if(acc.ActualizarAcceso(tbUsuario.Text, tbNewPass.Text))
                    {
                        Funciones.mOk(this, "Acceso actualizado correctamente");
                        tbUsuario.Text = "";
                        tbOldPass.Text = "";
                        tbNewPass.Text = "";
                        tbReNewPass.Text = "";
                    }
                    else
                    {
                        Funciones.mError(this, "Error al actualizar acceso");
                    }
                }else
                {
                    Funciones.mError(this, "Las contraseñas deben coincidir");
                }
            }else
            {
                Funciones.mError(this, "Usuario o contraseña incorrectos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
