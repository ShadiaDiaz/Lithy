using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Diagnostico
    {
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripción { get; set; }
        public DateTime Primeros_Sintomas { get; set; }
        public DateTime InicioTratamiento { get; set; }
        public string PacienteId { get; set; }
        public Recetario Recetario { get; set; }

        public Diagnostico()
        {

        }

        public Diagnostico(string codigo,DateTime fecha, string descripción, DateTime primeros_Sintomas, DateTime inicioTratamiento, string pacienteId)
        {
            Codigo = codigo;
            Fecha = fecha;
            Descripción = descripción;
            Primeros_Sintomas = primeros_Sintomas;
            InicioTratamiento = inicioTratamiento;
            PacienteId = pacienteId;
        }

        public void AgregarRecetario(Recetario recetario)
        {
            Recetario = recetario;
        }
    }
}
