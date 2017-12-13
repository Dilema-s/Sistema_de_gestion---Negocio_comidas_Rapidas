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
using System.Configuration;

namespace Sistema_de_gestión___Programación_III
{
    public partial class Frm_Comanda : Form
    {
        public Frm_Comanda(string nombreUsuario)
        {
            InitializeComponent();
            lbpuesto.Text = Convert.ToString(ConfigurationManager.AppSettings["puesto"]);
            fecha.Value = Frm_Principal.fechaSistema;
            actualizarListaComanda();
            lbUsuario.Text = nombreUsuario;
        }



        private void actualizarListaComanda()
        {
            try
            {
                if (Comanda.getAll(Frm_Principal.fechaSistema) != null)
                {
                    dgComanda.DataSource = Comanda.getAll(Frm_Principal.fechaSistema).Tables[0];
                }
                else
                {
                    Funciones.mError(this, "ERROR AL CARGAR LAS COMANDAS");
                }

            }
            catch
            {
                Funciones.mError(this, "ERROR AL CARGAR LAS COMANDAS");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //ver Comanda
        private void button4_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            dgComanda.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                int id_comanda = 0;
                int mesa = 0;
                int mozo = 0;
                int estado = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {

                    id_comanda = Convert.ToInt32(dgComanda.SelectedRows[i].Cells["colComanda"].Value);
                    mesa = Convert.ToInt32(dgComanda.SelectedRows[i].Cells["colMesa"].Value);
                    mozo = Convert.ToInt32(dgComanda.SelectedRows[i].Cells["colMozo"].Value);
                    estado = Convert.ToInt32(dgComanda.SelectedRows[i].Cells["col_IdEstado"].Value);
                }

                //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
                Form frm;

              
                    frm = new FrmTicket(Frm_Principal.fechaSistema,mozo,mesa,id_comanda,estado);
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;

            }
            else
            {
                Funciones.mError(this, "Por favor seleccione una comanda");
            }
           

        }

        private void btnAbrirComanda_Click(object sender, EventArgs e)
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
                var result = frm.ShowDialog();
                frm.WindowState = FormWindowState.Normal;
                if (result == DialogResult.OK)
                {
                    actualizarListaComanda();
                }
            }
        }

        private void btnCerrarCoamanda_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount =
           dgComanda.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                int id_comanda = 0;
                int mesa = 0;
                int mozo = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {

                    id_comanda = Convert.ToInt32(dgComanda.SelectedRows[i].Cells["colComanda"].Value);
                    mesa = Convert.ToInt32(dgComanda.SelectedRows[i].Cells["colMesa"].Value);
                    mozo = Convert.ToInt32(dgComanda.SelectedRows[i].Cells["colMozo"].Value);
                }

                if (Comanda.bajaComanda(id_comanda))
                {
                    actualizarListaComanda();
                }
                else
                {
                    Funciones.mError(this, "ERROR AL CERRAR LA COMANDA");
                }

            }
            else
            {
                Funciones.mError(this, "Por favor seleccione una comanda");
            }


        }

        //SALIR DEL FORM
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Frm_Comanda_Load(object sender, EventArgs e)
        {
            Timer tmr = new Timer();
            tmr.Interval = 200; // 0.1 second
            tmr.Tick += actualizar; // We'll write it in a bit
            tmr.Start(); // The countdown is launched!
        }

        public static int act { get; set; }



       private void actualizar(object sender, EventArgs e)
        {
            if (act == 1)
            {
                actualizarListaComanda();
                act = 0;
            }           
        }

   



    }
}
