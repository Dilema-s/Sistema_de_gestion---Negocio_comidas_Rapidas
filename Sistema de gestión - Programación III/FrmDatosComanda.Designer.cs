namespace Sistema_de_gestión___Programación_III
{
    partial class FrmDatosComanda
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comb_Mozo = new System.Windows.Forms.ComboBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarMozo = new System.Windows.Forms.Button();
            this.txtnumMesa = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(470, 205);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(371, 205);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "ABRIR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELECCIONE NÚMERO DE MOZO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NÚMERO DE MESA";
            // 
            // comb_Mozo
            // 
            this.comb_Mozo.FormattingEnabled = true;
            this.comb_Mozo.Location = new System.Drawing.Point(245, 102);
            this.comb_Mozo.Name = "comb_Mozo";
            this.comb_Mozo.Size = new System.Drawing.Size(121, 21);
            this.comb_Mozo.TabIndex = 4;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(355, 46);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "ABRIR COMANDA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnBuscarMozo
            // 
            this.btnBuscarMozo.Location = new System.Drawing.Point(400, 102);
            this.btnBuscarMozo.Name = "btnBuscarMozo";
            this.btnBuscarMozo.Size = new System.Drawing.Size(95, 23);
            this.btnBuscarMozo.TabIndex = 8;
            this.btnBuscarMozo.Text = "BUSCAR MOZO";
            this.btnBuscarMozo.UseVisualStyleBackColor = true;
            this.btnBuscarMozo.Click += new System.EventHandler(this.btnBuscarMozo_Click);
            // 
            // txtnumMesa
            // 
            this.txtnumMesa.Location = new System.Drawing.Point(245, 170);
            this.txtnumMesa.Name = "txtnumMesa";
            this.txtnumMesa.Size = new System.Drawing.Size(120, 20);
            this.txtnumMesa.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(242, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(51, 16);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.Text = "label4";
            // 
            // FrmDatosComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 253);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtnumMesa);
            this.Controls.Add(this.btnBuscarMozo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.comb_Mozo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalir);
            this.Name = "FrmDatosComanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABRIR COMANDA";
            ((System.ComponentModel.ISupportInitialize)(this.txtnumMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comb_Mozo;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarMozo;
        private System.Windows.Forms.NumericUpDown txtnumMesa;
        private System.Windows.Forms.Label txtNombre;
    }
}