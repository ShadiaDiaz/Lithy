using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public char Tipo { get; set; }
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

        public Persona()
        {

        }

        public Persona(char tipo, string identificacion, string nombres, string apellidos, int edad, string sexo, string direccion, string celular, string correo, List<Diagnostico> diagnosticos, List<Recetario> recetas, List<HistorialMedico> historiaMedico)
        {
            Tipo = tipo;
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
