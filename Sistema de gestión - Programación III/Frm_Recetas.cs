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
    public partial class Frm_Recetas : Form
    {
        
        public Frm_Recetas(int id, string nombre_producto)
        {
            InitializeComponent();
            int id_receta = 0;
                    
            try
            {
                
                comb_receta.DataSource = Producto.getReceta(id).Tables[0].DefaultView;
                comb_receta.ValueMember = "id_receta";
                comb_receta.DisplayMember = "nombre";
                id_receta = Convert.ToInt32(comb_receta.SelectedValue);
                comb_receta.SelectedIndexChanged += new EventHandler(comb_receta_SelectedIndexChanged);

            }
            catch (Exception es)
            {
                Funciones.mError(this, "Error al cargar las recetas");
            }

            cargarDetalles(id_receta);

            txtNombreProducto.Text = nombre_producto;

        }

        private void Frm_Recetas_Load(object sender, EventArgs e)
        {


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable data = new DataTable();

        private void comb_receta_SelectedIndexChanged(object sender,
         System.EventArgs e)
        {
            try
            {
                cargarDetalles(Convert.ToInt32(comb_receta.SelectedValue));
            }
            catch
            {
                Funciones.mError(this, "Error");
                //este evento ocurre antes que se llene el comboBox, por eso tira un bug
                //posible solución --->

                //public MyClass()
                //{
                //    InitializeComponent();
                //    Cargar combo!!
                //    comb_receta.SelectedIndexChanged += new EventHandler(comb_receta_SelectedIndexChanged);
                //}

                //void comb_receta_SelectedIndexChanged(object sender, EventArgs e)
                //{
                //    cargarDetalles(Convert.ToInt32(comb_receta.SelectedValue));
                //}
            }
        }
       
        private void cargarDetalles(int id_receta)
        {
            try
            {
                DataTable dtt = new DataTable();
                dtt = Receta.recuperarDetalles(id_receta);
                
                if (dtt.Rows.Count == 0 || dtt == null)
                {
                    Funciones.mOk(this, "La receta esta vacia!!");
                }
                dt_ingrediente.DataSource = dtt;

                DataTable data = Receta.getReceta(id_receta).Tables[0];             
                
                DataRow fila = data.Rows[0];
                txtNombreReceta.Text = fila["nombre"].ToString();
                fecha.Value = DateTime.Parse(fila["fecha"].ToString());
                
            }
            catch (Exception es)
            {
                Funciones.mOk(this, es.Message);              
            }
        }


        private void btn_eliminarReceta_Click(object sender, EventArgs e)
        {
            //if (Funciones.mConsulta(this, "Está seguro que desea eliminar la receta: "))
            //{
            //    Receta.bajaReceta(1);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_ModificarReceta").SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();

                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                //frm = new Frm_ModificarReceta(Convert.ToInt32(comb_receta.SelectedValue));
                //frm.Show();
                //frm.WindowState = FormWindowState.Normal;
            }
        }

        private void comb_receta_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
