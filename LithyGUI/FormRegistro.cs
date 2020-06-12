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
using Entity;
using BLL;

namespace LithyGUI
{
    public partial class FormRegistro : Form, IReceptor
    {
        PersonaServiceBD pacienteService;

        public FormRegistro()
        {
            InitializeComponent();
            pacienteService = new PersonaServiceBD(ConfigConnection.connectionString);

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void Receptor(Persona persona)
        {
            if (persona != null)
            {
                Persona person = new Persona();
                person = persona;
                string idAux = txtIdentificacion.Text;
            }

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarPaciente form = new FormModificarPaciente(this);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Identificacion = txtIdentificacion.Text;
            persona.Nombres = txtNombres.Text;
            persona.Apellidos = txtApellidos.Text;
            persona.Edad = int.Parse(txtEdad.Text);
            persona.Sexo = cmbSexo.Text;
            persona.Direccion = txtDireccion.Text;
            persona.Celular = txtCelular.Text;
            persona.Correo = new MailAddress(txtCorreo.Text);
            MessageBox.Show(pacienteService.GuardarPaciente(persona));
        }
    }
}
