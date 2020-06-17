using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HistoriaCliente
    {
        public int Codigo { get; set; }
        public Persona Persona { get; set; }

        public void GuardarPersona(Persona persona)
        {
            Persona = persona;
        }
    }
}
