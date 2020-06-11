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
            try
            {
                conexion.Open();
                Personas = new List<Persona>();
                Personas = repositorio.Consultar();
                conexion.Close();
                return Personas;
            }
            catch (Exception)
            {

                return null;

            }
        }

        public List<Persona> Buscar(string id)
        {
            try
            {

                conexion.Open();
                return repositorio.Buscarpersona(id);


            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }

        }
        public string GenerarPdf(List<Persona> personas, string filename)
        {
            Generar documentoPdf = new Generar();
            try
            {
                documentoPdf.GuardarPdf(personas, filename);
                return "Se genró el Documento satisfactoriamente";
            }
            catch (Exception e)
            {

                return "Error al crear docuemnto" + e.Message;
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
