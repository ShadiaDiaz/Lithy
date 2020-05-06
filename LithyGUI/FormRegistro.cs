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

namespace LithyGUI
{
    public partial class FormRegistro : Form, IReceptor
    {
        PacienteServiceBD pacienteService;

        public FormRegistro()
        {
            InitializeComponent();
            pacienteService = new PacienteServiceBD();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void Receptor(Paciente paciente)
        {
            if (paciente != null)
            {
                Paciente pacient = new Paciente();
                pacient = paciente;
                string idAux = txtIdentificacion.Text;
            }

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.Identificacion = txtIdentificacion.Text;
            paciente.Nombres = txtNombres.Text;
            paciente.Apellidos = txtApellidos.Text;
            paciente.Celular = txtCelular.Text;
            paciente.Sexo = cmbSexo.Text;
            paciente.Direccion = txtDireccion.Text;
            paciente.Edad = Int16.Parse(txtEdad.Text);
            paciente.Correo = txtCorreo.Text;
            MessageBox.Show(pacienteService.GuardarPaciente(paciente));
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarPaciente form = new FormModificarPaciente(this);
            form.Show();
        }
        
    }
}
