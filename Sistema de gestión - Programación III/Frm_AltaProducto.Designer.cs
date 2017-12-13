namespace Sistema_de_gestión___Programación_III
{
    partial class Frm_AltaProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_compuesto = new System.Windows.Forms.RadioButton();
            this.rb_simple = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pane_proSimple = new System.Windows.Forms.Panel();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.pane_receta = new System.Windows.Forms.Panel();
            this.txtNombre_producto = new System.Windows.Forms.Label();
            this.btn_guardarReceta = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNombreReceta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_agregarALista = new System.Windows.Forms.Button();
            this.comboProducto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.comboUnidad = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tablaIngredientes = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pane_precio = new System.Windows.Forms.Panel();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.a_la_venta = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdbtnSi = new System.Windows.Forms.RadioButton();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_producto = new System.Windows.Forms.Panel();
            this.btn_verReceta = new System.Windows.Forms.Button();
            this.btn_agregarReceta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pane_proSimple.SuspendLayout();
            this.pane_receta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIngredientes)).BeginInit();
            this.pane_precio.SuspendLayout();
            this.a_la_venta.SuspendLayout();
            this.panel_producto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "AGREGAR PRODUCTO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_compuesto);
            this.groupBox1.Controls.Add(this.rb_simple);
            this.groupBox1.Location = new System.Drawing.Point(7, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 39);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO";
            // 
            // rb_compuesto
            // 
            this.rb_compuesto.AutoSize = true;
            this.rb_compuesto.Location = new System.Drawing.Point(199, 14);
            this.rb_compuesto.Name = "rb_compuesto";
            this.rb_compuesto.Size = new System.Drawing.Size(157, 17);
            this.rb_compuesto.TabIndex = 1;
            this.rb_compuesto.TabStop = true;
            this.rb_compuesto.Text = "PRODUCTO COMPUESTO";
            this.rb_compuesto.UseVisualStyleBackColor = true;
            this.rb_compuesto.CheckedChanged += new System.EventHandler(this.rb_compuesto_CheckedChanged);
            // 
            // rb_simple
            // 
            this.rb_simple.AutoSize = true;
            this.rb_simple.Location = new System.Drawing.Point(50, 14);
            this.rb_simple.Name = "rb_simple";
            this.rb_simple.Size = new System.Drawing.Size(128, 17);
            this.rb_simple.TabIndex = 0;
            this.rb_simple.TabStop = true;
            this.rb_simple.Text = "PRODUCTO SIMPLE";
            this.rb_simple.UseVisualStyleBackColor = true;
            this.rb_simple.CheckedChanged += new System.EventHandler(this.rb_simple_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRECIO COSTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DESCRIPCIÓN";
            // 
            // pane_proSimple
            // 
            this.pane_proSimple.Controls.Add(this.txtStockMinimo);
            this.pane_proSimple.Controls.Add(this.label8);
            this.pane_proSimple.Controls.Add(this.txtStock);
            this.pane_proSimple.Controls.Add(this.txtMarca);
            this.pane_proSimple.Controls.Add(this.label7);
            this.pane_proSimple.Controls.Add(this.label6);
            this.pane_proSimple.Location = new System.Drawing.Point(3, 331);
            this.pane_proSimple.Name = "pane_proSimple";
            this.pane_proSimple.Size = new System.Drawing.Size(426, 86);
            this.pane_proSimple.TabIndex = 6;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(313, 58);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtStockMinimo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "STOCK MÍNIMO";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(83, 58);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(83, 13);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "STOCK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "MARCA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(114, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 20);
            this.txtId.TabIndex = 7;
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_keyDown);
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_keyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(303, 6);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCosto.TabIndex = 9;
            this.txtPrecioCosto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioCosto_keyDown);
            this.txtPrecioCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCosto_keyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(104, 252);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(325, 73);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.Text = "";
            // 
            // pane_receta
            // 
            this.pane_receta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pane_receta.Controls.Add(this.txtNombre_producto);
            this.pane_receta.Controls.Add(this.btn_guardarReceta);
            this.pane_receta.Controls.Add(this.label17);
            this.pane_receta.Controls.Add(this.txtNombreReceta);
            this.pane_receta.Controls.Add(this.panel1);
            this.pane_receta.Controls.Add(this.button2);
            this.pane_receta.Controls.Add(this.label13);
            this.pane_receta.Controls.Add(this.tablaIngredientes);
            this.pane_receta.Controls.Add(this.label9);
            this.pane_receta.Location = new System.Drawing.Point(560, 69);
            this.pane_receta.Name = "pane_receta";
            this.pane_receta.Size = new System.Drawing.Size(437, 505);
            this.pane_receta.TabIndex = 11;
            // 
            // txtNombre_producto
            // 
            this.txtNombre_producto.AutoSize = true;
            this.txtNombre_producto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNombre_producto.Location = new System.Drawing.Point(231, 11);
            this.txtNombre_producto.Name = "txtNombre_producto";
            this.txtNombre_producto.Size = new System.Drawing.Size(0, 22);
            this.txtNombre_producto.TabIndex = 21;
            // 
            // btn_guardarReceta
            // 
            this.btn_guardarReceta.Location = new System.Drawing.Point(257, 460);
            this.btn_guardarReceta.Name = "btn_guardarReceta";
            this.btn_guardarReceta.Size = new System.Drawing.Size(128, 23);
            this.btn_guardarReceta.TabIndex = 20;
            this.btn_guardarReceta.Text = "GUARDAR RECETA";
            this.btn_guardarReceta.UseVisualStyleBackColor = true;
            this.btn_guardarReceta.Click += new System.EventHandler(this.btn_guardarReceta_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(26, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(199, 20);
            this.label17.TabIndex = 16;
            this.label17.Text = "NUEVA RECETA PARA";
            // 
            // txtNombreReceta
            // 
            this.txtNombreReceta.Location = new System.Drawing.Point(228, 42);
            this.txtNombreReceta.Name = "txtNombreReceta";
            this.txtNombreReceta.Size = new System.Drawing.Size(157, 20);
            this.txtNombreReceta.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.btn_agregarALista);
            this.panel1.Controls.Add(this.comboProducto);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.comboUnidad);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(6, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 115);
            this.panel1.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(129, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "SELECCIONE LOS INGREDIENTES";
            // 
            // btn_agregarALista
            // 
            this.btn_agregarALista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarALista.Location = new System.Drawing.Point(132, 87);
            this.btn_agregarALista.Name = "btn_agregarALista";
            this.btn_agregarALista.Size = new System.Drawing.Size(169, 23);
            this.btn_agregarALista.TabIndex = 10;
            this.btn_agregarALista.Text = "AGREGAR A LISTA";
            this.btn_agregarALista.UseVisualStyleBackColor = true;
            this.btn_agregarALista.Click += new System.EventHandler(this.btn_agregarALista_Click);
            // 
            // comboProducto
            // 
            this.comboProducto.FormattingEnabled = true;
            this.comboProducto.Location = new System.Drawing.Point(112, 27);
            this.comboProducto.Name = "comboProducto";
            this.comboProducto.Size = new System.Drawing.Size(190, 21);
            this.comboProducto.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "PRODUCTO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(112, 62);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // comboUnidad
            // 
            this.comboUnidad.FormattingEnabled = true;
            this.comboUnidad.Location = new System.Drawing.Point(312, 61);
            this.comboUnidad.Name = "comboUnidad";
            this.comboUnidad.Size = new System.Drawing.Size(96, 21);
            this.comboUnidad.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(247, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "UNIDAD";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "ELIMINAR INGREDIENTE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(115, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "LISTA DE INGREDIENTES";
            // 
            // tablaIngredientes
            // 
            this.tablaIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.cantidad,
            this.col_unidad,
            this.id_unidad,
            this.id_producto});
            this.tablaIngredientes.Location = new System.Drawing.Point(30, 269);
            this.tablaIngredientes.Name = "tablaIngredientes";
            this.tablaIngredientes.Size = new System.Drawing.Size(385, 185);
            this.tablaIngredientes.TabIndex = 7;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Ingrediente";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // col_unidad
            // 
            this.col_unidad.DataPropertyName = "unidad";
            this.col_unidad.HeaderText = "Unidad";
            this.col_unidad.Name = "col_unidad";
            this.col_unidad.ReadOnly = true;
            // 
            // id_unidad
            // 
            this.id_unidad.DataPropertyName = "id_unidad";
            this.id_unidad.HeaderText = "id_unidad";
            this.id_unidad.Name = "id_unidad";
            this.id_unidad.ReadOnly = true;
            this.id_unidad.Visible = false;
            // 
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.HeaderText = "id_producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "NOMBRE DE LA RECETA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "CATEGORÍA";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(113, 162);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(120, 21);
            this.comboCategoria.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "PRECIO VENTA";
            // 
            // pane_precio
            // 
            this.pane_precio.Controls.Add(this.txtPrecioVenta);
            this.pane_precio.Controls.Add(this.label4);
            this.pane_precio.Controls.Add(this.label15);
            this.pane_precio.Controls.Add(this.txtPrecioCosto);
            this.pane_precio.Location = new System.Drawing.Point(3, 201);
            this.pane_precio.Name = "pane_precio";
            this.pane_precio.Size = new System.Drawing.Size(426, 34);
            this.pane_precio.TabIndex = 15;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(101, 9);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 15;
            this.txtPrecioVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioVenta_keyDown);
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_keyPress);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(86, 448);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(252, 37);
            this.btn_guardar.TabIndex = 18;
            this.btn_guardar.Text = "GUARDAR PRODUCTO";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // a_la_venta
            // 
            this.a_la_venta.Controls.Add(this.radioButton2);
            this.a_la_venta.Controls.Add(this.rdbtnSi);
            this.a_la_venta.Location = new System.Drawing.Point(7, 120);
            this.a_la_venta.Name = "a_la_venta";
            this.a_la_venta.Size = new System.Drawing.Size(426, 32);
            this.a_la_venta.TabIndex = 19;
            this.a_la_venta.TabStop = false;
            this.a_la_venta.Text = "A LA VENTA";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(199, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "NO";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbtnSi
            // 
            this.rdbtnSi.AutoSize = true;
            this.rdbtnSi.Location = new System.Drawing.Point(101, 10);
            this.rdbtnSi.Name = "rdbtnSi";
            this.rdbtnSi.Size = new System.Drawing.Size(35, 17);
            this.rdbtnSi.TabIndex = 0;
            this.rdbtnSi.TabStop = true;
            this.rdbtnSi.Text = "SI";
            this.rdbtnSi.UseVisualStyleBackColor = true;
            this.rdbtnSi.CheckedChanged += new System.EventHandler(this.rdbtnSi_CheckedChanged);
            // 
            // fecha
            // 
            this.fecha.Enabled = false;
            this.fecha.Location = new System.Drawing.Point(751, 31);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(902, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_producto
            // 
            this.panel_producto.Controls.Add(this.label1);
            this.panel_producto.Controls.Add(this.label2);
            this.panel_producto.Controls.Add(this.groupBox1);
            this.panel_producto.Controls.Add(this.btn_guardar);
            this.panel_producto.Controls.Add(this.a_la_venta);
            this.panel_producto.Controls.Add(this.label5);
            this.panel_producto.Controls.Add(this.pane_proSimple);
            this.panel_producto.Controls.Add(this.pane_precio);
            this.panel_producto.Controls.Add(this.txtId);
            this.panel_producto.Controls.Add(this.comboCategoria);
            this.panel_producto.Controls.Add(this.txtNombre);
            this.panel_producto.Controls.Add(this.label14);
            this.panel_producto.Controls.Add(this.txtDescripcion);
            this.panel_producto.Location = new System.Drawing.Point(60, 69);
            this.panel_producto.Name = "panel_producto";
            this.panel_producto.Size = new System.Drawing.Size(444, 505);
            this.panel_producto.TabIndex = 22;
            // 
            // btn_verReceta
            // 
            this.btn_verReceta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_verReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verReceta.Location = new System.Drawing.Point(60, 601);
            this.btn_verReceta.Name = "btn_verReceta";
            this.btn_verReceta.Size = new System.Drawing.Size(194, 37);
            this.btn_verReceta.TabIndex = 20;
            this.btn_verReceta.Text = "VER RECETAS";
            this.btn_verReceta.UseVisualStyleBackColor = false;
            this.btn_verReceta.Visible = false;
            this.btn_verReceta.Click += new System.EventHandler(this.btn_verReceta_Click);
            // 
            // btn_agregarReceta
            // 
            this.btn_agregarReceta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_agregarReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarReceta.Location = new System.Drawing.Point(310, 601);
            this.btn_agregarReceta.Name = "btn_agregarReceta";
            this.btn_agregarReceta.Size = new System.Drawing.Size(194, 37);
            this.btn_agregarReceta.TabIndex = 23;
            this.btn_agregarReceta.Text = "AGREGAR RECETA";
            this.btn_agregarReceta.UseVisualStyleBackColor = false;
            this.btn_agregarReceta.Visible = false;
            this.btn_agregarReceta.Click += new System.EventHandler(this.btn_agregarReceta_Click);
            // 
            // Frm_AltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 661);
            this.Controls.Add(this.btn_agregarReceta);
            this.Controls.Add(this.btn_verReceta);
            this.Controls.Add(this.panel_producto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.pane_receta);
            this.Controls.Add(this.label3);
            this.Name = "Frm_AltaProducto";
            this.Text = "Alta Producto";
            this.Load += new System.EventHandler(this.Frm_AltaProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pane_proSimple.ResumeLayout(false);
            this.pane_proSimple.PerformLayout();
            this.pane_receta.ResumeLayout(false);
            this.pane_receta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaIngredientes)).EndInit();
            this.pane_precio.ResumeLayout(false);
            this.pane_precio.PerformLayout();
            this.a_la_venta.ResumeLayout(false);
            this.a_la_venta.PerformLayout();
            this.panel_producto.ResumeLayout(false);
            this.panel_producto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_compuesto;
        private System.Windows.Forms.RadioButton rb_simple;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pane_proSimple;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Panel pane_receta;
        private System.Windows.Forms.Button btn_agregarALista;
        private System.Windows.Forms.ComboBox comboProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView tablaIngredientes;
        private System.Windows.Forms.ComboBox comboUnidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pane_precio;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox a_la_venta;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdbtnSi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNombreReceta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button btn_guardarReceta;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_producto;
        private System.Windows.Forms.Label txtNombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.Button btn_verReceta;
        private System.Windows.Forms.Button btn_agregarReceta;
    }
}