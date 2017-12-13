namespace Sistema_de_gestión___Programación_III
{
    partial class Frm_ModificarReceta
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.comboProducto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.comboUnidad = new System.Windows.Forms.ComboBox();
            this.btn_agregarIngrediente = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminarIngrediente = new System.Windows.Forms.Button();
            this.btn_modificarIngrediente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_ingrediente = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_detalle_receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreReceta = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comb_receta = new System.Windows.Forms.ComboBox();
            this.btn_eliminarReceta = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ingrediente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(539, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 184);
            this.panel2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.comboProducto);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.comboUnidad);
            this.panel1.Controls.Add(this.btn_agregarIngrediente);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(13, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 152);
            this.panel1.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(119, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "SELECCIONE LOS INGREDIENTES";
            // 
            // comboProducto
            // 
            this.comboProducto.FormattingEnabled = true;
            this.comboProducto.Location = new System.Drawing.Point(112, 40);
            this.comboProducto.Name = "comboProducto";
            this.comboProducto.Size = new System.Drawing.Size(190, 21);
            this.comboProducto.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "PRODUCTO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(112, 74);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // comboUnidad
            // 
            this.comboUnidad.FormattingEnabled = true;
            this.comboUnidad.Location = new System.Drawing.Point(312, 73);
            this.comboUnidad.Name = "comboUnidad";
            this.comboUnidad.Size = new System.Drawing.Size(96, 21);
            this.comboUnidad.TabIndex = 6;
            // 
            // btn_agregarIngrediente
            // 
            this.btn_agregarIngrediente.Location = new System.Drawing.Point(135, 112);
            this.btn_agregarIngrediente.Name = "btn_agregarIngrediente";
            this.btn_agregarIngrediente.Size = new System.Drawing.Size(161, 23);
            this.btn_agregarIngrediente.TabIndex = 28;
            this.btn_agregarIngrediente.Text = "AGREGAR INGREDIENTE";
            this.btn_agregarIngrediente.UseVisualStyleBackColor = true;
            this.btn_agregarIngrediente.Click += new System.EventHandler(this.btn_agregarIngrediente_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(247, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "UNIDAD";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(925, 436);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 29;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_eliminarIngrediente
            // 
            this.btn_eliminarIngrediente.Location = new System.Drawing.Point(302, 436);
            this.btn_eliminarIngrediente.Name = "btn_eliminarIngrediente";
            this.btn_eliminarIngrediente.Size = new System.Drawing.Size(163, 23);
            this.btn_eliminarIngrediente.TabIndex = 30;
            this.btn_eliminarIngrediente.Text = "ELIMINAR INGREDIENTE";
            this.btn_eliminarIngrediente.UseVisualStyleBackColor = true;
            this.btn_eliminarIngrediente.Click += new System.EventHandler(this.btn_eliminarIngrediente_Click);
            // 
            // btn_modificarIngrediente
            // 
            this.btn_modificarIngrediente.Location = new System.Drawing.Point(95, 436);
            this.btn_modificarIngrediente.Name = "btn_modificarIngrediente";
            this.btn_modificarIngrediente.Size = new System.Drawing.Size(163, 23);
            this.btn_modificarIngrediente.TabIndex = 31;
            this.btn_modificarIngrediente.Text = "MODIFICAR INGREDIENTE";
            this.btn_modificarIngrediente.UseVisualStyleBackColor = true;
            this.btn_modificarIngrediente.Click += new System.EventHandler(this.btn_modificarIngrediente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(367, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "RECETA PARA";
            // 
            // dg_ingrediente
            // 
            this.dg_ingrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ingrediente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.cantidad,
            this.unidad,
            this.id_detalle_receta,
            this.id_receta});
            this.dg_ingrediente.Location = new System.Drawing.Point(66, 202);
            this.dg_ingrediente.Name = "dg_ingrediente";
            this.dg_ingrediente.Size = new System.Drawing.Size(434, 218);
            this.dg_ingrediente.TabIndex = 34;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.FillWeight = 200F;
            this.nombre.HeaderText = "INGREDIENTE";
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            // 
            // unidad
            // 
            this.unidad.DataPropertyName = "unidad";
            this.unidad.HeaderText = "UNIDAD";
            this.unidad.Name = "unidad";
            this.unidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // id_detalle_receta
            // 
            this.id_detalle_receta.DataPropertyName = "id_detalle_receta";
            this.id_detalle_receta.HeaderText = "ID_detalle";
            this.id_detalle_receta.Name = "id_detalle_receta";
            this.id_detalle_receta.Visible = false;
            // 
            // id_receta
            // 
            this.id_receta.DataPropertyName = "id_receta";
            this.id_receta.HeaderText = "id_receta";
            this.id_receta.Name = "id_receta";
            this.id_receta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "NOMBRE DE LA RECETA";
            // 
            // txtNombreReceta
            // 
            this.txtNombreReceta.Location = new System.Drawing.Point(776, 78);
            this.txtNombreReceta.Name = "txtNombreReceta";
            this.txtNombreReceta.Size = new System.Drawing.Size(200, 20);
            this.txtNombreReceta.TabIndex = 36;
            // 
            // fecha
            // 
            this.fecha.Enabled = false;
            this.fecha.Location = new System.Drawing.Point(265, 118);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "FECHA CREACIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "LISTA INGREDIENTES";
            // 
            // comb_receta
            // 
            this.comb_receta.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comb_receta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_receta.FormattingEnabled = true;
            this.comb_receta.Location = new System.Drawing.Point(265, 73);
            this.comb_receta.Name = "comb_receta";
            this.comb_receta.Size = new System.Drawing.Size(174, 28);
            this.comb_receta.TabIndex = 41;
            // 
            // btn_eliminarReceta
            // 
            this.btn_eliminarReceta.Location = new System.Drawing.Point(477, 76);
            this.btn_eliminarReceta.Name = "btn_eliminarReceta";
            this.btn_eliminarReceta.Size = new System.Drawing.Size(124, 23);
            this.btn_eliminarReceta.TabIndex = 42;
            this.btn_eliminarReceta.Text = "ELIMINAR RECETA";
            this.btn_eliminarReceta.UseVisualStyleBackColor = true;
            this.btn_eliminarReceta.Click += new System.EventHandler(this.btn_eliminarReceta_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.AutoSize = true;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(575, 24);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(76, 24);
            this.txtNombreProducto.TabIndex = 43;
            this.txtNombreProducto.Text = "sdsdsd";
            // 
            // Frm_ModificarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 480);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.btn_eliminarReceta);
            this.Controls.Add(this.comb_receta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreReceta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_ingrediente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modificarIngrediente);
            this.Controls.Add(this.btn_eliminarIngrediente);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_ModificarReceta";
            this.Text = "Frm_ModificarReceta";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ingrediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox comboUnidad;
        private System.Windows.Forms.Button btn_agregarIngrediente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminarIngrediente;
        private System.Windows.Forms.Button btn_modificarIngrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_ingrediente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreReceta;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comb_receta;
        private System.Windows.Forms.Button btn_eliminarReceta;
        private System.Windows.Forms.Label txtNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detalle_receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_receta;
    }
}