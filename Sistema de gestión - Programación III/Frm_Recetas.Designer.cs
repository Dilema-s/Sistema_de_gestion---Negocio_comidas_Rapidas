namespace Sistema_de_gestión___Programación_III
{
    partial class Frm_Recetas
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
            this.dt_ingrediente = new System.Windows.Forms.DataGridView();
            this.ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_detalle_receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comb_receta = new System.Windows.Forms.ComboBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_eliminarReceta = new System.Windows.Forms.Button();
            this.txtNombreReceta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ingrediente)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_ingrediente
            // 
            this.dt_ingrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_ingrediente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingrediente,
            this.cantidad,
            this.unidad,
            this.id_detalle_receta,
            this.id_receta});
            this.dt_ingrediente.Location = new System.Drawing.Point(212, 211);
            this.dt_ingrediente.Name = "dt_ingrediente";
            this.dt_ingrediente.ReadOnly = true;
            this.dt_ingrediente.Size = new System.Drawing.Size(344, 271);
            this.dt_ingrediente.TabIndex = 0;
            // 
            // ingrediente
            // 
            this.ingrediente.DataPropertyName = "nombre";
            this.ingrediente.HeaderText = "Ingrediente";
            this.ingrediente.Name = "ingrediente";
            this.ingrediente.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // unidad
            // 
            this.unidad.DataPropertyName = "unidad";
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // id_detalle_receta
            // 
            this.id_detalle_receta.DataPropertyName = "id_detalle_receta";
            this.id_detalle_receta.HeaderText = "id_detalle_receta";
            this.id_detalle_receta.Name = "id_detalle_receta";
            this.id_detalle_receta.ReadOnly = true;
            this.id_detalle_receta.Visible = false;
            // 
            // id_receta
            // 
            this.id_receta.DataPropertyName = "id_receta";
            this.id_receta.HeaderText = "id_receta";
            this.id_receta.Name = "id_receta";
            this.id_receta.ReadOnly = true;
            this.id_receta.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "VERSIONES DE RECETA";
            // 
            // comb_receta
            // 
            this.comb_receta.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comb_receta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_receta.FormattingEnabled = true;
            this.comb_receta.Location = new System.Drawing.Point(462, 47);
            this.comb_receta.Name = "comb_receta";
            this.comb_receta.Size = new System.Drawing.Size(174, 28);
            this.comb_receta.TabIndex = 2;
            this.comb_receta.SelectedIndexChanged += new System.EventHandler(this.comb_receta_SelectedIndexChanged_1);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(664, 543);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_eliminarReceta
            // 
            this.btn_eliminarReceta.Location = new System.Drawing.Point(243, 498);
            this.btn_eliminarReceta.Name = "btn_eliminarReceta";
            this.btn_eliminarReceta.Size = new System.Drawing.Size(124, 23);
            this.btn_eliminarReceta.TabIndex = 5;
            this.btn_eliminarReceta.Text = "ELIMINAR RECETA";
            this.btn_eliminarReceta.UseVisualStyleBackColor = true;
            this.btn_eliminarReceta.Click += new System.EventHandler(this.btn_eliminarReceta_Click);
            // 
            // txtNombreReceta
            // 
            this.txtNombreReceta.Location = new System.Drawing.Point(356, 93);
            this.txtNombreReceta.Name = "txtNombreReceta";
            this.txtNombreReceta.Size = new System.Drawing.Size(200, 20);
            this.txtNombreReceta.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "NOMBRE RECETA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "LISTA INGREDIENTES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(153, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "DETALLE DE RECETA PARA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "FECHA CREACIÓN";
            // 
            // fecha
            // 
            this.fecha.Enabled = false;
            this.fecha.Location = new System.Drawing.Point(356, 128);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "MODIFICAR RECETA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.AutoSize = true;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(496, 10);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(0, 24);
            this.txtNombreProducto.TabIndex = 36;
            // 
            // Frm_Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 587);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_eliminarReceta);
            this.Controls.Add(this.txtNombreReceta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.comb_receta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_ingrediente);
            this.Name = "Frm_Recetas";
            this.Text = "Frm_Recetas";
            this.Load += new System.EventHandler(this.Frm_Recetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_ingrediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_ingrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comb_receta;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_eliminarReceta;
        private System.Windows.Forms.TextBox txtNombreReceta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detalle_receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_receta;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtNombreProducto;
    }
}