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
    public partial class HistorialDiagnostico : Form
    {
        public IList<Diagnostico> Diagnosticos;
        public HistorialDiagnostico()
        {
            InitializeComponent();
        }

        public HistorialDiagnostico(IList<Diagnostico> diagnosticos,string codigo)
        {
            InitializeComponent();
            Diagnosticos = diagnosticos;
            MapDiagnostico(codigo);
            MapPosologia(codigo);
        }

        private void MapDiagnostico(string codigo)
        {
            foreach (var item in Diagnosticos)
            {
                if (item.Codigo == codigo)
                {
                    TxtDescripcion.Text = item.Descripción;
                }
            }
        }
        private void MapPosologia(string codigo)
        {
            DtgPoslogia.Rows.Clear();
            foreach (var item in Diagnosticos)
            {
                if (item.Codigo == codigo)
                {
                    
                    foreach (var item2 in item.Recetario.Posologias)
                    {
                        DtgPoslogia.Rows.Add(item2.Medicamento.Nombre, item2.CantidadDias, item2.IntervaloHoras, item2.Cantidad);
                    }
                }
            }
        }

        private void HistorialDiagnostico_Load(object sender, EventArgs e)
        {

        }

        private void DtgPoslogia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
