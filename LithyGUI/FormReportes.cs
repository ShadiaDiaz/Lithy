using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace LithyGUI
{
    public partial class FormReportes : Form
    {
        PersonaServiceBD PacienteService;
        DiagnosticoService diagnosticoService;

        public FormReportes()
        {
            InitializeComponent();
            PacienteService = new PersonaServiceBD();
            diagnosticoService = new DiagnosticoService();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            LlenarGrafico();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        public void LlenarGrafico()
        {

            //ctGraficaDiagnostico.Series["Diagnostico"].Points.AddXY("Shadia", "1");
            //ctGraficaDiagnostico.Series["Diagnostico"].Points.AddXY("Juan", "0");

            //ctGraficaDiagnostico.Titles.Add("Pacientes vs Diagnosticos");

        }
    }
}
