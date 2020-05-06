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
using InfraEstructura;

namespace LithyGUI
{
    public partial class FormEnvioCorreo : Form
    {
        PacienteServiceBD pacienteService;
        public FormEnvioCorreo()
        {
            InitializeComponent();
            pacienteService = new PacienteServiceBD();
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
            Paciente paciente = new Paciente();
            paciente.Correo = txtCorreo.Text;
            MessageBox.Show(enviarCorreo.EnviarEmail(paciente));
        }

        /* private void Resize(object sender, EventArgs e)
         {

         }*/
    }
}
