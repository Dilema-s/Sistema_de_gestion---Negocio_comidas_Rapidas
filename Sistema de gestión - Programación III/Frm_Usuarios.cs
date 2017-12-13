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
    public partial class Frm_Usuarios : Form
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
            cbCargo.DataSource = Cargo.cargarComboBox();
            
            cbCargo.DisplayMember = "cargo";
            cbCargo.ValueMember = "id_cargo";
            dgUsuario.DataSource = Persona.getAll();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidadPassword(tbPass.Text, tbRePass.Text))
            {
                string nombre = tbNombre.Text.Trim();
                string apellido = tbApellido.Text.Trim();
                int dni = Convert.ToInt32(tbDNI.Text);
                int cargo = cbCargo.SelectedIndex + 1;
                string calle = tbCalle.Text;
                string altura = tbAltura.Text;
                string telefono = tbTelefono.Text.Trim();
                DateTime fechaIngreso = dtpIngreso.Value;

                // Doy de alta una persona
                Persona persona = new Persona(nombre, apellido, dni, cargo, calle, altura, telefono, fechaIngreso);

                // Si ocurre un error...
                if (persona.Error)
                {
                    // Imprimo todos los mensajes de error
                    foreach (string msj in persona.Mensajes)
                    {
                        Funciones.mError(this, msj);
                    }

                }
                else
                {
                    int id;
                    // Guardo el id de la persona que doy de alta para relacioarlo con el acceso
                    id = persona.Save();
                    // Doy de alta el acceso utilizando el id de la persona que di de alta
                    Acceso acc = new Acceso(id, tbUsuario.Text, tbPass.Text);
                    // Si ocurre un error...
                    if (acc.Error)
                    {
                        // Imprimo todos los mensajes de error...
                        foreach (string msj in acc.Mensajes)
                        {
                            Funciones.mError(this, msj);
                        }
                        // ... y doy de baja la persona dada de alta
                        if (persona.Eliminar(id))
                        {
                            Funciones.mError(this, "Error al eliminar el registro persona");
                        }
                    }
                    else
                    {
                        try
                        {
                            acc.Save();
                            Funciones.mOk(this, "Registro guardado correctamente");
                            tbNombre.Text = "";
                            tbApellido.Text = "";
                            tbDNI.Text = "";
                            cbCargo.SelectedIndex = 0;
                            tbApellido.Text = "";
                            tbCalle.Text = "";
                            tbAltura.Text = "";
                            tbTelefono.Text = "";
                            tbUsuario.Text = "";
                            tbPass.Text = "";
                            tbRePass.Text = "";
                        }
                        catch (Exception ex)
                        {

                            Funciones.mError(this, "Error al guardar acceso: " + ex.Message);
                        }
                        
                        
                    }

                }
                dgUsuario.DataSource = Persona.getAll();
            }
            else
            {
                Funciones.mError(this, "Las contraseñas no coinciden");
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_persona = Convert.ToInt32(tbID.Text);
                Persona persona = new Persona(id_persona);
                if (persona.Error)
                {
                    foreach(string msj in persona.Mensajes)
                    {
                        Funciones.mError(this, msj);
                    }
                    
                }
                else
                {
                    tbNombre.Text = persona.Nombre;
                    tbApellido.Enabled = true;
                    tbApellido.Text = persona.Apellido;
                    tbApellido.Enabled = true;
                    tbDNI.Text = persona.dni.ToString();
                    tbDNI.Enabled = true;
                    cbCargo.SelectedIndex = persona.Cargo;
                    cbCargo.Enabled = true;
                    tbCalle.Text = persona.Calle;
                    tbCalle.Enabled = true;
                    tbAltura.Text = persona.Altura;
                    tbAltura.Enabled = true;
                    tbTelefono.Text = persona.Telefono;
                    tbTelefono.Enabled = true;
                    dtpIngreso.Value = persona.FechaIngreso;
                    dtpIngreso.Enabled = true;
                    tbUsuario.Enabled = false;
                    tbPass.Enabled = false;
                    tbRePass.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "El id debe ser Nro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text.Trim();
            string apellido = tbApellido.Text.Trim();
            int dni = Convert.ToInt32(tbDNI.Text);
            int cargo = cbCargo.SelectedIndex;
            string calle = tbCalle.Text;
            string altura = tbAltura.Text;
            string telefono = tbTelefono.Text.Trim();
            DateTime fechaIngreso = dtpIngreso.Value;
            int id = Convert.ToInt32(tbID.Text);

            Persona persona = new Persona(id, nombre, apellido, dni, cargo, calle, altura, telefono, fechaIngreso);

            if (persona.Error)
            {
                foreach(string msj in persona.Mensajes)
                {
                    Funciones.mError(this, msj);
                }
                
            }
            else
            {
                persona.Actualizar();
                MessageBox.Show(this, "Registro actualizado correctamente");
                tbNombre.Text = "";
                tbApellido.Text = "";
                tbDNI.Text = "";
                cbCargo.SelectedIndex = 0;
                tbApellido.Text = "";
                tbCalle.Text = "";
                tbAltura.Text = "";
                tbTelefono.Text = "";
                tbUsuario.Text = "";
                tbPass.Text = "";
                tbRePass.Text = "";
            }
            dgUsuario.DataSource = Persona.getAll();
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_ActualizarContraseña").SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_ActualizarContraseña();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
        }
    }
    
}
