using BLL;
using Entity;
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
        HistoriaMedicaService HistoriaMedicaService;
        static int Opcion;
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
            Opcion = 1;
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrmInpanel(new HistorialPersona());
            Opcion = 2;
        }

        private void diagnosticoRecetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrmInpanel(new HistorialDiagnostico());
            Opcion = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistoriaMedicaService = new HistoriaMedicaService(ConfigConnection.connectionString);
            HistoriaCliente historir = new HistoriaCliente();
            HistoriaMedicaService.ConsultarHistoriaCliente(TxtCedula.Text, historir);
            if (Opcion == 2)
            {
                AbrirFrmInpanel(new HistorialPersona(historir));
            }
        }
    }
}
