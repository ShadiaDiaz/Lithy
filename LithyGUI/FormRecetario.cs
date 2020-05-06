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
    public partial class FormRecetario : Form
    {
        Paciente paciente;
        PacienteServiceBD pacienteService;
        PosologiaService posologiaService;
        MedicamentoService medicamentoService;
        RecetarioService recetarioService;
        Generar generar;
        

        public FormRecetario()
        {
            InitializeComponent();
            generar = new Generar();
            medicamentoService = new MedicamentoService();
            posologiaService = new PosologiaService();
            paciente = new Paciente();
            pacienteService = new PacienteServiceBD();
            recetarioService = new RecetarioService();
        }

        private void FormRecetario_Load(object sender, EventArgs e)
        {

            List<string> list = new List<string>();

            cbxMedicamentos.DataSource = medicamentoService.CosultarRecetario();
        }

        private void pbtnExtraer_Click(object sender, EventArgs e)
        {
            paciente = pacienteService.Buscar(long.Parse(txtIDPR.Text))[0];
            if (paciente != null)
            {
                txtNPR.Text = paciente.Nombres+" "+ paciente.Apellidos;
                string nuevoCodigo = recetarioService.NuevoCodigo(long.Parse(paciente.Identificacion));
                txtCodigoRecetario.Text = nuevoCodigo;

            }
            else
            {
                MessageBox.Show("No se encontro el Paciente", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void picBtnAgregar_Click(object sender, EventArgs e)
        {
            string entrada = cbxMedicamentos.Text + ";" + txtDias.Text + ';' + txtHoras.Text+";"+txtCantidad.Text;
            dtgvMedicinas.Rows.Add(entrada.Split(';'));
        }



        private void EliminarFila(object sender, EventArgs e)
        {
            
            dtgvMedicinas.Rows.RemoveAt(dtgvMedicinas.CurrentRow.Index);
            
        }

        private void picBtnImprimir_Click(object sender, EventArgs e)
        {
          
            Recetario recetario = new Recetario();
            Posologia posologia = new Posologia();
            Paciente paciente = new Paciente();
            List<Posologia> ListaPosologias = new List<Posologia>();
            recetario.Codigo = txtCodigoRecetario.Text;
            paciente.Identificacion = txtIDPR.Text;
            paciente.Nombres = txtNPR.Text;
            recetario.Fecha = DateTime.Parse(dpFecha.Text);
            recetario.Estado = "N";
            recetarioService.Guardar(recetario,txtIDPR.Text);
            for (int fila = 0; fila < dtgvMedicinas.Rows.Count - 1; fila++)
            {
                posologia.Codigo= dtgvMedicinas.Rows[fila].Cells[0].Value.ToString();
                posologia.Nombre = dtgvMedicinas.Rows[fila].Cells[1].Value.ToString();
                posologia.CantidadDias = int.Parse(dtgvMedicinas.Rows[fila].Cells[2].Value.ToString());
                posologia.IntervaloHoras = int.Parse(dtgvMedicinas.Rows[fila].Cells[3].Value.ToString());
                posologia.Cantidad = dtgvMedicinas.Rows[fila].Cells[4].Value.ToString();
                ListaPosologias.Add(posologia);
                MessageBox.Show( posologiaService.Guardar(posologia,recetario.Codigo));
            }

            
            
           generar.FillPDF("Recetario.pdf", ListaPosologias,paciente);
        }

        private void cbxMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
