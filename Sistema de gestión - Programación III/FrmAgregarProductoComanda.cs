using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_gestión___Programación_III
{
    public partial class FrmAgregarProductoComanda : Form
    {

        private int id_comanda1 { get; set; }
        
        //private int id_mozo1 { get; set; }
        //private int mesa1 { get; set; }
       
        public FrmAgregarProductoComanda(int id_comanda, int id_mozo, int mesa)
        {
            InitializeComponent();
            id_comanda1 = id_comanda;
            //id_mozo1 = id_mozo;
            //mesa1 = mesa;
            lbcomanda.Text = id_comanda.ToString();
            lbMesa.Text = mesa.ToString();
            lbMozo.Text = id_mozo.ToString();
        }

        private void btnBusarProducto_Click(object sender, EventArgs e)
        {

            //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
            Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_Baja_Modificar_Producto").SingleOrDefault();

            //codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
            if (frm != null)
            {
                frm.Select();
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm = new Frm_Baja_Modificar_Producto(1);
                var result = frm.ShowDialog();
                frm.WindowState = FormWindowState.Normal;
                if (result == DialogResult.OK)
                {
                   txtIdProducto.Text = Frm_Baja_Modificar_Producto.Id_producto1.ToString();
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_producto = 0;
                id_producto = Convert.ToInt32(txtIdProducto.Text);
                //Receta.getRecetas(id_producto)


                if (cantidad.Value > 0)
                {
                    DataTable data;
                    if (id_producto > 0)
                    {

                        DataSet data1 = Producto.getReceta(id_producto);

                        if (data1.Tables[0].Rows.Count == 0 || data1 == null)
                        {
                            //Funciones.mError(this, "Este producto NO posee receta");
                        }



                        if (Detalle_comanda.detalleRepetido(id_producto, id_comanda1))
                        {
                            int cantidad1 = Convert.ToInt32(cantidad.Value);
                            Funciones.mError(this, "repetido");
                            Detalle_comanda.actualizarCantidad(id_producto, id_comanda1, cantidad1);
                            this.DialogResult = DialogResult.OK;
                            this.Close();

                        }
                        else
                        {
                            data = Producto.getProducto(id_producto);
                            DataRow fila = data.Rows[0];
                            string nombre = fila["nombre"].ToString();
                            float precio_costo;
                            precio_costo = Convert.ToSingle(fila["precio_costo"]);
                            float precio_venta = Convert.ToSingle(fila["precio_venta"]);
                            int cantidad1 = Convert.ToInt32(cantidad.Value);
                            float total = cantidad1 * precio_venta;
                            Detalle_comanda dc = new Detalle_comanda(0, id_comanda1, id_producto, nombre, cantidad1, precio_venta, precio_costo, total, 0);
                            if (!dc.guardarDetalle())
                            {
                                Funciones.mError(this, "Error al cargar el producto");
                                this.Close();
                            }
                            else
                            {
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                          
                        }                      
                    }
                }
                else
                {
                    Funciones.mError(this, "Por Favor seleccione una cantidad");
                }
            }
            catch (Exception)
            {
                Funciones.mError(this, "Ingrese solo números en 'ID DEL PRODUCTO'"); 
            }

            
        }

        private void FrmAgregarProductoComanda_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
