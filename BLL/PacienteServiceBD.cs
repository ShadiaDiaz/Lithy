using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace BLL
{
    public class PacienteServiceBD
    {
        SqlConnection Conexion;
        PacienteRepository pacienteRepository;
        List<Paciente> pacientes;

        public PacienteServiceBD()
        {
            string cadenaConexion = @"Data Source=LAPTOP-MKRFM1FC\SQLEXPRESS02;Initial Catalog=DB_Lithy;Integrated Security=True";
            Conexion = new SqlConnection(cadenaConexion);
            pacienteRepository = new PacienteRepository(Conexion);
        }

        public string GuardarPaciente(Paciente paciente)
        {

            try
            {
                Conexion.Open();
                pacienteRepository.Guardar(paciente);
                return "Paciente " + paciente.Nombres + " " + paciente.Apellidos + " registrad@ Exitamente";
            }
            catch (Exception excep)
            {

                return "Error en la conexion " + excep.Message;
            }
            finally
            {
                Conexion.Close();
            }
        }

        public string Modificar(Paciente paciente)
        {
            try
            {
                Conexion.Open();
                pacienteRepository.Modiicar(paciente);
                return "Paciente " + paciente.Nombres + " " + paciente.Apellidos + " modificad@ Exitamente";
            }
            catch (Exception excep)
            {

                return "Error en la conexion " + excep.Message;
            }
            finally
            {
                Conexion.Close();
            }
        }

        public List<Paciente> Consultar()
        {
            try
            {
                Conexion.Open();
                pacientes = new List<Paciente>();
                pacientes = pacienteRepository.Consultar();
                Conexion.Close();
                return pacientes;
            }
            catch (Exception)
            {

                return null;

            }
        }

        public List<Paciente> Buscar(long id)
        {
            try
            {

                Conexion.Open();
                return pacienteRepository.BuscarPaciente(id);


            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Conexion.Close();
            }

        }

        public class Respuesta
        {
            public IList<Paciente> ListaPacientes { get; set; }
            public string Mensaje { get; set; }
            public bool IsError { get; set; }
        }

    }

}
