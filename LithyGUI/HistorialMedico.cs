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
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrmInpanel(new HistorialPersona());
        }

        private void diagnosticoRecetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrmInpanel(new HistorialDiagnostico());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistoriaMedicaService = new HistoriaMedicaService(ConfigConnection.connectionString);
            PersonaServiceBD personaservice = new PersonaServiceBD(ConfigConnection.connectionString);
            Persona persona = personaservice.Buscar(TxtCedula.Text);
            IList<Recetario> recetarios = HistoriaMedicaService.ConsultarHistoriaClienteRecetario(TxtCedula.Text);
            
            IList<Diagnostico> Diagnosticos=HistoriaMedicaService.ConsultarHistoriaClienteDiagnosticos(TxtCedula.Text, recetarios);

            AbrirFrmInpanel(new HistorialPersona(persona));
            foreach (var item in Diagnosticos)
            {
                CmbDiagnosticos.Items.Add(item.Codigo);
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HistoriaMedicaService = new HistoriaMedicaService(ConfigConnection.connectionString);
            IList<Recetario> recetarios = HistoriaMedicaService.ConsultarHistoriaClienteRecetario(TxtCedula.Text);

            IList<Diagnostico> Diagnosticos = HistoriaMedicaService.ConsultarHistoriaClienteDiagnosticos(TxtCedula.Text, recetarios);

            AbrirFrmInpanel(new HistorialDiagnostico(Diagnosticos, CmbDiagnosticos.Text));
        }
    }
}
