using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;


namespace BLL
{
    public class DiagnosticoService
    {
        private readonly ConnectionManager conexion;

        private readonly DiagnosticoRepository repositorio;
        List<Persona> personas;

        public DiagnosticoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new DiagnosticoRepository(conexion);
        }

        public string NuevoCodigo(string id)
        {
            //try
             conexion.Open();
                
             string nuevo=repositorio.NuevoCodigo(id);

            conexion.Close();
            return nuevo;
            
        }

        public string GuardarDiagnostico(Diagnostico diagnostico)
        {

            try
            {
                conexion.Open();
                repositorio.Guardar(diagnostico);
                return "Diagnostico #" + diagnostico.Codigo + "Para el paciente " + diagnostico.PacienteId + " registrad@ Exitamente";
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
    }
}
