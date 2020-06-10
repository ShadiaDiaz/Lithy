using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HistorialMedico
    {
        public List<Persona> Personas { get; set; }
        public List<Diagnostico> Diagnosticos { get; set; }
        public List<Recetario> Recetas { get; set; }

        public HistorialMedico()
        {

        }

        public HistorialMedico(List<Diagnostico> diagnosticos, List<Recetario> recetas, List<Persona> personas)
        {
            Diagnosticos = diagnosticos;
            Recetas = recetas;
            Personas = personas;
        }
    }


}
