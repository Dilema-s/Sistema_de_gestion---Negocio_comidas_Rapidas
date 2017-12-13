namespace Sistema_de_gestión___Programación_III
{
    partial class Frm_ActualizarContraseña
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
            this.tbReNewPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAceptarNewPass = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbReNewPass
            // 
            this.tbReNewPass.Location = new System.Drawing.Point(150, 123);
            this.tbReNewPass.Name = "tbReNewPass";
            this.tbReNewPass.PasswordChar = '*';
            this.tbReNewPass.Size = new System.Drawing.Size(194, 20);
            this.tbReNewPass.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Repetir contraseña";
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(150, 97);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(194, 20);
            this.tbNewPass.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Contraseña nueva";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(150, 45);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(194, 20);
            this.tbUsuario.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Usuario";
            // 
            // tbOldPass
            // 
            this.tbOldPass.Location = new System.Drawing.Point(150, 71);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.PasswordChar = '*';
            this.tbOldPass.Size = new System.Drawing.Size(194, 20);
            this.tbOldPass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Contraseña anterior";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "ACTUALIZAR CONTRASEÑA";
            // 
            // btnAceptarNewPass
            // 
            this.btnAceptarNewPass.Location = new System.Drawing.Point(167, 164);
            this.btnAceptarNewPass.Name = "btnAceptarNewPass";
            this.btnAceptarNewPass.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNewPass.TabIndex = 5;
            this.btnAceptarNewPass.Text = "Aceptar";
            this.btnAceptarNewPass.UseVisualStyleBackColor = true;
            this.btnAceptarNewPass.Click += new System.EventHandler(this.btnAceptarNewPass_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(269, 164);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 76;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Frm_ActualizarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 213);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarNewPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbOldPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReNewPass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label10);
            this.Name = "Frm_ActualizarContraseña";
            this.Text = "Frm_ActualizarContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbReNewPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAceptarNewPass;
        private System.Windows.Forms.Button btnCancelar;
    }
}