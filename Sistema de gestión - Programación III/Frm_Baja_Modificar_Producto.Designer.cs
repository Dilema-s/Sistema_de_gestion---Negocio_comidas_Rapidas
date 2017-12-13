namespace Sistema_de_gestión___Programación_III
{
    partial class Frm_Baja_Modificar_Producto
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
            this.dt_RecetaDetalle = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminarProducto = new System.Windows.Forms.Button();
            this.btn_modificarProducto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtStock = new System.Windows.Forms.RadioButton();
            this.rbtCategoria = new System.Windows.Forms.RadioButton();
            this.rbtNombre = new System.Windows.Forms.RadioButton();
            this.rbt_id = new System.Windows.Forms.RadioButton();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btn_receta = new System.Windows.Forms.Button();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.rdTodosProductos = new System.Windows.Forms.RadioButton();
            this.rdProductoCompuesto = new System.Windows.Forms.RadioButton();
            this.rdProductoSimple = new System.Windows.Forms.RadioButton();
            this.btm_seleccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_RecetaDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_RecetaDetalle
            // 
            this.dt_RecetaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_RecetaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.descripcion,
            this.Precio_venta,
            this.Precio_Costo,
            this.Marca,
            this.categoria,
            this.stock,
            this.stock_minimo});
            this.dt_RecetaDetalle.Location = new System.Drawing.Point(54, 115);
            this.dt_RecetaDetalle.Name = "dt_RecetaDetalle";
            this.dt_RecetaDetalle.ReadOnly = true;
            this.dt_RecetaDetalle.Size = new System.Drawing.Size(961, 338);
            this.dt_RecetaDetalle.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_producto";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 250;
            // 
            // Precio_venta
            // 
            this.Precio_venta.DataPropertyName = "precio_venta";
            this.Precio_venta.HeaderText = "Precio Venta";
            this.Precio_venta.Name = "Precio_venta";
            this.Precio_venta.ReadOnly = true;
            this.Precio_venta.Width = 60;
            // 
            // Precio_Costo
            // 
            this.Precio_Costo.DataPropertyName = "precio_costo";
            this.Precio_Costo.HeaderText = "Precio Costo";
            this.Precio_Costo.Name = "Precio_Costo";
            this.Precio_Costo.ReadOnly = true;
            this.Precio_Costo.Width = 60;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 50;
            // 
            // stock_minimo
            // 
            this.stock_minimo.DataPropertyName = "stock_minimo";
            this.stock_minimo.HeaderText = "Stock Mínimo";
            this.stock_minimo.Name = "stock_minimo";
            this.stock_minimo.ReadOnly = true;
            this.stock_minimo.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA DE PRODUCTOS";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(920, 545);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_eliminarProducto
            // 
            this.btn_eliminarProducto.Location = new System.Drawing.Point(399, 516);
            this.btn_eliminarProducto.Name = "btn_eliminarProducto";
            this.btn_eliminarProducto.Size = new System.Drawing.Size(151, 23);
            this.btn_eliminarProducto.TabIndex = 3;
            this.btn_eliminarProducto.Text = "ELIMINAR PRODUCTO";
            this.btn_eliminarProducto.UseVisualStyleBackColor = true;
            this.btn_eliminarProducto.Click += new System.EventHandler(this.btn_eliminarProducto_Click);
            // 
            // btn_modificarProducto
            // 
            this.btn_modificarProducto.Location = new System.Drawing.Point(181, 516);
            this.btn_modificarProducto.Name = "btn_modificarProducto";
            this.btn_modificarProducto.Size = new System.Drawing.Size(166, 23);
            this.btn_modificarProducto.TabIndex = 4;
            this.btn_modificarProducto.Text = "MODIFICAR PRODUCTO";
            this.btn_modificarProducto.UseVisualStyleBackColor = true;
            this.btn_modificarProducto.Click += new System.EventHandler(this.btn_modificarProducto_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lbBuscar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtConsulta);
            this.panel1.Location = new System.Drawing.Point(50, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 58);
            this.panel1.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(424, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(3, 21);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(106, 13);
            this.lbBuscar.TabIndex = 2;
            this.lbBuscar.Text = "Ingrese su busqueda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtStock);
            this.groupBox1.Controls.Add(this.rbtCategoria);
            this.groupBox1.Controls.Add(this.rbtNombre);
            this.groupBox1.Controls.Add(this.rbt_id);
            this.groupBox1.Location = new System.Drawing.Point(554, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 36);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUCAR POR: ";
            // 
            // rbtStock
            // 
            this.rbtStock.AutoSize = true;
            this.rbtStock.Location = new System.Drawing.Point(300, 13);
            this.rbtStock.Name = "rbtStock";
            this.rbtStock.Size = new System.Drawing.Size(53, 17);
            this.rbtStock.TabIndex = 3;
            this.rbtStock.TabStop = true;
            this.rbtStock.Text = "Stock";
            this.rbtStock.UseVisualStyleBackColor = true;
            // 
            // rbtCategoria
            // 
            this.rbtCategoria.AutoSize = true;
            this.rbtCategoria.Location = new System.Drawing.Point(222, 12);
            this.rbtCategoria.Name = "rbtCategoria";
            this.rbtCategoria.Size = new System.Drawing.Size(72, 17);
            this.rbtCategoria.TabIndex = 2;
            this.rbtCategoria.TabStop = true;
            this.rbtCategoria.Text = "Categoría";
            this.rbtCategoria.UseVisualStyleBackColor = true;
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Location = new System.Drawing.Point(63, 13);
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Size = new System.Drawing.Size(102, 17);
            this.rbtNombre.TabIndex = 1;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.Text = "Nombre y marca";
            this.rbtNombre.UseVisualStyleBackColor = true;
            // 
            // rbt_id
            // 
            this.rbt_id.AutoSize = true;
            this.rbt_id.Location = new System.Drawing.Point(171, 13);
            this.rbt_id.Name = "rbt_id";
            this.rbt_id.Size = new System.Drawing.Size(36, 17);
            this.rbt_id.TabIndex = 0;
            this.rbt_id.TabStop = true;
            this.rbt_id.Text = "ID";
            this.rbt_id.UseVisualStyleBackColor = true;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(115, 20);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(286, 20);
            this.txtConsulta.TabIndex = 0;
            this.txtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsulta_keyPress);
            // 
            // btn_receta
            // 
            this.btn_receta.Location = new System.Drawing.Point(605, 516);
            this.btn_receta.Name = "btn_receta";
            this.btn_receta.Size = new System.Drawing.Size(102, 23);
            this.btn_receta.TabIndex = 6;
            this.btn_receta.Text = "VER RECETA";
            this.btn_receta.UseVisualStyleBackColor = true;
            this.btn_receta.Click += new System.EventHandler(this.btn_receta_Click);
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.rdTodosProductos);
            this.groupBoxProducto.Controls.Add(this.rdProductoCompuesto);
            this.groupBoxProducto.Controls.Add(this.rdProductoSimple);
            this.groupBoxProducto.Location = new System.Drawing.Point(575, 459);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(440, 33);
            this.groupBoxProducto.TabIndex = 7;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "VER  :";
            // 
            // rdTodosProductos
            // 
            this.rdTodosProductos.AutoSize = true;
            this.rdTodosProductos.Location = new System.Drawing.Point(50, 10);
            this.rdTodosProductos.Name = "rdTodosProductos";
            this.rdTodosProductos.Size = new System.Drawing.Size(63, 17);
            this.rdTodosProductos.TabIndex = 2;
            this.rdTodosProductos.TabStop = true;
            this.rdTodosProductos.Text = "TODOS";
            this.rdTodosProductos.UseVisualStyleBackColor = true;
            this.rdTodosProductos.CheckedChanged += new System.EventHandler(this.rdTodosProductos_CheckedChanged);
            // 
            // rdProductoCompuesto
            // 
            this.rdProductoCompuesto.AutoSize = true;
            this.rdProductoCompuesto.Location = new System.Drawing.Point(260, 10);
            this.rdProductoCompuesto.Name = "rdProductoCompuesto";
            this.rdProductoCompuesto.Size = new System.Drawing.Size(164, 17);
            this.rdProductoCompuesto.TabIndex = 1;
            this.rdProductoCompuesto.TabStop = true;
            this.rdProductoCompuesto.Text = "PRODUCTO COMPUESTOS";
            this.rdProductoCompuesto.UseVisualStyleBackColor = true;
            this.rdProductoCompuesto.CheckedChanged += new System.EventHandler(this.rdProductoCompuesto_CheckedChanged);
            // 
            // rdProductoSimple
            // 
            this.rdProductoSimple.AutoSize = true;
            this.rdProductoSimple.Location = new System.Drawing.Point(119, 10);
            this.rdProductoSimple.Name = "rdProductoSimple";
            this.rdProductoSimple.Size = new System.Drawing.Size(135, 17);
            this.rdProductoSimple.TabIndex = 0;
            this.rdProductoSimple.TabStop = true;
            this.rdProductoSimple.Text = "PRODUCTO SIMPLES";
            this.rdProductoSimple.UseVisualStyleBackColor = true;
            this.rdProductoSimple.CheckedChanged += new System.EventHandler(this.rdProductoSimple_CheckedChanged);
            // 
            // btm_seleccion
            // 
            this.btm_seleccion.Location = new System.Drawing.Point(681, 545);
            this.btm_seleccion.Name = "btm_seleccion";
            this.btm_seleccion.Size = new System.Drawing.Size(165, 23);
            this.btm_seleccion.TabIndex = 8;
            this.btm_seleccion.Text = "SELECCIONAR PRODUCTO";
            this.btm_seleccion.UseVisualStyleBackColor = true;
            this.btm_seleccion.Visible = false;
            this.btm_seleccion.Click += new System.EventHandler(this.btm_seleccion_Click);
            // 
            // Frm_Baja_Modificar_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 598);
            this.Controls.Add(this.btm_seleccion);
            this.Controls.Add(this.groupBoxProducto);
            this.Controls.Add(this.btn_receta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_modificarProducto);
            this.Controls.Add(this.btn_eliminarProducto);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_RecetaDetalle);
            this.Name = "Frm_Baja_Modificar_Producto";
            this.Text = "Frm_Baja_Modificar_Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dt_RecetaDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_RecetaDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminarProducto;
        private System.Windows.Forms.Button btn_modificarProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtStock;
        private System.Windows.Forms.RadioButton rbtCategoria;
        private System.Windows.Forms.RadioButton rbtNombre;
        private System.Windows.Forms.RadioButton rbt_id;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btn_receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_minimo;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.RadioButton rdTodosProductos;
        private System.Windows.Forms.RadioButton rdProductoCompuesto;
        private System.Windows.Forms.RadioButton rdProductoSimple;
        private System.Windows.Forms.Button btm_seleccion;
    }
}