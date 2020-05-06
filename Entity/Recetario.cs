using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Recetario
    {
        public string Codigo { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha  { get; set; }
        public List<Posologia> Posologias { get; set; }

        public Recetario()
        {

        }

        public Recetario(string codigo, string estado, DateTime fecha, List<Posologia> posologias)
        {
            Codigo = codigo;
            Estado = estado;
            Fecha = fecha;
            Posologias = posologias;
        }
    }
}
