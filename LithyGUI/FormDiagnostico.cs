using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;
using static BLL.PersonaServiceBD;
using InfraEstructura;
using iTextSharp.text;using iTextSharp.text.pdf;
using System.IO;


namespace LithyGUI
{
    public partial class FormDiagnostico : Form
    {
        Persona persona;
        PersonaServiceBD PersonaService;
        DiagnosticoService diagnosticoService;
        Generar generar;


        public FormDiagnostico()
        {
            InitializeComponent();
            persona = new Persona();
            PersonaService = new PersonaServiceBD(ConfigConnection.connectionString);
            diagnosticoService = new DiagnosticoService();
            generar = new Generar();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Diagnostico_Load(object sender, EventArgs e)
        {
            dtpPrimerosSintomas.Enabled = false;
            dtpInicioTratamiento.Enabled = false;
        }

        private void pbtnExtraer_Click(object sender, EventArgs e)
        {
            persona = PersonaService.Buscar(long.Parse(txtIdentificacion.Text))[0];
            if (persona != null)
            {
                txtNombres.Text = persona.Nombres;
                txtApellidos.Text = persona.Apellidos;
                txtEdad.Text = persona.Edad.ToString();
                string nuevoCodigo= diagnosticoService.NuevoCodigo(long.Parse(persona.Identificacion));
                txtCodigo.Text = nuevoCodigo;

            }
            else
            {
                MessageBox.Show("No se encontro el Paciente", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void chbSintomas_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSintomas.Checked==false)
            {
                dtpInicioTratamiento.Enabled = false;
                dtpPrimerosSintomas.Enabled = false;
            }
            else
            {
                dtpInicioTratamiento.Enabled = true;
                dtpPrimerosSintomas.Enabled = true;
            }
        }

        private void pbtnGuardar_Click(object sender, EventArgs e)
        {
            Diagnostico diagnosti = new Diagnostico();

            diagnosti.Codigo = txtCodigo.Text;
            diagnosti.Descripcion = txtDescripcion.Text;
            diagnosti.Fecha = DateTime.Parse(dtpFechaDiagnostico.Text);
            diagnosti.PacienteId = txtIdentificacion.Text;
            diagnosti.Estado = "S";
            if (chbSintomas.Checked==true)
            {
                diagnosti.InicioTratamiento = dtpInicioTratamiento.Value.Date;
                diagnosti.Primeros_Sintomas = dtpPrimerosSintomas.Value.Date;
            }
            
            MessageBox.Show(diagnosticoService.GuardarDiagnostico(diagnosti));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            List<Persona> respuesta = PersonaService.Consultar();
           // generar.GuardarPdf(respuesta, @"ListaPacientes.pdf");
        }



        /*private void PedirRuta()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*pdf)|*.pdf|all Files(*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = @"ListaPDF.pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;

            }
            if(filename.Trim()!= " ")
            {
                List<Paciente> listaPAciente = pacienteService.Consultar();
                string mensaje = generar.GuardarPdf(listaPAciente, filename);
                MessageBox.Show(mensaje, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("NO SE HA GUARDADO", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }*/
    }
}
