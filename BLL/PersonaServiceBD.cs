using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using InfraEstructura;



namespace BLL
{
    public class PersonaServiceBD
    {
        private readonly ConnectionManager conexion;

        private readonly PersonaRepository repositorio;
        List<Persona> Personas;

        public PersonaServiceBD(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new PersonaRepository(conexion);

        }

        public string GuardarPaciente(Persona persona)
        {

            try
            {
                conexion.Open();
              
                    repositorio.Guardar(persona);
                    return $"Se guardaron los datos satisfactoriamente";
               
            }
            catch (Exception excep)
            {

                return "Error en la conexion " + excep.Message;
            }
            finally
            {
                conexion.Close();
            }
        }

        public string Modificar(Persona persona)
        {
            try
            {
                conexion.Open();
                repositorio.Modificar(persona);
                return "Persona " + persona.Nombres + " " + persona.Apellidos + " modificad@ Exitamente";
            }
            catch (Exception excep)
            {

                return "Error en la conexion " + excep.Message;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Persona> Consultar()
        {
            conexion.Open();
            Personas = new List<Persona>();
            Personas = repositorio.Consultar();
            conexion.Close();
            return Personas;
            try
            {
                
                
            }
            catch (Exception)
            {

                //return null;

            }
        }

        public Persona Buscar(string id)
        {
            Persona persona;
            conexion.Open();
            persona = repositorio.Buscarpersona(id);
            conexion.Close();
            return persona;
            try
            {

               


            }
            catch (Exception)
            {
                
            }
            finally
            {
                
            }

        }
   
        public class Respuesta
        {
            public IList<Persona> ListaPacientes { get; set; }
            public string Mensaje { get; set; }
            public bool IsError { get; set; }
        }

    }

}
