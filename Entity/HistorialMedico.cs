using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HistorialMedico
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public HistorialMedico()
        {

        }

        public HistorialMedico(DateTime fecha, string descripcion)
        {
            Fecha = fecha;
            Descripcion = descripcion;
        }
    }


}
