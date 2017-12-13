namespace Sistema_de_gestión___Programación_III
{
    partial class FrmTicket
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dtComanda = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Id_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMozo = new System.Windows.Forms.Label();
            this.txtMesa = new System.Windows.Forms.Label();
            this.txtNumComanda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.btnCantidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtComanda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMANDA N° :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "MOZO : ";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(353, 17);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(241, 22);
            this.date.TabIndex = 2;
            // 
            // dtComanda
            // 
            this.dtComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colCantidad,
            this.colPrecioVenta,
            this.colTotal,
            this.col_Id_detalle});
            this.dtComanda.Location = new System.Drawing.Point(91, 111);
            this.dtComanda.Name = "dtComanda";
            this.dtComanda.Size = new System.Drawing.Size(443, 325);
            this.dtComanda.TabIndex = 3;
            // 
            // colProducto
            // 
            this.colProducto.DataPropertyName = "nombre";
            this.colProducto.HeaderText = "PRODUCTO";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.DataPropertyName = "cantidad";
            this.colCantidad.HeaderText = "CANTIDAD";
            this.colCantidad.Name = "colCantidad";
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.DataPropertyName = "precio_venta";
            this.colPrecioVenta.HeaderText = "PRECIO UNITARIO";
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "total";
            this.colTotal.HeaderText = "TOTAL";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // col_Id_detalle
            // 
            this.col_Id_detalle.DataPropertyName = "id_detalle_comanda";
            this.col_Id_detalle.HeaderText = "Id_detalle";
            this.col_Id_detalle.Name = "col_Id_detalle";
            this.col_Id_detalle.Visible = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.Location = new System.Drawing.Point(91, 455);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(237, 36);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Location = new System.Drawing.Point(91, 519);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(237, 37);
            this.btnEliminarProducto.TabIndex = 5;
            this.btnEliminarProducto.Text = "ELIMINAR PRODUCTO";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(519, 519);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 37);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "MESA : ";
            // 
            // txtMozo
            // 
            this.txtMozo.AutoSize = true;
            this.txtMozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMozo.Location = new System.Drawing.Point(195, 50);
            this.txtMozo.Name = "txtMozo";
            this.txtMozo.Size = new System.Drawing.Size(57, 20);
            this.txtMozo.TabIndex = 8;
            this.txtMozo.Text = "label4";
            // 
            // txtMesa
            // 
            this.txtMesa.AutoSize = true;
            this.txtMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesa.Location = new System.Drawing.Point(195, 78);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Size = new System.Drawing.Size(57, 20);
            this.txtMesa.TabIndex = 9;
            this.txtMesa.Text = "label5";
            // 
            // txtNumComanda
            // 
            this.txtNumComanda.AutoSize = true;
            this.txtNumComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumComanda.Location = new System.Drawing.Point(195, 19);
            this.txtNumComanda.Name = "txtNumComanda";
            this.txtNumComanda.Size = new System.Drawing.Size(57, 20);
            this.txtNumComanda.TabIndex = 10;
            this.txtNumComanda.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "SUBTOTAL";
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSubtotal.Location = new System.Drawing.Point(498, 455);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(57, 20);
            this.lbSubtotal.TabIndex = 12;
            this.lbSubtotal.Text = "label5";
            // 
            // btnCantidad
            // 
            this.btnCantidad.Location = new System.Drawing.Point(353, 527);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(121, 23);
            this.btnCantidad.TabIndex = 13;
            this.btnCantidad.Text = "Modificar cantidad";
            this.btnCantidad.UseVisualStyleBackColor = true;
            this.btnCantidad.Visible = false;
            this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click);
            // 
            // FrmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 568);
            this.Controls.Add(this.btnCantidad);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumComanda);
            this.Controls.Add(this.txtMesa);
            this.Controls.Add(this.txtMozo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dtComanda);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTicket";
            this.Text = "FrmTicket";
            ((System.ComponentModel.ISupportInitialize)(this.dtComanda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DataGridView dtComanda;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtMozo;
        private System.Windows.Forms.Label txtMesa;
        private System.Windows.Forms.Label txtNumComanda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id_detalle;
        private System.Windows.Forms.Button btnCantidad;
    }
}