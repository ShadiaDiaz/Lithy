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
    public partial class CitaMedicas : Form
    {
        CitaMedicaService service;
        public CitaMedicas()
        {
            InitializeComponent();
            service = new CitaMedicaService(ConfigConnection.connectionString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textCod.Text = tablaCita.CurrentRow.Cells[0].Value.ToString();
            dateFecha.Text = tablaCita.CurrentRow.Cells[1].Value.ToString();
            textHora.Text = tablaCita.CurrentRow.Cells[2].Value.ToString();
            textId.Text = tablaCita.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CitaMedica cita = new CitaMedica();
        
            cita.CitaId = textCod.Text;
            cita.FechaCita = dateFecha.Value;
            cita.Hora = textHora.Text;
            cita.PersonaId = textId.Text;
            MessageBox.Show(service.Guardar(cita));
        }

        private void MapearDtg(DataGridView dtg)
        {
            dtg.Rows.Clear();
            foreach (var item in service.Consultar())
            {
                int n = dtg.Rows.Add();
                dtg.Rows[n].Cells[0].Value = item.CitaId;
                dtg.Rows[n].Cells[1].Value = item.FechaCita;
                dtg.Rows[n].Cells[2].Value = item.Hora;
                dtg.Rows[n].Cells[3].Value = item.PersonaId;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (service.Buscar(textCod.Text) != null)
            {
                MapearDtg(tablaCita);

            }
            else
            {
                MessageBox.Show("No se encontró", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CitaMedica citaMedica = new CitaMedica();

            citaMedica.FechaCita = dateFecha.Value;
            citaMedica.Hora = textHora.Text;
            citaMedica.CitaId = textCod.Text;
            citaMedica.PersonaId = textId.Text;

            MessageBox.Show(service.Modificar(citaMedica));
        }
    }
}
