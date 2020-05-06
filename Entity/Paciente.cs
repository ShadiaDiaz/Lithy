using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Paciente
    {
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public List<Diagnostico> Diagnosticos { get; set; }
        public List<Recetario> Recetas { get; set; }
        public List<HistorialMedico> HistoriaMedico { get; set; }

        public Paciente()
        {

        }

        public Paciente(string identificacion, string nombres, string apellidos, int edad, string sexo, string direccion, string celular, string correo, List<Diagnostico> diagnosticos, List<Recetario> recetas, List<HistorialMedico> historiaMedico)
        {
            Identificacion = identificacion;
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
            Sexo = sexo;
            Direccion = direccion;
            Celular = celular;
            Correo = correo;
            Diagnosticos = diagnosticos;
            Recetas = recetas;
            HistoriaMedico = historiaMedico;
        }
    }
}
