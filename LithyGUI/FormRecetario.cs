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
        Persona persona;
        PersonaServiceBD PersonaService;
        PosologiaService posologiaService;
        MedicamentoService medicamentoService;
        RecetarioService recetarioService;
        DiagnosticoService diagnosticoService;
        Generar generar;


        public FormRecetario()
        {
            InitializeComponent();
            generar = new Generar();
            diagnosticoService = new DiagnosticoService(ConfigConnection.connectionString);
            medicamentoService = new MedicamentoService(ConfigConnection.connectionString);
            posologiaService = new PosologiaService(ConfigConnection.connectionString);
            persona = new Persona();
            PersonaService = new PersonaServiceBD(ConfigConnection.connectionString);
            recetarioService = new RecetarioService(ConfigConnection.connectionString);
        }

        private void FormRecetario_Load(object sender, EventArgs e)
        {

            List<string> list = new List<string>();

            cbxMedicamentos.DataSource = medicamentoService.ConsultarEnRecetario();
        }

        private void pbtnExtraer_Click(object sender, EventArgs e)
        {
            persona = PersonaService.Buscar(txtIDPR.Text);
            if (persona != null)
            {
                txtNPR.Text = persona.Nombres+" "+ persona.Apellidos;
                string nuevoCodigo = recetarioService.NuevoCodigo(persona.Identificacion);
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
            if (diagnosticoService.Buscar(txtCodigoRecetario.Text) == null)
            {
                MessageBox.Show("No existe un diagnostico asociado a este recetario", " :C ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {

              
                Posologia posologia = new Posologia();
                Persona persona = new Persona();
                recetario.Codigo = txtCodigoRecetario.Text;
                persona.Identificacion = txtIDPR.Text;
                persona.Nombres = txtNPR.Text;
                recetario.Fecha = DateTime.Parse(dpFecha.Text);
                Medicamento medicamento = new Medicamento();
                posologia.AgregarMedicamento(medicamento);

                for (int fila = 0; fila < dtgvMedicinas.Rows.Count - 1; fila++)
                {

                    posologia.Medicamento.Nombre = dtgvMedicinas.Rows[fila].Cells[0].Value.ToString();
                    posologia.CantidadDias = dtgvMedicinas.Rows[fila].Cells[1].Value.ToString();
                    posologia.IntervaloHoras = dtgvMedicinas.Rows[fila].Cells[2].Value.ToString();
                    posologia.Cantidad = dtgvMedicinas.Rows[fila].Cells[3].Value.ToString();
                    recetario.AgregarPosologia(posologia);

                }

                MessageBox.Show(recetarioService.Guardar(recetario, txtCodigoRecetario.Text));

            }

            generar.FillPDF("Recetario.pdf", recetario.Posologias, persona,recetario.Codigo);

        }


        private void cbxMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
