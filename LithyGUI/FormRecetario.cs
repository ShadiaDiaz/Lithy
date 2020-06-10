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
        
        

        public FormRecetario()
        {
            InitializeComponent();
            medicamentoService = new MedicamentoService(ConfigConnection.connectionString);
            posologiaService = new PosologiaService(ConfigConnection.connectionString);
            persona = new Persona();
            PersonaService = new PersonaServiceBD(ConfigConnection.connectionString);
            recetarioService = new RecetarioService(ConfigConnection.connectionString);
        }

        private void FormRecetario_Load(object sender, EventArgs e)
        {

            List<string> list = new List<string>();

            cbxMedicamentos.DataSource = medicamentoService.CosultarRecetario();
        }

        private void pbtnExtraer_Click(object sender, EventArgs e)
        {
            persona = PersonaService.Buscar(txtIDPR.Text)[0];
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
            Posologia posologia = new Posologia();
            Persona persona = new Persona();
            List<Posologia> ListaPosologias = new List<Posologia>();
            recetario.Codigo = txtCodigoRecetario.Text;
            persona.Identificacion = txtIDPR.Text;
            persona.Nombres = txtNPR.Text;
            recetario.Fecha = DateTime.Parse(dpFecha.Text);
           
            recetarioService.Guardar(recetario,txtIDPR.Text);
            for (int fila = 0; fila < dtgvMedicinas.Rows.Count - 1; fila++)
            {
              
                //posologia.Medicamento = dtgvMedicinas.Rows[fila].Cells[0].Value.ToString();
                posologia.CantidadDias = int.Parse(dtgvMedicinas.Rows[fila].Cells[0].Value.ToString());
                posologia.IntervaloHoras = int.Parse(dtgvMedicinas.Rows[fila].Cells[1].Value.ToString());
                posologia.Cantidad = dtgvMedicinas.Rows[fila].Cells[2].Value.ToString();
                ListaPosologias.Add(posologia);
                MessageBox.Show( posologiaService.Guardar(posologia,recetario.Codigo));
            }

            
            
        
        }

        private void cbxMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
