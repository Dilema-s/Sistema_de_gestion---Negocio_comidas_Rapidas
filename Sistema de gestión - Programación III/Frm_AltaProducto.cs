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
using System.Collections;

namespace Sistema_de_gestión___Programación_III
{
    public partial class Frm_AltaProducto : Form
    {

        private static int bandera1 = 0;
        Receta receta1 = null;

        public static int Bandera1
        {
            get { return bandera1; }
            set { bandera1 = value; }
        }


        public Frm_AltaProducto(int bandera)
        {
            InitializeComponent();

            
            //cargamos el comboBox con unidad
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

            //cargamos el comboBox con las categorias
            DataSet ds1 = Categoria.cargarComboBox();
            try
                {
                    comboCategoria.DataSource = ds1.Tables[0].DefaultView; // muestra la primera fila de la tabla
                    comboCategoria.ValueMember = "id_categoria"; //el valor del miembro con el que va a trabajar
                    comboCategoria.DisplayMember = "categoria"; // el valor que va mostrar en pantalla
                }
                catch (Exception)
                {
                    Funciones.mError(this, "Error al cargar las categorias\n");
                }


                if (bandera == 0)
            {
                //valores por defecto de algunos textBox y radioButton
                txtId.Text = "" + Producto.Id_producto_siguiente();
                rb_simple.Select();
                rdbtnSi.Select();
                txtPrecioCosto.Text = "0.00";
                txtPrecioVenta.Text = "0.00";
                txtStockMinimo.Text = "0";
                txtStock.Text = "0";
                txtDescripcion.Text = "Sin descripción";
                comboCategoria.SelectedValue = 2;
                txtMarca.Text = "Sin marca";

            }
            else
            {

                DataTable data;
                if (Frm_Baja_Modificar_Producto.Id_producto1 > 0)
                {
                    data = Producto.getProducto(Frm_Baja_Modificar_Producto.Id_producto1);
                    DataRow fila = data.Rows[0];
                    txtNombre.Text = fila["nombre"].ToString();
                    txtMarca.Text = fila["marca"].ToString();
                    txtId.Enabled = false;
                    txtId.Text = fila["id_producto"].ToString();
                    txtDescripcion.Text = fila["descripcion"].ToString();
                    txtStock.Text = fila["stock"].ToString();
                    txtStockMinimo.Text = fila["stock_minimo"].ToString();
                    txtPrecioCosto.Text = fila["precio_costo"].ToString();
                    txtPrecioVenta.Text = fila["precio_venta"].ToString();
                    comboCategoria.SelectedValue = fila["categoria"];
                    if (Convert.ToInt32(fila["lista_precio"]) == 1)
                    {
                        rdbtnSi.Select();
                    }
                    else
                    {
                        radioButton2.Select();
                    }
                    Bandera1 = bandera;
                    btn_guardar.Text = "GUARDAR CAMBIOS";
                    label3.Text = "MODIFICAR PRODUCTO";
                    btn_verReceta.Visible = true;
                    btn_agregarReceta.Visible = true;
                    DataSet dat = Producto.getReceta(Frm_Baja_Modificar_Producto.Id_producto1);
                    if (dat == null || dat.Tables[0].Rows.Count == 0)
                    {
                        rb_simple.Select();
                    }
                    else
                    {
                        rb_compuesto.Select();
                    }
                }
           
            }

            pane_receta.Enabled = false;

            //para hacer que el comboBox no sea editable
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }
     
      

       

        //Acciones de los radio buttom
        private void rb_simple_CheckedChanged(object sender, EventArgs e)
        {    
            pane_proSimple.Enabled = true;
            a_la_venta.Enabled = true;
            pane_precio.Enabled = true;
        }

        private void rb_compuesto_CheckedChanged(object sender, EventArgs e)
        {
            pane_proSimple.Enabled = false;
            rdbtnSi.Select();
            a_la_venta.Enabled = false;
            comboCategoria.Enabled = true; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtPrecioVenta.Text = "0.00";
            txtPrecioVenta.Enabled = false;
            comboCategoria.SelectedValue = 1;
            comboCategoria.Enabled = false;
        }

