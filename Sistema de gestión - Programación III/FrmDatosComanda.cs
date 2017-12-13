using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_gestión___Programación_III
{
    public partial class FrmDatosComanda : Form
    {
        public FrmDatosComanda()
        {
            InitializeComponent();

            try
            {
                comb_Mozo.DataSource = Persona.getAll().DefaultView;
                comb_Mozo.ValueMember = "id_persona";
                comb_Mozo.DisplayMember = "id_persona";
                comb_Mozo.SelectedIndexChanged += new EventHandler(comb_Mozo_SelectedIndexChanged);
                DataRow fila = Persona.getPersona2(Convert.ToInt32(comb_Mozo.SelectedValue)).Tables[0].Rows[0];
                txtNombre.Text = fila["nombre"].ToString();
            }
            catch (Exception ex)
            {
                Funciones.mError(this, "Error al cargar los mozos\n");
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarMozo_Click(object sender, EventArgs e)
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
                frm.ShowDialog();
                frm.WindowState = FormWindowState.Normal;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            Comanda c = null;
            int id_mozo = 0;
            int num_mesa = 0;
            int total = 0;
            int baja = 1;
            int puesto = 1;
            int id_comanda = Comanda.ultimo_id_comanda();
            if (txtnumMesa.Value > 0 )
            {
              
                try
                {
                    id_mozo = Convert.ToInt32(comb_Mozo.SelectedValue);
                    num_mesa = Convert.ToInt32(txtnumMesa.Value);
                    if (!Detalle_comanda.verificarComandaAbierta(num_mesa, 1, fecha.Value, fecha.Value))
                    {
                        c = new Comanda(id_comanda, puesto, fecha.Value, id_mozo, num_mesa, total, baja);
                    }
                    else
                    {
                        Funciones.mError(this,"Esta mesa se encuentra abierta");
                        
                        this.Close();
                        // aca deberia abrir la comanda 
                    }                              
                }
                catch (Exception ex)
                {
                    Funciones.mError(this, ex.Message);
                }

                //VALIDAR SI LA COMANDA YA NO ESTA ABIERTA PARA ESA MESA.

                if (c != null)
                {
                    if (c.insertComanda())
                    {
                       
                        //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
                        Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "FrmTicket").SingleOrDefault();

                        //codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
                        if (frm != null)
                        {
                            frm.Select();
                            frm.Show();
                            frm.WindowState = FormWindowState.Normal;
                        }
                        else
                        {
                            
                            frm = new FrmTicket(Frm_Principal.fechaSistema,id_mozo,num_mesa, id_comanda,1);
                            frm.Show();
                            frm.WindowState = FormWindowState.Normal;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                            
                           
                        }
                    }
                    else
                    {
                        Funciones.mError(this, "Error al generar la comanda");
                    }

                }



            }
        }

        private void comb_Mozo_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            try
            {

                DataRow fila = Persona.getPersona2(Convert.ToInt32(comb_Mozo.SelectedValue)).Tables[0].Rows[0];
                txtNombre.Text =  fila["nombre"].ToString();
             
            }
            catch (Exception ex)
            {
                Funciones.mError(this, "Select index change Error" + ex.Message);
            }
        }




































































































































    }
}
