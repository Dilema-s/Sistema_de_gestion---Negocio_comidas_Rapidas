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
    public partial class FrmTicket : Form
    {
        private int id_comanda1 { get; set; } 

        public FrmTicket(DateTime fecha, int id_mozo, int num_mesa, int id_comanda, int estado)
        {
            InitializeComponent();
            date.Value = fecha;
            date.Enabled = false;
            txtMozo.Text = id_mozo.ToString();
            txtMesa.Text = num_mesa.ToString();
            txtNumComanda.Text = id_comanda.ToString();
            id_comanda1 = id_comanda;
            dtComanda.DataSource = Comanda.getComanda(id_comanda1).Tables[0].DefaultView;
            if (Comanda.getSubtotal(id_comanda1) == -1)
            {
                Funciones.mError(this, "ERROR OBTENIENDO SUBTOTAL");
            }
            else
            {
                lbSubtotal.Text = "$  " + Comanda.getSubtotal(id_comanda1).ToString();
            }

            if (estado != 1)
            {
                btnAgregarProducto.Enabled = false;
                btnEliminarProducto.Enabled = false;
                colCantidad.ReadOnly = false;
            }
           
          

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "FrmAgregarProductoComanda").SingleOrDefault();

            // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new FrmAgregarProductoComanda(Int32.Parse(txtNumComanda.Text), Int32.Parse(txtMozo.Text), Int32.Parse(txtMesa.Text));
                var result = frm.ShowDialog();
                frm.WindowState = FormWindowState.Normal;
                if (result == DialogResult.OK)
                {
                    dtComanda.DataSource =  Comanda.getComanda(id_comanda1).Tables[0].DefaultView;
                    if (Comanda.getSubtotal(id_comanda1) == -1)
                    {
                        Funciones.mError(this, "ERROR OBTENIENDO SUBTOTAL");
                    }
                    else
                    {
                        lbSubtotal.Text = "$  " + Comanda.getSubtotal(id_comanda1).ToString();
                    }

                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Frm_Comanda.act = 1;
            this.Close();
        }

        private void btnEliminarProducto_Click_1(object sender, EventArgs e)
        {

            Int32 selectedRowCount =
         dtComanda.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    if (!Detalle_comanda.eliminarDetalle(Convert.ToInt32(dtComanda.SelectedRows[i].Cells["col_Id_detalle"].Value)))
                    {
                        Funciones.mError(this, "ERROR AL ELIMIMAR EL PRODUCTO");
                    }
                    else
                    {
                        dtComanda.DataSource = Comanda.getComanda(id_comanda1).Tables[0].DefaultView;
                        if (Comanda.getSubtotal(id_comanda1) == -1)
                        {
                            Funciones.mError(this, "ERROR OBTENIENDO SUBTOTAL");
                        }
                        else
                        {
                            lbSubtotal.Text = "$  " + Comanda.getSubtotal(id_comanda1).ToString();
                        }
                    }

                }


            }
            else
            {
                Funciones.mError(this, "Por favor seleccione un producto");
            }
        }


        private void btnCantidad_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount =
         dtComanda.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {

                    ////recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
                    //Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_ModificarCantidad").SingleOrDefault();

                    //// codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
                    //if (frm != null)
                    //{
                    //    frm.Select();
                    //    frm.Show();
                    //    frm.WindowState = FormWindowState.Normal;
                    //}
                    //else
                    //{
                    //    frm = new Frm_ModificarCantidad(id_comanda1,id_producto);
                    //    var result = frm.ShowDialog();
                    //    frm.WindowState = FormWindowState.Normal;
                    //}


                }

            }
            else
            {
                Funciones.mError(this, "Por favor seleccione un producto");
            }
        }












        private void FrmTicket_Load(object sender, EventArgs e)
        {

        }

        private void FrmTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_Comanda.act = 1;
        }

        private void dtComanda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
