using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LithyGUI
{
    public partial class HistorialTodos : Form
    {
        public PersonaServiceBD PersonaServiceBD;
        public HistorialTodos()
        {
            InitializeComponent();
            MapearPacientes();
        }

        private void MapearPacientes()
        {
            PersonaServiceBD = new PersonaServiceBD(ConfigConnection.connectionString);
            DtgPersonas.Rows.Clear();
            foreach (var item in PersonaServiceBD.Consultar())
            {
                DtgPersonas.Rows.Add(item.Identificacion, item.Nombres, item.Apellidos, item.Edad, item.Sexo, item.Direccion, item.Celular, item.Correo);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
