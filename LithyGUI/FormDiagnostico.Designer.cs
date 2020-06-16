namespace LithyGUI
{
    partial class FormDiagnostico
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtpFechaDiagnostico = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpPrimerosSintomas = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpInicioTratamiento = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pbtnExtraer = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pbtnGuardar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbSintomas = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnExtraer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Formato para manejo de pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Codigo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fecha :";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(595, 117);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(129, 20);
            this.txtCodigo.TabIndex = 31;
            // 
            // dtpFechaDiagnostico
            // 
            this.dtpFechaDiagnostico.Enabled = false;
            this.dtpFechaDiagnostico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDiagnostico.Location = new System.Drawing.Point(595, 147);
            this.dtpFechaDiagnostico.Name = "dtpFechaDiagnostico";
            this.dtpFechaDiagnostico.Size = new System.Drawing.Size(129, 20);
            this.dtpFechaDiagnostico.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Diagnostico medico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(301, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Datos del paciente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(318, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Apellidos :";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(379, 238);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(144, 20);
            this.txtApellidos.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(318, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nombres :";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(379, 279);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(144, 20);
            this.txtNombres.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(108, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "Edad :";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(153, 279);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(139, 20);
            this.txtEdad.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(319, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Diagnostico";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(22, 349);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(700, 75);
            this.txtDescripcion.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 467);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 15);
            this.label13.TabIndex = 48;
            this.label13.Text = "Fecha primeros sintomas :";
            // 
            // dtpPrimerosSintomas
            // 
            this.dtpPrimerosSintomas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrimerosSintomas.Location = new System.Drawing.Point(188, 465);
            this.dtpPrimerosSintomas.Name = "dtpPrimerosSintomas";
            this.dtpPrimerosSintomas.Size = new System.Drawing.Size(136, 20);
            this.dtpPrimerosSintomas.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(396, 465);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 15);
            this.label14.TabIndex = 50;
            this.label14.Text = "Fecha inicio tratamiento :";
            // 
            // dtpInicioTratamiento
            // 
            this.dtpInicioTratamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioTratamiento.Location = new System.Drawing.Point(546, 461);
            this.dtpInicioTratamiento.Name = "dtpInicioTratamiento";
            this.dtpInicioTratamiento.Size = new System.Drawing.Size(137, 20);
            this.dtpInicioTratamiento.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(49, 562);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 15);
            this.label15.TabIndex = 52;
            this.label15.Text = "Firma del doctor ";
            this.label15.Click += new System.EventHandler(this.Label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 549);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "_____________________";
            this.label16.Click += new System.EventHandler(this.Label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(668, 562);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 55;
            this.label17.Text = "Guardar";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(598, 562);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 15);
            this.label18.TabIndex = 57;
            this.label18.Text = "Imprimir";
            this.label18.Click += new System.EventHandler(this.Label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(605, 285);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 15);
            this.label19.TabIndex = 59;
            this.label19.Text = "Extraer";
            // 
            // pbtnExtraer
            // 
            this.pbtnExtraer.Image = global::LithyGUI.Properties.Resources.folder;
            this.pbtnExtraer.Location = new System.Drawing.Point(601, 238);
            this.pbtnExtraer.Name = "pbtnExtraer";
            this.pbtnExtraer.Size = new System.Drawing.Size(50, 44);
            this.pbtnExtraer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbtnExtraer.TabIndex = 58;
            this.pbtnExtraer.TabStop = false;
            this.pbtnExtraer.Click += new System.EventHandler(this.pbtnExtraer_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::LithyGUI.Properties.Resources.print;
            this.pictureBox6.Location = new System.Drawing.Point(588, 518);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(63, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 56;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pbtnGuardar
            // 
            this.pbtnGuardar.Image = global::LithyGUI.Properties.Resources.save;
            this.pbtnGuardar.Location = new System.Drawing.Point(657, 518);
            this.pbtnGuardar.Name = "pbtnGuardar";
            this.pbtnGuardar.Size = new System.Drawing.Size(65, 44);
            this.pbtnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbtnGuardar.TabIndex = 54;
            this.pbtnGuardar.TabStop = false;
            this.pbtnGuardar.Click += new System.EventHandler(this.pbtnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LithyGUI.Properties.Resources.logonegro;
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(153, 240);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(139, 20);
            this.txtIdentificacion.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Identificacion :";
            // 
            // chbSintomas
            // 
            this.chbSintomas.AutoSize = true;
            this.chbSintomas.Location = new System.Drawing.Point(32, 441);
            this.chbSintomas.Name = "chbSintomas";
            this.chbSintomas.Size = new System.Drawing.Size(124, 17);
            this.chbSintomas.TabIndex = 62;
            this.chbSintomas.Text = "¿Presenta sintomas?";
            this.chbSintomas.UseVisualStyleBackColor = true;
            this.chbSintomas.CheckedChanged += new System.EventHandler(this.chbSintomas_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "Jorge Caicedo Camacho";
            // 
            // FormDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(754, 614);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chbSintomas);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pbtnExtraer);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pbtnGuardar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpInicioTratamiento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpPrimerosSintomas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaDiagnostico);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiagnostico";
            this.Text = "Diagnostico";
            this.Load += new System.EventHandler(this.Diagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbtnExtraer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DateTimePicker dtpFechaDiagnostico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpPrimerosSintomas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpInicioTratamiento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pbtnGuardar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pbtnExtraer;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbSintomas;
        private System.Windows.Forms.Label label7;
    }
}