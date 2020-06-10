using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using BLL;
using Entity;
using InfraEstructura;

namespace LithyGUI
{
    public partial class FormEnvioCorreo : Form
    {
        PersonaServiceBD personaService;
        List<Persona> personas;
        public FormEnvioCorreo()
        {
            InitializeComponent();
            personaService = new PersonaServiceBD(ConfigConnection.connectionString);
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
        }

        private void FormEnvioCorreo_Load(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(100F, 110F);
            this.PerformAutoScale();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EnviarCorreo enviarCorreo = new EnviarCorreo();
            Persona persona = new Persona();
            persona.Correo = new MailAddress(txtCorreo.Text);
            MessageBox.Show(enviarCorreo.EnviarEmail(persona));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Informe";
            saveFileDialog.InitialDirectory = @"c:/document";
            saveFileDialog.DefaultExt = "pdf";
            string filename = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
                if (filename != "" && personas.Count > 0)
                {
                    string mensaje = personaService.GenerarPdf(personas, filename);

                    MessageBox.Show(mensaje, "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se especifico una ruta o No hay datos para generar el reporte", "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
          
        }
    }
}
