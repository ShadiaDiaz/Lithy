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
        CitaMedicaService citaService;
        public CitaMedicas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CitaMedica cita = new CitaMedica();
            cita.CitaId = textCod.Text;
            cita.FechaCita = dateFecha.Value;
            cita.Hora = textHora.Text;
            cita.PersonaId = textId.Text;

            MessageBox.Show(citaService.Guardar(cita));
        }
    }
}
