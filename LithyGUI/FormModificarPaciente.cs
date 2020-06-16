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
        PersonaServiceBD PersonaService;

        public FormModificarPaciente()
        {
            InitializeComponent();
            PersonaService = new PersonaServiceBD(ConfigConnection.connectionString);
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
            //if (PersonaService.Buscar(txtBuscarP.Text) != null)
            //{
            //    dtgvPaciente.DataSource = PersonaService.Buscar(txtBuscarP.Text);

            //}
            //else
            //{
            //    MessageBox.Show("No se encontro el Paciente", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void dtgvPaciente_DoubleClick(object sender, EventArgs e)
        {
            txtIdentificacion.Text = dtgvPaciente.CurrentRow.Cells[0].Value.ToString();
            txtNombres.Text = dtgvPaciente.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dtgvPaciente.CurrentRow.Cells[2].Value.ToString();
            txtEdad.Text = dtgvPaciente.CurrentRow.Cells[3].Value.ToString();
            cmbSexo.Text = dtgvPaciente.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dtgvPaciente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = dtgvPaciente.CurrentRow.Cells[6].Value.ToString();
            txtCorreo.Text = dtgvPaciente.CurrentRow.Cells[7].Value.ToString();

        }

        private void FormModificarPaciente_Load(object sender, EventArgs e)
        {
            //dtgvPaciente.DataSource = pacienteService.Consultar();
            Mapear(dtgvPaciente);
        }

        private void dtgvPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mapear(dtgvPaciente);
            //dtgvPaciente.DataSource = pacienteService.Consultar();
            //int N = dtgvPaciente.Rows.Add();
            //List<Persona> personas = new List<Persona>();
            // foreach (var item in personas)
            //{
            //    dtgvPaciente.Rows[N].Cells[0].Value = item.Identificacion;
            //    dtgvPaciente.Rows[N].Cells[1].Value = item.Nombres;
            //    dtgvPaciente.Rows[N].Cells[2].Value = item.Apellidos;
            //    dtgvPaciente.Rows[N].Cells[3].Value = item.Edad;
            //    dtgvPaciente.Rows[N].Cells[4].Value = item.Sexo;
            //    dtgvPaciente.Rows[N].Cells[5].Value = item.Direccion;
            //    dtgvPaciente.Rows[N].Cells[6].Value = item.Celular;
            //    dtgvPaciente.Rows[N].Cells[7].Value = item.Correo;

            //}

        }
        public void Mapear(DataGridView dtg) {

            PersonaService = new PersonaServiceBD(ConfigConnection.connectionString);
            dtg.Rows.Clear();
            foreach (var item in PersonaService.Consultar())
            {
                int N = dtg.Rows.Add();
                dtg.Rows[N].Cells[0].Value = item.Identificacion;
                dtg.Rows[N].Cells[1].Value = item.Nombres;
                dtg.Rows[N].Cells[2].Value = item.Apellidos;
                dtg.Rows[N].Cells[3].Value = item.Edad;
                dtg.Rows[N].Cells[4].Value = item.Sexo;
                dtg.Rows[N].Cells[5].Value = item.Direccion;
                dtg.Rows[N].Cells[6].Value = item.Celular;
                dtg.Rows[N].Cells[7].Value = item.Correo;

            }





        }
        public void LlenarTabla()
        {

            dtgvPaciente.DataSource = PersonaService.Consultar();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            Persona persona = new Persona();
            persona.Identificacion = txtIdentificacion.Text;
            persona.Nombres = txtNombres.Text;
            persona.Apellidos = txtApellidos.Text;
            persona.Edad = int.Parse(txtEdad.Text);
            persona.Sexo = cmbSexo.Text;
            persona.Celular = txtCelular.Text;
            persona.Direccion = txtDireccion.Text;
            persona.Correo = new MailAddress(txtCorreo.Text);

            MessageBox.Show(PersonaService.Modificar(persona));

        }
    }
}
