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
        public DateTime Fecha  { get; set; }
        public string codPaciente { get; set; }
        public List<Posologia> Posologias { get; set;}

        public Recetario()
        {
            Posologias = new List<Posologia>();
        }

        public Recetario(string codigo,  DateTime fecha,string codpaciente, List<Posologia> posologias)
        {
            Codigo = codigo;
            Fecha = fecha;
            codPaciente = codpaciente;
            Posologias = posologias;
        }

        public void AgregarPosologia(Posologia posologia)
        {
            posologia.Recetario = this;
            Posologias.Add(posologia);
        }
    }
}
