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

namespace LithyGUI
{
    public partial class FormModificarPaciente : Form
    {
        IReceptor Receptor;
        PersonaServiceBD pacienteService;

        public FormModificarPaciente()
        {
            InitializeComponent();
            pacienteService = new PersonaServiceBD(ConfigConnection.connectionString);
        }

        public FormModificarPaciente(IReceptor receptor)
        {
            InitializeComponent();
            Receptor = receptor;
        }

        private void pbtnExtraer_Click(object sender, EventArgs e)
        {
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Identificacion = txtIdentificacion.Text;
            persona.Nombres = txtNombres.Text;
            persona.Apellidos = txtApellidos.Text;
            persona.Edad = char.Parse(txtEdad.Text);
            persona.Sexo = cmbSexo.Text;
            persona.Celular = txtCelular.Text;
            persona.Direccion = txtDireccion.Text;
            persona.Correo = new MailAddress(txtCorreo.Text);

            MessageBox.Show(pacienteService.Modificar(persona));

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            if (pacienteService.Buscar(txtBuscarP.Text) != null)
            {
                dtgvPaciente.DataSource = pacienteService.Buscar(txtBuscarP.Text);

            }
            else
            {
                MessageBox.Show("No se encontro el Paciente", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvPaciente_DoubleClick(object sender, EventArgs e)
        {
            txtCorreo.Text=dtgvPaciente.CurrentRow.Cells[7].Value.ToString();
            txtApellidos.Text=dtgvPaciente.CurrentRow.Cells[2].Value.ToString();
            txtIdentificacion.Text=dtgvPaciente.CurrentRow.Cells[0].Value.ToString();
            txtNombres.Text=dtgvPaciente.CurrentRow.Cells[1].Value.ToString();
            txtEdad.Text=dtgvPaciente.CurrentRow.Cells[3].Value.ToString();
            cmbSexo.Text=dtgvPaciente.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text=dtgvPaciente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text=dtgvPaciente.CurrentRow.Cells[6].Value.ToString();
        }

        private void FormModificarPaciente_Load(object sender, EventArgs e)
        {
            dtgvPaciente.DataSource = pacienteService.Consultar();
        }

        private void dtgvPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
