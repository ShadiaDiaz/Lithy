using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Diagnostico:HistorialMedico
    {
        public string Codigo { get; set; }
        public DateTime Primeros_Sintomas { get; set; }
        public DateTime InicioTratamiento { get; set; }
        public string Estado { get; set; }
        public string PacienteId { get; set; }

        public Diagnostico()
        {

        }

        public Diagnostico(string codigo, DateTime primeros_Sintomas, DateTime inicioTratamiento, string estado, string pacienteId)
        {
            Codigo = codigo;
            Primeros_Sintomas = primeros_Sintomas;
            InicioTratamiento = inicioTratamiento;
            Estado = estado;
            PacienteId = pacienteId;
        }
    }
}
