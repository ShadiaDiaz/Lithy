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
    public partial class FormModificarPaciente : Form
    {
        IReceptor Receptor;
        PacienteServiceBD pacienteService;

        public FormModificarPaciente()
        {
            InitializeComponent();
            pacienteService = new PacienteServiceBD();
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
            Paciente paciente = new Paciente();
            paciente.Identificacion = txtIdentificacion.Text;
            paciente.Nombres = txtNombres.Text;
            paciente.Apellidos = txtApellidos.Text;
            paciente.Edad = int.Parse(txtEdad.Text);
            paciente.Sexo = cmbSexo.Text;
            paciente.Celular = txtCelular.Text;
            paciente.Direccion = txtDireccion.Text;
            paciente.Correo = txtCorreo.Text;

            MessageBox.Show(pacienteService.Modificar(paciente));

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
            if (pacienteService.Buscar(long.Parse(txtBuscarP.Text)) != null)
            {
                dtgvPaciente.DataSource = pacienteService.Buscar(long.Parse(txtBuscarP.Text));

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
