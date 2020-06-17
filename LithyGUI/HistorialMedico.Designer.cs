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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticoRecetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historial Medico ";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(144, 118);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(118, 20);
            this.TxtCedula.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem,
            this.personaToolStripMenuItem,
            this.diagnosticoRecetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(17, 81);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(201, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // personaToolStripMenuItem
            // 
            this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            this.personaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.personaToolStripMenuItem.Text = "Persona";
            this.personaToolStripMenuItem.Click += new System.EventHandler(this.personaToolStripMenuItem_Click);
            // 
            // diagnosticoRecetToolStripMenuItem
            // 
            this.diagnosticoRecetToolStripMenuItem.Name = "diagnosticoRecetToolStripMenuItem";
            this.diagnosticoRecetToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.diagnosticoRecetToolStripMenuItem.Text = "Diagnostico";
            this.diagnosticoRecetToolStripMenuItem.Click += new System.EventHandler(this.diagnosticoRecetToolStripMenuItem_Click);
            // 
            // panelContenedor1
            // 
            this.panelContenedor1.Location = new System.Drawing.Point(33, 161);
            this.panelContenedor1.Name = "panelContenedor1";
            this.panelContenedor1.Size = new System.Drawing.Size(633, 330);
            this.panelContenedor1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::LithyGUI.Properties.Resources.herramientas_de_edicion;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(278, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Consultar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(412, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(542, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 16;
            this.button2.Text = "Diagnostico";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // HistorialMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(697, 503);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panelContenedor1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HistorialMedico";
            this.Text = "HistorialMedico";
            this.Load += new System.EventHandler(this.HistorialMedico_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticoRecetToolStripMenuItem;
        private System.Windows.Forms.Panel panelContenedor1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}