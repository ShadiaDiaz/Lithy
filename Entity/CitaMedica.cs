using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CitaMedica
    {
        public string CitaId { get; set; }
        public DateTime FechaCita { get; set; }
        public string PersonaId { get; set; }
        public string Hora { get; set; }
        public CitaMedica()
        {

        }

        public CitaMedica(string citaId, DateTime fechaCita, string personaId, string hora)
        {
            CitaId = citaId;
            FechaCita = fechaCita;
            PersonaId = personaId;
            Hora = hora;
           
        }
    }
}
