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
    public partial class Frm_Baja_Modificar_Producto : Form
    {

        public Frm_Baja_Modificar_Producto(int form_agregar)
        {
            InitializeComponent();
            rbtNombre.Select();
            if (form_agregar == 1)
            {
                btn_modificarProducto.Visible = false;
                btn_receta.Visible = false;
                btn_eliminarProducto.Visible = false;
                btm_seleccion.Visible = true;
                groupBoxProducto.Enabled = false;
                DataTable data = Producto.getProductosVenta();
                if (data == null)
                {
                    Funciones.mError(this, "NO SE PUDIERON CARGAR LOS PRODUCTOS");
                }
                else
                {
                    dt_RecetaDetalle.DataSource = Producto.getProductosVenta();
                }

            }
            else
            {
                rdTodosProductos.Select();              
            }
            
        }


        //busca un producto 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable data = Producto.buscarProducto(txtConsulta.Text.Trim(), raddioButtonSeleccionado());

            if (data == null || data.Rows.Count == 0)
            {
                Funciones.mOk(this, "No se encontraron resultados");
            }
            else
            {
                dt_RecetaDetalle.DataSource = data;
            }
        }

        private void txtConsulta_keyPress(object sender, KeyPressEventArgs e)
        {
            DataTable data = Producto.buscarProducto(txtConsulta.Text.Trim(), raddioButtonSeleccionado());
            DataTable dt = (DataTable)dt_RecetaDetalle.DataSource;
            if (data == null)
            {
                Funciones.mOk(this, "No se encontraron resultados");
            }
            else
            {
                dt.Clear();
                dt_RecetaDetalle.DataSource = data;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string raddioButtonSeleccionado()
        {
            string columna = "";

            if (rbtCategoria.Checked)
            {
                columna = "cat.categoria";
            }

            if (rbtNombre.Checked)
            {
                columna = "nombre";
            }

            if (rbtStock.Checked)
            {
                columna = "p.stock";
            }

            if (rbt_id.Checked)
            {
                columna = "p.id_producto";
            }


            return columna;
        }

        private void btn_eliminarProducto_Click(object sender, EventArgs e)
        {
            int indice, id_producto;
            Int32 selectedRowCount = dt_RecetaDetalle.Rows.GetRowCount(DataGridViewElementStates.Selected);
            string mensaje = "¿Está seguro que desea eliminar los productos seleccionados?";
            try
            {
                if (selectedRowCount > 0)
                {
                    if (selectedRowCount == 1)
                    {
                        mensaje = "¿Está seguro que desea eliminar el producto seleccionado?";
                    }

                    if (Funciones.mConsulta(this, mensaje))
                    {
                        for (int i = 0; i < selectedRowCount; i++)
                        {
                            indice = dt_RecetaDetalle.SelectedRows[i].Index;
                            id_producto = Convert.ToInt32(dt_RecetaDetalle.Rows[indice].Cells[0].Value);
                            if (!Producto.bajaProducto(id_producto))
                            {
                                Funciones.mError(this, "Error al eliminar el producto: " + dt_RecetaDetalle.Rows[indice].Cells[1].Value.ToString());
                            }
                        }
                        dt_RecetaDetalle.DataSource = Producto.getAll();
                    }

                }
                else
                {
                    Funciones.mError(this, "Por favor seleccione uno o más productos");
                }
            }
            catch (Exception es)
            {
                Funciones.mError(this, es.Message);
            }

        }

        public int id_producto = 0;

        private void btn_receta_Click(object sender, EventArgs e)
        {
            int indice;
            Int32 selectedRowCount = dt_RecetaDetalle.Rows.GetRowCount(DataGridViewElementStates.Selected);

            try
            {
                if (selectedRowCount > 0)
                {
                    if (selectedRowCount == 1)
                    {
                        for (int i = 0; i < selectedRowCount; i++)
                        {
                            id_producto = 0;
                            indice = dt_RecetaDetalle.SelectedRows[i].Index;
                            id_producto = Convert.ToInt32(dt_RecetaDetalle.Rows[indice].Cells[0].Value);
                            string nombre = dt_RecetaDetalle.Rows[indice].Cells[1].Value.ToString();
                            DataSet data = Producto.getReceta(id_producto);

                            if (data.Tables[0].Rows.Count == 0 || data == null )
                            {
                                Funciones.mError(this, "Este producto NO posee receta");
                            }
                            else
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
                                    frm = new Frm_ModificarReceta(id_producto, nombre);
                                    frm.Show();
                                    frm.WindowState = FormWindowState.Normal;
                                }
                            }
                        }
                    }
                    else
                    {
                        Funciones.mError(this, "Por favor selecione UN SOLO producto");
                    }
                }
                else
                {
                    Funciones.mError(this, "Por favor seleccione la fila del producto que desee ver la receta");
                }
            }
            catch (Exception es)
            {
                Funciones.mError(this, es.Message);
            }

        }

        private void btn_modificarProducto_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount =
            dt_RecetaDetalle.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1 )
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    
                    Id_producto1 = Convert.ToInt32(dt_RecetaDetalle.SelectedRows[i].Cells["id"].Value);
                }
               
                //recorre la lista de form abiertos por la alicación y devuelve el form Frm_mozo si lo encuentra
                Form frm = Application.OpenForms.OfType<Form>().Where(Pre => Pre.Name == "Frm_AltaProducto").SingleOrDefault();

                // codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
                //if (frm != null)
                //{
                //    frm.Select();
                //    frm.Show();
                //    frm.WindowState = FormWindowState.Normal;
                //}
                //else
                //{
                    frm = new Frm_AltaProducto(1);
                    //frm.ShowDialog();
                var result = frm.ShowDialog();
                frm.WindowState = FormWindowState.Normal;
                if (result == DialogResult.OK)
                {
                    DataTable data = Producto.getAll();
                    if (data == null)
                    {
                        Funciones.mError(this, "Sin productos");
                    }
                    else
                    {
                        dt_RecetaDetalle.DataSource = Producto.getAll();
                    }
                    rdTodosProductos.Select();
                }
                //}
            }
            else
            {
                Funciones.mError(this, "Por favor seleccione un producto");
            }
        }

        private void rdProductoCompuesto_CheckedChanged(object sender, EventArgs e)
        {
            DataTable data = Produto_compuesto.getCompuestos();
            if (data == null)
            {
                Funciones.mError(this, "");
            }
            else
            {
                dt_RecetaDetalle.DataSource = data;
            }
        }

        private void rdTodosProductos_CheckedChanged(object sender, EventArgs e)
        {
            DataTable data = Producto.getAll();
            if (data == null)
            {
                Funciones.mError(this, "");
            }
            else
            {
                dt_RecetaDetalle.DataSource = Producto.getAll();
            }
        }

        private void rdProductoSimple_CheckedChanged(object sender, EventArgs e)
        {
            DataTable data = Producto.getAll();
            if (data == null)
            {
                Funciones.mError(this, "");
            }
            else
            {
                dt_RecetaDetalle.DataSource = Producto.getAll();
            }
        }

        // variabl estatica con el id del producto 
        private static  int id_producto1 = 0;

        public static int Id_producto1
        {
            get { return id_producto1; }
            set { id_producto1 = value; }
        }

        private void btm_seleccion_Click(object sender, EventArgs e)
        {
            
            Int32 selectedRowCount =
                       dt_RecetaDetalle.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {

                    Id_producto1 = Convert.ToInt32(dt_RecetaDetalle.SelectedRows[i].Cells["id"].Value);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Funciones.mError(this, "Por favor seleccione un producto");
            }
        }
    }
}
