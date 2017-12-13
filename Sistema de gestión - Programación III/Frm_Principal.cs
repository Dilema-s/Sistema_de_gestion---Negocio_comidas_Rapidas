using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using CapaNegocios;

namespace Sistema_de_gestión___Programación_III
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal(string usuario)
        {
            InitializeComponent();
            lbpuesto.Text = Convert.ToString(ConfigurationManager.AppSettings["puesto"]);
            lbUsuario.Text = usuario;
            fechaSistema = fechaPrincipal.Value;
        }

        public static DateTime fechaSistema { get; set; }
        

        private void abrirFormularioMozo(string form) {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == form).SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_Usuarios();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }

        }


        private void nuevoMozoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormularioMozo("Frm_Usuarios");
        }

        private void modificarDatosDeMozoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormularioMozo("Frm_Usuarios");
        }

        private void eliminarMozoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormularioMozo("Frm_Mozo");
        }

        //ABRIR MOZO
        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormularioMozo("Frm_Mozo");
        }

        //ABRIR MODIFICAR PRODUCTO
        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_Baja_Modificar_Producto").SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_Baja_Modificar_Producto(0);
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            //abrirFormularioMozo("Frm_Baja_Modificar_Producto");
        }

        //ABRIR ALTA PRODUCTO
        private void button2_Click(object sender, EventArgs e)
        {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_AltaProducto").SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_AltaProducto(0);
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
        }

        //ABRIR COMANDA
        private void button3_Click(object sender, EventArgs e)
        {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_Comanda").SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_Comanda(lbUsuario.Text);
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
        }

        //CERRAR APLICACION
        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //ABRIR USUARIO
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_Usuarios").SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_Usuarios();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
        }

        private void fechaPrincipal_ValueChanged(object sender, EventArgs e)
        {
            Funciones.mOk(this,"La fecha se cambiará para todo el sistema");
            fechaSistema = fechaPrincipal.Value;
        }

        private void mOZOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // FRM compras
        private void button6_Click(object sender, EventArgs e)
        {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_Compra").SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_Compra();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_AltaProducto").SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_AltaProducto(0);
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_Baja_Modificar_Producto").SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_Baja_Modificar_Producto(0);
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
        }

        private void nuevaComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "FrmDatosComanda").SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new FrmDatosComanda();
                frm.ShowDialog();
                frm.WindowState = FormWindowState.Normal;
            }
        }

        private void buscarComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_Comanda").SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_Comanda(lbUsuario.Text);
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_Reportes").SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_Reportes();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
        }
    }
}
