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
    public partial class Frm_Mozo : Form
    {
        public Frm_Mozo()
        {
            InitializeComponent();

            dgMozo.DataSource = Mozo.getAll();
        }

        private void Guardar(object sender, EventArgs e)
        {
            string dni = tbDNI.Text.Trim();
            string nombre = tbNombre.Text.Trim();
            string apellido = tbApellido.Text.Trim();
            string calle = tbCalle.Text.Trim();
            int nro = 0;
            try
            {
                nro = Convert.ToInt32(tbNumero.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en el número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string telefono = tbTelefono.Text.Trim();

            Mozo moz = new Mozo(dni, nombre, apellido, calle, nro, telefono);

            if (moz.Error)
            {
                Funciones.mError(this, moz.Mensaje);
            }
            else
            {
                moz.Save();
                MessageBox.Show(this, "Registro agregado correctamente");
                tbNombre.Text = "";
                tbDNI.Text = "";
                tbCalle.Text = "";
                tbApellido.Text = "";
                tbNumero.Text = "";
                tbTelefono.Text = "";
            }
            dgMozo.DataSource = Mozo.getAll();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_mozo = Convert.ToInt32(tbID.Text);
                Mozo moz = new Mozo(id_mozo);
                if (moz.Error)
                {
                    MessageBox.Show(this, moz.Mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tbNombre.Text = moz.Nombre;
                    tbApellido.Enabled = true;
                    tbApellido.Text = moz.Apellido;
                    tbApellido.Enabled = true;
                    tbCalle.Text = moz.Calle;
                    tbCalle.Enabled = true;
                    tbNumero.Text = moz.Nro.ToString();
                    tbNumero.Enabled = true;
                    tbTelefono.Text = moz.Telefono;
                    tbTelefono.Enabled = true;
                    tbDNI.Text = moz.Dni;
                    tbDNI.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "El id debe ser Nro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgMozo.CurrentRow.Cells["id_mozo"].Value);

            if (id > 0)
            {
                if (Mozo.Eliminar(id))
                {
                    Funciones.mOk(this, "Registro eliminado correctamente");
                }
                else
                {
                    Funciones.mError(this, "Error al eliminar registro");
                }
            }
            dgMozo.DataSource = Mozo.getAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string dni = tbDNI.Text.Trim();
            string nombre = tbNombre.Text.Trim();
            string apellido = tbApellido.Text.Trim();
            string calle = tbCalle.Text.Trim();
            int nro = 0;
            int id = Convert.ToInt32(tbID.Text);
            try
            {
                nro = Convert.ToInt32(tbNumero.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en el número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string telefono = tbTelefono.Text.Trim();

            Mozo moz = new Mozo(id, dni, nombre, apellido, calle, nro, telefono);

            if (moz.Error)
            {
                Funciones.mError(this, moz.Mensaje);
            }
            else
            {
                moz.Actualizar();
                MessageBox.Show(this, "Registro actualizado correctamente");
                tbNombre.Text = "";
                tbDNI.Text = "";
                tbCalle.Text = "";
                tbApellido.Text = "";
                tbNumero.Text = "";
                tbTelefono.Text = "";
            }
            dgMozo.DataSource = Mozo.getAll();
        }
    }
}