        private void rdbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            txtPrecioVenta.Enabled = true;
            comboCategoria.Enabled = true;
        }



        //boton guardar producto
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MensajeError v = new MensajeError();

            //variables de producto
            int id = 0, categoria = 2;
            float p_venta = 0, p_costo = 0;
            string nombre = "Sin nombre", descripcion = "Sin descripción";

            //VALIDACIONES - CONVERSIONES

            // conversion del id a int, validacion que no sea null
            try
            {
                id = Convert.ToInt32(txtId.Text);
                v.setResultado(true);
            }
            catch (Exception)
            {
                v.setResultado(false);
                v.mensaje_error("Error con el CÓDIGO del producto, no puede estar en blanco\n");
            } 

            //validacion longitud > 2 nombre producto
            if (Funciones.length(txtNombre.Text.Trim()))
            {
                nombre = txtNombre.Text.Trim();
            } 
            else
            {
                v.setResultado(false);
                v.mensaje_error("NOMBRE de producto incorrecto, debe contener al menos 3 carácteres\n");
            }

            //validacion longitud > 2 descripcion producto en caso que tenga
            if (Funciones.isNull(txtDescripcion.Text.Trim()))
            {
                descripcion = "Sin descripción";
            }
            else
            {
                if (Funciones.length(txtDescripcion.Text.Trim()))
                {
                    descripcion = txtDescripcion.Text.Trim();
                }
                else
                {
                    v.setResultado(false);
                    v.mensaje_error("DESCRIPCIÓN de producto incorrecto, debe contener al menos 3 carácteres\n");
                }
            }

            // conversion de la categoria a int
            try
            {
                categoria = Convert.ToInt32(comboCategoria.SelectedValue);
            }
            catch (Exception)
            {
                v.setResultado(false);
                v.mensaje_error("Error al seleccionar la CATEGORÍA\n");
            }

