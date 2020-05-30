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
    public partial class FormRegistroMedicamentos : Form
    {
        MedicamentoService medicamentoService;

        public FormRegistroMedicamentos()
        {
            InitializeComponent();
            medicamentoService = new MedicamentoService(ConfigConnection.connectionString);
        }

        private void RegistroMedicamentos_Load(object sender, EventArgs e)
        {
            dtgvMedicamentos.DataSource = medicamentoService.Cosultar();
        }

        private void pbtnGuardarMedicamento_Click(object sender, EventArgs e)
        {
            Medicamento medicamento = new Medicamento();
            medicamento.Codigo = txtCodigo.Text;
            medicamento.Nombre = txtNombre.Text;
            medicamento.Presentacion = txtPresentacion.Text;
            medicamento.Precio = decimal.Parse(txtPrecio.Text);
            MessageBox.Show(medicamentoService.Guardar(medicamento));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (medicamentoService.Buscar(long.Parse(textBuscarM.Text)) != null)
            {
                dtgvMedicamentos.DataSource = medicamentoService.Buscar(long.Parse(textBuscarM.Text));

            }
            else
            {
                MessageBox.Show("No se encontro el Paciente", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvMedicamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtCodigo.Text = dtgvMedicamentos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgvMedicamentos.CurrentRow.Cells[1].Value.ToString();
            txtPresentacion.Text = dtgvMedicamentos.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dtgvMedicamentos.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Medicamento medicamento = new Medicamento();
            medicamento.Codigo = txtCodigo.Text;
            medicamento.Nombre = txtNombre.Text;
            medicamento.Presentacion = txtPresentacion.Text;
            medicamento.Precio = decimal.Parse(txtPrecio.Text);

            MessageBox.Show(medicamentoService.Modificar(medicamento));
        }
    }
}
