namespace Sistema_de_gestión___Programación_III
{
    partial class Frm_Comanda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirComanda = new System.Windows.Forms.Button();
            this.btnCerrarCoamanda = new System.Windows.Forms.Button();
            this.dgComanda = new System.Windows.Forms.DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMozo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.btnVerComanda = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbpuesto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgComanda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACIÓN DE COMANDAS";
            // 
            // btnAbrirComanda
            // 
            this.btnAbrirComanda.Location = new System.Drawing.Point(894, 271);
            this.btnAbrirComanda.Name = "btnAbrirComanda";
            this.btnAbrirComanda.Size = new System.Drawing.Size(164, 23);
            this.btnAbrirComanda.TabIndex = 1;
            this.btnAbrirComanda.Text = "ABRIR COMANDA NUEVA";
            this.btnAbrirComanda.UseVisualStyleBackColor = true;
            this.btnAbrirComanda.Click += new System.EventHandler(this.btnAbrirComanda_Click);
            // 
            // btnCerrarCoamanda
            // 
            this.btnCerrarCoamanda.Location = new System.Drawing.Point(894, 353);
            this.btnCerrarCoamanda.Name = "btnCerrarCoamanda";
            this.btnCerrarCoamanda.Size = new System.Drawing.Size(164, 23);
            this.btnCerrarCoamanda.TabIndex = 2;
            this.btnCerrarCoamanda.Text = "CERRAR COMANDA";
            this.btnCerrarCoamanda.UseVisualStyleBackColor = true;
            this.btnCerrarCoamanda.Click += new System.EventHandler(this.btnCerrarCoamanda_Click);
            // 
            // dgComanda
            // 
            this.dgComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colComanda,
            this.colMesa,
            this.colMozo,
            this.colEstado,
            this.colTotal,
            this.col_IdEstado});
            this.dgComanda.Location = new System.Drawing.Point(52, 157);
            this.dgComanda.Name = "dgComanda";
            this.dgComanda.Size = new System.Drawing.Size(735, 378);
            this.dgComanda.TabIndex = 4;
            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "fecha";
            this.colFecha.HeaderText = "FECHA";
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 150;
            // 
            // colComanda
            // 
            this.colComanda.DataPropertyName = "id_comanda";
            this.colComanda.HeaderText = "NUM COMANDA";
            this.colComanda.Name = "colComanda";
            this.colComanda.Width = 150;
            // 
            // colMesa
            // 
            this.colMesa.DataPropertyName = "mesa";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.colMesa.DefaultCellStyle = dataGridViewCellStyle1;
            this.colMesa.HeaderText = "MESA";
            this.colMesa.Name = "colMesa";
            // 
            // colMozo
            // 
            this.colMozo.DataPropertyName = "id_persona";
            this.colMozo.HeaderText = "MOZO";
            this.colMozo.Name = "colMozo";
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "estado";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEstado.DefaultCellStyle = dataGridViewCellStyle2;
            this.colEstado.HeaderText = "ESTADO";
            this.colEstado.Name = "colEstado";
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "total";
            this.colTotal.HeaderText = "TOTAL";
            this.colTotal.Name = "colTotal";
            // 
            // col_IdEstado
            // 
            this.col_IdEstado.DataPropertyName = "id_estadoComanda";
            this.col_IdEstado.HeaderText = "id_estado";
            this.col_IdEstado.Name = "col_IdEstado";
            this.col_IdEstado.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "LISTA COMANDAS DE LA FECHA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fecha
            // 
            this.fecha.CustomFormat = "dddd d MMM yyyy   hh:mm ";
            this.fecha.Enabled = false;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(688, 41);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(299, 26);
            this.fecha.TabIndex = 6;
            this.fecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "USUARIO";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(137, 48);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbUsuario.TabIndex = 8;
            this.lbUsuario.Text = "label4";
            // 
            // btnVerComanda
            // 
            this.btnVerComanda.Location = new System.Drawing.Point(894, 311);
            this.btnVerComanda.Name = "btnVerComanda";
            this.btnVerComanda.Size = new System.Drawing.Size(164, 23);
            this.btnVerComanda.TabIndex = 9;
            this.btnVerComanda.Text = "VER COMANDA";
            this.btnVerComanda.UseVisualStyleBackColor = true;
            this.btnVerComanda.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1018, 501);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "SALIR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "PUESTO";
            // 
            // lbpuesto
            // 
            this.lbpuesto.AutoSize = true;
            this.lbpuesto.Location = new System.Drawing.Point(137, 87);
            this.lbpuesto.Name = "lbpuesto";
            this.lbpuesto.Size = new System.Drawing.Size(35, 13);
            this.lbpuesto.TabIndex = 13;
            this.lbpuesto.Text = "label6";
            // 
            // Frm_Comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 556);
            this.Controls.Add(this.lbpuesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnVerComanda);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgComanda);
            this.Controls.Add(this.btnCerrarCoamanda);
            this.Controls.Add(this.btnAbrirComanda);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Comanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRACIÓN DE COMANDAS";
            this.Load += new System.EventHandler(this.Frm_Comanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgComanda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrirComanda;
        private System.Windows.Forms.Button btnCerrarCoamanda;
        private System.Windows.Forms.DataGridView dgComanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button btnVerComanda;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMozo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IdEstado;
    }
}