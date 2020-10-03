namespace Menu_de_Navegacio.Formularios
{
    partial class FrmCalificaciones_de_Estudiantes
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrimeracalificacion = new System.Windows.Forms.TextBox();
            this.txtSegundacalificacion = new System.Windows.Forms.TextBox();
            this.txtTerceracalificacion = new System.Windows.Forms.TextBox();
            this.txtCuartacalificacion = new System.Windows.Forms.TextBox();
            this.BtnCalcularpromedio = new System.Windows.Forms.Button();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(417, 356);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(120, 39);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese las 4 Calificaciones del Estudiante:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingresar la Primera Calificacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingresar la Segunda Calificacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingresar la Tercera Calificacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ingresar la Cuarta Calificacion:";
            // 
            // txtPrimeracalificacion
            // 
            this.txtPrimeracalificacion.Location = new System.Drawing.Point(268, 83);
            this.txtPrimeracalificacion.Name = "txtPrimeracalificacion";
            this.txtPrimeracalificacion.Size = new System.Drawing.Size(154, 20);
            this.txtPrimeracalificacion.TabIndex = 12;
            this.txtPrimeracalificacion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSegundacalificacion
            // 
            this.txtSegundacalificacion.Location = new System.Drawing.Point(268, 120);
            this.txtSegundacalificacion.Name = "txtSegundacalificacion";
            this.txtSegundacalificacion.Size = new System.Drawing.Size(154, 20);
            this.txtSegundacalificacion.TabIndex = 13;
            // 
            // txtTerceracalificacion
            // 
            this.txtTerceracalificacion.Location = new System.Drawing.Point(268, 157);
            this.txtTerceracalificacion.Name = "txtTerceracalificacion";
            this.txtTerceracalificacion.Size = new System.Drawing.Size(154, 20);
            this.txtTerceracalificacion.TabIndex = 14;
            // 
            // txtCuartacalificacion
            // 
            this.txtCuartacalificacion.Location = new System.Drawing.Point(268, 193);
            this.txtCuartacalificacion.Name = "txtCuartacalificacion";
            this.txtCuartacalificacion.Size = new System.Drawing.Size(154, 20);
            this.txtCuartacalificacion.TabIndex = 15;
            // 
            // BtnCalcularpromedio
            // 
            this.BtnCalcularpromedio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcularpromedio.Location = new System.Drawing.Point(42, 239);
            this.BtnCalcularpromedio.Name = "BtnCalcularpromedio";
            this.BtnCalcularpromedio.Size = new System.Drawing.Size(156, 35);
            this.BtnCalcularpromedio.TabIndex = 16;
            this.BtnCalcularpromedio.Text = "Calcular Promedio";
            this.BtnCalcularpromedio.UseVisualStyleBackColor = true;
            this.BtnCalcularpromedio.Click += new System.EventHandler(this.BtnCalcularpromedio_Click);
            // 
            // txtPromedio
            // 
            this.txtPromedio.BackColor = System.Drawing.Color.White;
            this.txtPromedio.Location = new System.Drawing.Point(268, 295);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(154, 20);
            this.txtPromedio.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "El Promedio de los Estudiantes es de:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(280, 356);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(120, 39);
            this.BtnLimpiar.TabIndex = 19;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmCalificaciones_de_Estudiantes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(549, 407);
            this.ControlBox = false;
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCalcularpromedio);
            this.Controls.Add(this.txtCuartacalificacion);
            this.Controls.Add(this.txtTerceracalificacion);
            this.Controls.Add(this.txtSegundacalificacion);
            this.Controls.Add(this.txtPrimeracalificacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Name = "FrmCalificaciones_de_Estudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular el Promedio de Calificaciones de Estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrimeracalificacion;
        private System.Windows.Forms.TextBox txtSegundacalificacion;
        private System.Windows.Forms.TextBox txtTerceracalificacion;
        private System.Windows.Forms.TextBox txtCuartacalificacion;
        private System.Windows.Forms.Button BtnCalcularpromedio;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}