            // conversion del precio de venta a float         
            try
            {
                p_venta = float.Parse(txtPrecioVenta.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (p_venta == 0 && rdbtnSi.Checked)
                {
                    v.setResultado(false);
                    v.mensaje_error("El precio de VENTA no puede ser '0.00', utilize solo un '.' para los decimales\n");
                }
            }
            catch (Exception)
            {
                v.setResultado(false);
                v.mensaje_error("El precio de VENTA no puede estar vacío, utilize '.' para los decimales\n");
            }

            // conversion del precio de costo a float en caso que tenga
            if (Funciones.isNull(txtPrecioCosto.Text.Trim()))
            {
                p_costo = 0;
            }
            else {
                try
                {
                    p_costo = float.Parse(txtPrecioCosto.Text, CultureInfo.InvariantCulture.NumberFormat);
                }
                catch (Exception ex)
                {
                    v.setResultado(false);
                    v.mensaje_error("Utilize '.' para los decimales, en el precio de COSTO\n");
                }
            }
            


            if (rb_simple.Checked) //si se esta ingresando un producto simple se crea un objeto Producto_simple
            {

                string marca = "Sin marca";
                int stock = 0, stock_min = 0;

                //validacion longitud > 2 marca producto en caso que tenga
                if (Funciones.isNull(txtMarca.Text.Trim()))
                {
                    marca = "Sin marca";
                }
                else
                {
                    if (Funciones.length(txtMarca.Text.Trim()))
                    {
                        marca = txtMarca.Text.Trim();
                    }
                    else
                    {
                        v.setResultado(false);
                        v.mensaje_error("MARCA de producto incorrecta, debe contener al menos 3 carácteres\n");
                    }
                }              

                // conversion del sotck a int en caso que tenga
                if (Funciones.isNull(txtStock.Text))
                {
                    stock = 0;
                }
                else {
                    try
                    {
                        stock = Convert.ToInt32(txtStock.Text);
                    }
                    catch (Exception)
                    {
                        v.setResultado(false);
                        v.mensaje_error("El STOCK deber ser un número entero\n");

                    } 
                }

                // conversion del sotck minimo a int en caso que tenga
                if (Funciones.isNull(txtStockMinimo.Text))
                {
                    stock_min = 0;
                }
                else
                {
                    try
                    {
                        stock = Convert.ToInt32(txtStockMinimo.Text);
                    }
                    catch (Exception)
                    {
                        v.setResultado(false);
                        v.mensaje_error("El STOCK MÍNIMO deber ser un número entero\n");

                    }
                }

                // SI LAS VALIDACIONES SON CORRECTAS CREA UN OBJETO PRODUCTO_SIMPLE Y LO GUARDA DE LO CONTRARIO MUESTRA LOS MENSAJES DE ERROR
                if (v.getResultado()) 
                {
                    Producto_simple ps = new Producto_simple(id, nombre, descripcion, categoria, p_venta, p_costo, rdbtnSi.Checked, marca, stock, stock_min);
                    if (Bandera1 == 1)
                    {

                        if (ps.updateProductoSimple())
                        {
                            Funciones.mOk(this, "Producto modificado correctamente");
                            this.DialogResult = DialogResult.OK;
                            this.Close();       
                        }
                        else
                        {
                            Funciones.mError(this, "Error al modificar el producto");
                        }
                    }
                    else
                    {
                       
                        if (ps.guardar())
                        {
                            Funciones.mOk(this, "Producto guardado correctamente");
                            inicializarDatos();
                            ActualizarProductos();
                        }
                        else
                        {
                            Funciones.mError(this, "Error al guardar el producto");
                        }
                    }
                   
                }
                else
                {
                    Funciones.mError(this, v.toString());
                }
                
            }
            else
            {
                if (v.getResultado())
                {
                    Produto_compuesto pc = new Produto_compuesto(id, nombre, descripcion, categoria, p_venta, p_costo, rdbtnSi.Checked);

                    if (Bandera1 == 1)
                    {
                        
                        if (pc.updateProductoCompuesto())
                        {

                                if (Funciones.mConsulta(this, "Producto modificado correctamente\nDesea cargar una receta para este producto?"))
                                {
                                panel_producto.Enabled = false;
                                pane_receta.Enabled = true;
                                this.DialogResult = DialogResult.OK;
                                }
                                else
                                {
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }



                               
                        }
                        else
                        {
                            Funciones.mError(this, "Error al modificar el producto");
                        }

                    }
                    else
                    {
                            if (pc.GuardarProducto_compuesto())
                            {
                                Funciones.mOk(this,"Producto guardado correctamente");
                                    pane_receta.Enabled = true;
                                    txtNombreReceta.Text = "Mi receta";
                                    panel_producto.Enabled = false;
                                    txtNombre_producto.Text = txtNombre.Text;
                           
                           
                        }
                        else
                        {
                            Funciones.mError(this, "Error al guardar el producto");
                        }

                    }
                }
                else
                {
                    Funciones.mError(this, v.toString());
                }
                

            }
        }


