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
    public class DiagnosticoService
    {
        SqlConnection Conexion;
        DiagnosticoRepository diagnosticoRepository;
        List<Persona> personas;

        public DiagnosticoService()
        {
            string cadenaConexion = @"Data Source=LAPTOP-MKRFM1FC\SQLEXPRESS02;Initial Catalog=DB_Lithy;Integrated Security=True";
            Conexion = new SqlConnection(cadenaConexion);
            diagnosticoRepository = new DiagnosticoRepository(Conexion);
        }

        public string NuevoCodigo(long id)
        {
            
             Conexion.Open();
                
             string nuevo=diagnosticoRepository.NuevoCodigo(id);

            Conexion.Close();
            return nuevo;
            
        }

        public string GuardarDiagnostico(Diagnostico diagnostico)
        {

            try
            {
                Conexion.Open();
                diagnosticoRepository.Guardar(diagnostico);
                return "Diagnostico #" + diagnostico.Codigo + "Para el paciente " + diagnostico.PacienteId + " registrad@ Exitamente";
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
    }
}
