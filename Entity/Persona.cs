using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Entity
{
    public class Persona
    {
      
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public MailAddress Correo { get; set; }
        public List<Diagnostico> Diagnosticos { get; set; }
        public List<Recetario> Recetas { get; set; }
        public Diagnostico Diagnostico { get; set; }

        public Persona()
        {
            Diagnosticos = new List<Diagnostico>();
        }

        public Persona( string identificacion, string nombres, string apellidos, int edad, string sexo, string direccion, string celular, MailAddress correo, List<Diagnostico> diagnosticos, List<Recetario> recetas)
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
        }

        public void AgregarDiagnosticos(Diagnostico diagnostico)
        {
            Diagnosticos.Add(diagnostico);
        }


    }
}