        // RESTRICCIONES DE INGRESAR SOLO NUMEROS PARA EL TEXTBOX ID
        private void txtId_keyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Funciones.esEntero_keyDown(sender, e);
        }

        private void txtId_keyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (Funciones.nonNumberEntered == true) // si es true no deja ingresar el char
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }



        // RESTRICCIONES DE INGRESAR SOLO NUMEROS Y COMA EN LOS TEXTBOX DE PRECIO_COSTO Y PRECIO_VENTA
        private void txtPrecioCosto_keyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Funciones.esDecimal_keyDown(sender, e);
        }

        private void txtPrecioCosto_keyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (Funciones.nonNumberEntered == true) // si es true no deja ingresar el char
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_keyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Funciones.esDecimal_keyDown(sender, e);
        }

        private void txtPrecioVenta_keyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (Funciones.nonNumberEntered == true) // si es true no deja ingresar el char
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }



        //CARGA LOS DATOS DE PRODUCTOS AL COMBO_PRODUCTO Y LO HACE AUTOCOMPLETE
        private void Frm_AltaProducto_Load(object sender, EventArgs e)
        {

            ActualizarProductos();

            // COMBO BOX AUTOCOMPLETE
            var coleccion = new AutoCompleteStringCollection();
            DataTable dt = Producto.cargarComboProducto();

            //recorrer y carga los items para el autocompletado en la variable coleccion
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["nombre"]));
            }

            // carga la lista de items para el autocomplete del combo_Producto
            comboProducto.AutoCompleteCustomSource = coleccion;
            comboProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboProducto.ValueMember = "id_producto"; //el valor del miembro con el que va a trabajar
            comboProducto.DisplayMember = "nombre";

            comboProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }


        //ACTUALIZA LOS DATOS DE PRODUCTOS AL COMBO_PRODUCTO
        public void ActualizarProductos()
        {
            //cargamos el comboBox con los productos
            DataTable ds2 = Producto.cargarComboProducto();
            try
            {
                comboProducto.DataSource = ds2;
                comboProducto.ValueMember = "id_producto"; //el valor del miembro con el que va a trabajar
                comboProducto.DisplayMember = "nombre"; // el valor que va mostrar en pantalla
            }
            catch (Exception)
            {
                Funciones.mError(this, "Error al cargar las productos\n");
            }
        }

        private DataTable dtt = null;

        // AGREGA LOS INGREDIENTES AL DATAGRIDVIEW POR MEDIO DE UN DATATABLE
        private void btn_agregarALista_Click(object sender, EventArgs e)
        {
            string mensaje = "Error al intentar esta operación";
           
            if (dtt == null)
            {
                dtt = new DataTable();
                dtt.Columns.Add("nombre", typeof(string));
                dtt.Columns.Add("cantidad", typeof(string));
                dtt.Columns.Add("unidad", typeof(string));
                dtt.Columns.Add("id_producto", typeof(int));
                dtt.Columns.Add("id_unidad", typeof(float));
            }

            // conversiones
            try
            {
                mensaje = "Error al seleccionar la unidad. Intente nuevamente";
                int unidad = Convert.ToInt32(comboUnidad.SelectedValue);

                mensaje = "Error con el combo producto";
                int id_ingrediente = Convert.ToInt32(comboProducto.SelectedValue);

                mensaje = "La cantidad no puede ser 0";
                float cantidad = float.Parse(txtCantidad.Text, CultureInfo.InvariantCulture.NumberFormat);


                if (ingredienteRepetido(id_ingrediente))
                {
                    Funciones.mError(this, "Este ingrediente ya fue agregado, modifique su cantidad, en caso de desearlo sobre la columna 'Cantidad'");
                }
                else
                {
                    dtt.Rows.Add(comboProducto.Text.ToString(), txtCantidad.Text, comboUnidad.Text.ToString(), id_ingrediente, unidad);
                    tablaIngredientes.AutoGenerateColumns = false;
                    tablaIngredientes.DataSource = dtt;
                    txtCantidad.Text = "";
                }
            }
            catch (Exception ex)
            {
                Funciones.mError(this,"Frm_alta_Producto "+ mensaje);
            }
        }


        // PREGUNTA SI LA TABLA TIENE DETALLES SI = TRUE,CREA Y GUARDA LA RECETA CON SUS DETALLES
        private void btn_guardarReceta_Click(object sender, EventArgs e)
        {
            float cantidad;
            bool pivote = true;
            string mensaje = "La receta se guardo correctamente\n";
            DataTable dt = (DataTable)tablaIngredientes.DataSource;
            if (dt != null)
            {
                string nombreIngrediente = "Error en la cantidad";
                try
                { 
                    foreach (DataRow fila in dt.Rows)
                    {
                        nombreIngrediente = fila["nombre"].ToString();
                        cantidad = float.Parse(fila["cantidad"].ToString()); 
                    }
                }
                catch (Exception ex)
                {
                    Funciones.mError(this, nombreIngrediente + ", por favor ingrese un número entero para la cantidad\n" + ex.Message);
                    pivote = false;
                }



                if (pivote)
                {
                    receta1 = new Receta();
                    receta1.Id_producto = Convert.ToInt32(txtId.Text);
                    receta1.Fecha = fecha.Value.Date;
                    receta1.Nombre = txtNombreReceta.Text;

                    if (receta1.guardarReceta()) //GUARDA LA RECETA Y SUS DETALLES, PREGUNTAR SI QUIERE CREAR OTRA
                    {
                        Detalle_receta det;
                        int id_ingrediente;
                        int id_unidad;
                        foreach (DataRow fila in dt.Rows)
                        {
                            id_ingrediente = Int32.Parse(fila["id_producto"].ToString());
                            id_unidad = Int32.Parse(fila["id_unidad"].ToString());
                            cantidad = float.Parse(fila["cantidad"].ToString());

                            det = new Detalle_receta(receta1.Id_receta, id_ingrediente, id_unidad, cantidad, 0);

                            if (!det.guardarDetalle())
                            {
                                Funciones.mOk(this, "El detalle " + fila["nombre"].ToString() + ", NO se guardo correctamente");
                                mensaje = "La receta se guardo con errores, vaya a 'Modificar Producto' para corregir";

                            }
                        }

                        if (!Funciones.mConsulta(this, mensaje + "Desea generar otra version de receta para el mismo producto"))
                        {
                            pane_receta.Enabled = false;
                            panel_producto.Enabled = true;
                            inicializarDatos();
                            ActualizarProductos();
                        }     
                        
                        dt.Clear();
                        txtNombreReceta.Text = "Mi receta";
                        txtNombre_producto.Text = "";
                        receta1 = null;
                        det = null;    
                    }
                    else
                    {
                        Funciones.mError(this, "NO se pudo guardar la receta, intente nuevamente");
                    }
                }
            }
            else
            {
                Funciones.mError(this, "Debe agregar al menos un ingrediente para la receta");
            }

        }

        // VUELVE A " " LOS TEXTBOX Y LOS COMBOBOX A UN VALOR DEFAULT
        public void inicializarDatos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "Sin Descripción";
            txtMarca.Text = "";
            rb_simple.Select();
            rdbtnSi.Select();
            txtPrecioCosto.Text = "0.00";
            txtPrecioVenta.Text = "0.00";
            txtStockMinimo.Text = "0";
            txtStock.Text = "0";
            txtId.Text = "" + Producto.Id_producto_siguiente();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // elimina filas de la tabla ingredientes por programación
        private void button2_Click(object sender, EventArgs e)
        {
            Int32 rowToDelete = this.tablaIngredientes.Rows.GetFirstRow(
            DataGridViewElementStates.Selected);
            if (rowToDelete > -1)
            {
                this.tablaIngredientes.Rows.RemoveAt(rowToDelete);
            }
        }

        //Cierra el formulario
        private void button1_Click(object sender, EventArgs e)
        {     
           
                this.Close();
            
            
                
        }

        //CONTROLA QUE EL INGREDIENTE NO ESTE INGRESADO YA EN LA LISTA
        private bool ingredienteRepetido(int id_ingrediente)
        {
            DataTable dt = (DataTable)tablaIngredientes.DataSource;
            int id_producto;

            if (dt == null)
            {
                return false;
            }
            else
            {
                foreach (DataRow fila in dt.Rows)
                {
                    id_producto = Int32.Parse(fila["id_producto"].ToString());
                    if (id_ingrediente == id_producto)
                    {
                        return true;
                    }
                }
                return false;
            }

            
        }

        private void btn_verReceta_Click(object sender, EventArgs e)
        {
            DataSet data = Producto.getReceta(Frm_Baja_Modificar_Producto.Id_producto1);

          
                if (data.Tables[0].Rows.Count == 0 || data == null)
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
                      frm = new Frm_ModificarReceta(Frm_Baja_Modificar_Producto.Id_producto1, txtNombre.Text);
                      frm.Show();
                      frm.WindowState = FormWindowState.Normal;
                    }
                 }
        }

        private void btn_agregarReceta_Click(object sender, EventArgs e)
        {
            if (rb_compuesto.Checked == true)
            {
                pane_receta.Enabled = true;
                txtNombreReceta.Text = "Mi receta";
                panel_producto.Enabled = false;
                txtNombre_producto.Text = txtNombre.Text;
            }
            else
            {
                Funciones.mError(this, "Para agregar una receta, el tipo de producto debe ser \"PRODUCTO COMPUESTO\"");
            }
           
        }
    }
}
