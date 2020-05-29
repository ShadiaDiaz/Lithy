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
    public partial class FormConsultar : Form
    {
        Persona persona;
        PersonaServiceBD personaService;

        public FormConsultar()
        {
            InitializeComponent();
            persona = new Persona();
            personaService = new PersonaServiceBD(ConfigConnection.connectionString);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (personaService.Buscar(long.Parse(txtBuscarPaciente.Text)) != null)
            {
                dtgvPacientes.DataSource = personaService.Buscar(long.Parse(txtBuscarPaciente.Text));

            }
            else
            {
                MessageBox.Show("No se encontro el Paciente", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormConsultar_Load(object sender, EventArgs e)
        {
            dtgvPacientes.DataSource = personaService.Consultar();
        }

        private void dtgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
