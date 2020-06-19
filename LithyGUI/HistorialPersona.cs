using Entity;
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
    public partial class HistorialPersona : Form
    {
        
        public HistorialPersona(Persona persona)
        {
            InitializeComponent();
            txtIdentificacion.Text = persona.Identificacion;
            txtApellidos.Text = persona.Apellidos;
            cmbSexo.Text = persona.Sexo;
            txtCelular.Text = persona.Celular;
            txtNombres.Text = persona.Nombres;
            txtEdad.Text = persona.Edad.ToString();
            txtDireccion.Text = persona.Direccion;
            txtCorreo.Text = persona.Correo.ToString();
        }

        public HistorialPersona()
        {
            InitializeComponent();
        }

        private void HistorialPersona_Load(object sender, EventArgs e)
        {

        }
    }
}
