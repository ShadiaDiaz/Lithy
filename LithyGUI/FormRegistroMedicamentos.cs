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
            MapearConsultar(dtgvMedicamentos);
        }

        private void RegistroMedicamentos_Load(object sender, EventArgs e)
        {
            
        }

        private void MapearConsultar(DataGridView dtg)
        {
            dtg.Rows.Clear();
            foreach (var item in medicamentoService.Consultar())
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.Nombre;
                dtg.Rows[n].Cells[1].Value = item.Presentacion;
                dtg.Rows[n].Cells[2].Value = item.Cantidad;
            }
        }

        private void pbtnGuardarMedicamento_Click(object sender, EventArgs e)
        {
            Medicamento medicamento = new Medicamento();
            medicamento.Nombre = txtNombre.Text;
            medicamento.Presentacion = txtPresentacion.Text;
            medicamento.Cantidad = txtCantidad.Text;
         
            MessageBox.Show(medicamentoService.Guardar(medicamento));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }
        public void MapearBuscar(DataGridView dtg, string nom) {

            dtg.Rows.Clear();
            Medicamento medicamento = medicamentoService.Buscar(nom);
            int n = dtg.Rows.Add();
            dtg.Rows[n].Cells[0].Value = medicamento.Nombre;
            dtg.Rows[n].Cells[1].Value = medicamento.Presentacion;
            dtg.Rows[n].Cells[2].Value = medicamento.Cantidad;



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (medicamentoService.Buscar(textBuscarM.Text) != null)
            {
                Medicamento medicamento = medicamentoService.Buscar(textBuscarM.Text);
                MapearBuscar(dtgvMedicamentos, medicamento.Nombre);

            }
            else
            {
                MessageBox.Show("No se encontro el medicamento", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvMedicamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
          
            txtNombre.Text = dtgvMedicamentos.CurrentRow.Cells[0].Value.ToString();
            txtPresentacion.Text = dtgvMedicamentos.CurrentRow.Cells[1].Value.ToString();
            txtCantidad.Text = dtgvMedicamentos.CurrentRow.Cells[2].Value.ToString();


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Medicamento medicamento = new Medicamento();
           
            medicamento.Nombre = txtNombre.Text;
            medicamento.Presentacion = txtPresentacion.Text;
            medicamento.Cantidad = txtCantidad.Text;

            MessageBox.Show(medicamentoService.Modificar(medicamento));
        }

        private void txtPresentacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
