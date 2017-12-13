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
using System.Globalization;

namespace Sistema_de_gestión___Programación_III
{
    public partial class Frm_ModificarReceta : Form
    {
        private int id_receta1 = 0;
        private int id_detalle_receta1 = 0;
        private int id_producto1 = 0;
        private string nombre_producto1 = "";

        public  Frm_ModificarReceta(int id_producto, string nombre_producto)
        {
            InitializeComponent();
            

            //cargamos el comboBox con id_unidad
            DataSet ds = Unidad.cargarComboBox();
            try
            {
                comboUnidad.DataSource = ds.Tables[0].DefaultView; // muestra la primera fila de la tabla
                comboUnidad.ValueMember = "id_unidad"; //el valor del miembro con el que va a trabajar
                comboUnidad.DisplayMember = "unidad"; // el valor que va mostrar en pantalla
            }
            catch (Exception)
            {
                Funciones.mError(this, "Error al cargar las unidades\n");
            }

            //cargamos el comboBox con id_producto
            try
            {
                DataTable dt = Producto.cargarComboProducto();
                comboProducto.DataSource = dt;
                comboProducto.ValueMember = "id_producto"; //el valor del miembro con el que va a trabajar
                comboProducto.DisplayMember = "nombre";
               
            }
            catch (Exception es)
            {
                Funciones.mError(this, "Error al cargar los ingredientes");
            }

            //cargamos el combo con las recetas del producto
            int id_receta = 0;
            try
            {
               
                comb_receta.DataSource = Producto.getReceta(id_producto).Tables[0].DefaultView;
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
            setId_receta1(id_receta);
            setId_producto1(id_producto);
            
        }

        public void recargarFrm()
        {
            //cargamos el combo con las recetas del producto
            int id_receta = 0;
            try
            {
                comb_receta.DataSource = null;
                comb_receta.DataSource = Producto.getReceta(id_producto1).Tables[0].DefaultView;
                comb_receta.ValueMember = "id_receta";
                comb_receta.DisplayMember = "nombre";
                id_receta = Convert.ToInt32(comb_receta.SelectedValue);
                comb_receta.SelectedIndexChanged += new EventHandler(comb_receta_SelectedIndexChanged);

            }
            catch (Exception es)
            {
                Funciones.mError(this, "Error al cargar las recetas");
                Funciones.mError(this, es.Message);
            }

            cargarDetalles(id_receta);

            txtNombreProducto.Text = nombre_producto1;
            setId_receta1(id_receta);

        }

        public void setId_receta1(int id_receta)
        {
            this.id_receta1 = id_receta;
        }

        public void setId_producto1(int id_prod)
        {
            this.id_producto1 = id_prod;

        }

        public void setNombre_producto1(string nombre)
        {
            this.nombre_producto1 = nombre;
        }

        private void cargarDetalles(int id_receta)
        {
            try
            {
                DataTable dtt = new DataTable();
                dtt = Receta.recuperarDetalles(id_receta);

                if (dtt.Rows.Count == 0 || dtt == null)
                {
                    dtt.Clear();
                    dg_ingrediente.DataSource = dtt;
                    Funciones.mOk(this, "La receta esta vacia!!");
                }
                else
                {
                    dg_ingrediente.DataSource = dtt;
                    DataTable data = Receta.getReceta(id_receta).Tables[0];
                    DataRow fila = data.Rows[0];
                    txtNombreReceta.Text = fila["nombre"].ToString();
                    fecha.Value = DateTime.Parse(fila["fecha"].ToString());
                }
            }
            catch (Exception es)
            {
                Funciones.mOk(this,"Error en cargar detalles" +  es.Message);
            }
        }

        private void btn_eliminarIngrediente_Click(object sender, EventArgs e)
        {
           int indice; 
           Int32 selectedRowCount = dg_ingrediente.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                if (Funciones.mConsulta(this, "¿Está seguro que desea eliminar el ingrediente seleccionado"))
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        int id_detalle_receta = 0;
                        try
                        {
                            Int32 firstSelectd = this.dg_ingrediente.Rows.GetFirstRow(
                           DataGridViewElementStates.Selected);
                            
                            indice = firstSelectd;
                            id_detalle_receta = Convert.ToInt32(dg_ingrediente.Rows[indice].Cells["id_detalle_receta"].Value);
                            this.dg_ingrediente.Rows.RemoveAt(firstSelectd);
                            
                            if (!Detalle_receta.eliminarDetalle(id_detalle_receta))
                            {
                                Funciones.mError(this, "Error al eliminar el ingrediente seleccionado");
                            }   
                        }
                        catch (Exception ex)
                        {
                            Funciones.mError(this, "Error al eliminar el ingrediente seleccionado");
                        }
                    }
                 }      
            }
            else
            {
                Funciones.mError(this, "Seleccione una fila");
            }       
        }   
       
        private void btn_agregarIngrediente_Click(object sender, EventArgs e)
        {
            Detalle_receta det = null;
            int id_ingrediente;
            float cantidad1;
            int id_unidad;
            string mensaje = "Intente nuevamente agregar el ingrediente";

            try
            {
                id_ingrediente = Convert.ToInt32(comboProducto.SelectedValue);
                id_unidad = Convert.ToInt32(comboUnidad.SelectedValue);
                cantidad1 = float.Parse(txtCantidad.Text);

                if (btn_agregarIngrediente.Text == "GUARDAR CAMBIOS")
                {
                    if (id_detalle_receta1 > 0)
                    {
                        Detalle_receta.actualizarDetalle(id_detalle_receta1, id_ingrediente, id_unidad, cantidad1);
                        btn_agregarIngrediente.Text = "AGREGAR INGREDIENTE";
                    }
                    mensaje = "Intente nuevamente modificar el ingrediente";
                }
                else
                {
                    if (id_receta1 > 0)
                    {
                        det = new Detalle_receta(id_receta1, id_ingrediente, id_unidad, cantidad1, 0);
                        det.guardarDetalle();
                    }
                    
                }
                  
            }
            catch (Exception ex)
            {
                Funciones.mError(this, mensaje);     
            }
            cargarDetalles(id_receta1);
        }

        private void btn_modificarIngrediente_Click(object sender, EventArgs e)
        {
            int indice;
            Int32 selectedRowCount = dg_ingrediente.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    int id_detalle_receta = 0;
                    try
                    {
                        Int32 firstSelectd = this.dg_ingrediente.Rows.GetFirstRow(
                        DataGridViewElementStates.Selected);

                        indice = firstSelectd;
                        id_detalle_receta = Convert.ToInt32(dg_ingrediente.Rows[indice].Cells["id_detalle_receta"].Value);
                        
                        DataRow fila = Detalle_receta.recuperarDetalle(id_detalle_receta).Tables[0].Rows[0];
                        comboProducto.SelectedValue =  fila["id_producto"];
                        comboUnidad.SelectedValue = fila["unidad"];
                        txtCantidad.Text = fila["cantidad"].ToString();
                        btn_agregarIngrediente.Text = "GUARDAR CAMBIOS";
                        id_detalle_receta1 = id_detalle_receta;

                    }
                    catch (Exception ex)
                    {
                        Funciones.mError(this, "Error al modificar el ingrediente seleccionado");
                        id_detalle_receta1 = 0;
                    }
                }    
            }
            else
            {
                Funciones.mError(this, "Seleccione una fila");
            }
        }

        private void comb_receta_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(comb_receta.SelectedValue);
                cargarDetalles(id);
                setId_receta1(id);
            }
            catch
            {
                Funciones.mError(this, "Error");
            }
        }

        private void btn_eliminarReceta_Click(object sender, EventArgs e)
        {
            if (Funciones.mConsulta(this, "Está seguro que desea eliminar la receta: " + comb_receta.Text))
            {
                try
                {
                    Receta.bajaReceta(Convert.ToInt32(comb_receta.SelectedValue), id_producto1);
                    recargarFrm();
                    txtNombreReceta.Text = "";
                    fecha.Value = DateTime.Today;
                }
                catch (Exception ex)
                {
                    Funciones.mError(this, "Error al eliminar la receta");
                }
               
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
