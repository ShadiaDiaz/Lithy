namespace LithyGUI
{
    partial class HistorialMedico
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
            this.tablaTemporal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTemporal)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaTemporal
            // 
            this.tablaTemporal.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.tablaTemporal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTemporal.Location = new System.Drawing.Point(12, 192);
            this.tablaTemporal.Name = "tablaTemporal";
            this.tablaTemporal.Size = new System.Drawing.Size(654, 150);
            this.tablaTemporal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historial Medico ";
            // 
            // HistorialMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(678, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaTemporal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialMedico";
            this.Text = "HistorialMedico";
            ((System.ComponentModel.ISupportInitialize)(this.tablaTemporal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaTemporal;
        private System.Windows.Forms.Label label1;
    }
}