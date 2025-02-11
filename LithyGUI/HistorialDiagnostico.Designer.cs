﻿namespace LithyGUI
{
    partial class HistorialDiagnostico
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
            this.DtgPoslogia = new System.Windows.Forms.DataGridView();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDIas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPrimero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textInicio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPoslogia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "RX : ";
            // 
            // DtgPoslogia
            // 
            this.DtgPoslogia.BackgroundColor = System.Drawing.Color.Azure;
            this.DtgPoslogia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPoslogia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombre,
            this.CDIas,
            this.CHoras,
            this.CCantidad});
            this.DtgPoslogia.Location = new System.Drawing.Point(59, 218);
            this.DtgPoslogia.Name = "DtgPoslogia";
            this.DtgPoslogia.Size = new System.Drawing.Size(441, 79);
            this.DtgPoslogia.TabIndex = 1;
            this.DtgPoslogia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPoslogia_CellContentClick);
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            // 
            // CDIas
            // 
            this.CDIas.HeaderText = "CantidadDias";
            this.CDIas.Name = "CDIas";
            // 
            // CHoras
            // 
            this.CHoras.HeaderText = "CantidadHoras";
            this.CHoras.Name = "CHoras";
            // 
            // CCantidad
            // 
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(59, 62);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(441, 46);
            this.TxtDescripcion.TabIndex = 3;
            this.TxtDescripcion.TextChanged += new System.EventHandler(this.TxtDescripcion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Primeros Sintomas";
            // 
            // textPrimero
            // 
            this.textPrimero.Enabled = false;
            this.textPrimero.Location = new System.Drawing.Point(111, 129);
            this.textPrimero.Name = "textPrimero";
            this.textPrimero.Size = new System.Drawing.Size(116, 20);
            this.textPrimero.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inicio de Tratamiento";
            // 
            // textInicio
            // 
            this.textInicio.Location = new System.Drawing.Point(367, 129);
            this.textInicio.Name = "textInicio";
            this.textInicio.Size = new System.Drawing.Size(133, 20);
            this.textInicio.TabIndex = 7;
            this.textInicio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // HistorialDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(564, 338);
            this.Controls.Add(this.textInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPrimero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtgPoslogia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialDiagnostico";
            this.Text = "HistorialDiagnostico";
            this.Load += new System.EventHandler(this.HistorialDiagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPoslogia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtgPoslogia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDIas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPrimero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textInicio;
    }
}