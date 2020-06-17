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
        
        public HistorialPersona(HistoriaCliente historia)
        {
            InitializeComponent();
            txtIdentificacion.Text = historia.Persona.Identificacion;
        }

        public HistorialPersona()
        {

        }
    }
}
