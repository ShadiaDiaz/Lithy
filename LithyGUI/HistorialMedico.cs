using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LithyGUI
{
    public partial class HistorialMedico : Form
    {
        public HistorialMedico()
        {
            InitializeComponent();
        }

        private void HistorialMedico_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFrmInpanel(object FrmHijo)
        {
            if (this.panelContenedor1.Controls.Count > 0)
            {
                this.panelContenedor1.Controls.RemoveAt(0);
            }
            Form fh = FrmHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor1.Controls.Add(fh);
            this.panelContenedor1.Tag = fh;
            fh.Show();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrmInpanel(new HistorialTodos());
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrmInpanel(new HistorialPersona());
        }

        private void diagnosticoRecetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrmInpanel(new HistorialDiagnostico());
        }
    }
}
