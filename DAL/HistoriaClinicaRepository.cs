using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Threading.Tasks;

namespace DAL
{
    public class HistoriaClinicaRepository
    {
        private readonly OracleConnection _connection;
        private ConnectionManager conexion;
        private OracleDataReader Reader;

        public HistoriaClinicaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(CitaMedica citaMedica)
        {

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "PAQUETE_HISTORIAMEDIA.Insertar_Historia";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add(":Cod_Cita", OracleDbType.Varchar2).Value = citaMedica.CitaId;
                Comando.Parameters.Add(":FechaCita", OracleDbType.Date).Value = citaMedica.FechaCita;
                Comando.Parameters.Add(":Hora", OracleDbType.Varchar2).Value = citaMedica.Hora;
                Comando.Parameters.Add(":Persona_Id", OracleDbType.Varchar2).Value = citaMedica.PersonaId;
                Comando.ExecuteNonQuery();
            }
        }

        public HistoriaCliente BuscarHistoria(string id,HistoriaCliente historia)
        {
            historia=null;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_HISTORIA.ConsultaHistoriaPersona";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("historias", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("x_persona", OracleDbType.Varchar2).Value = id;
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    historia = MapHistoria(Reader);
                }
            }
            return historia;

        }

        public void BuscarDiagnostico(string id, HistoriaCliente historia)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_HISTORIA.ConsultarHistoriaDiagnostico";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("historias", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("x_persona", OracleDbType.Varchar2).Value = id;
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    Diagnostico diagnostico = MapDiagnostico(Reader);
                    historia.Persona.Diagnosticos.Add(diagnostico);
                }
            }
        }

       

        private Diagnostico MapDiagnostico(OracleDataReader reader)
        {
            Diagnostico diagnostico = new Diagnostico();
            Recetario recetario = new Recetario();
            recetario.Codigo = ((object)reader["codigo"]).ToString();
            recetario.codPaciente = (string)reader["persona_identificación"];
            recetario.Fecha = DateTime.Parse(((object)reader["fecha"]).ToString());
            diagnostico.AgregarRecetario(recetario);
            diagnostico.Codigo = ((object)reader["codigo"]).ToString();
            diagnostico.Descripción = (string)reader["descripción"];
            diagnostico.Fecha = DateTime.Parse(((object)reader["fecha"]).ToString());
            diagnostico.InicioTratamiento = DateTime.Parse(((object)reader["inicio_tratamiento"]).ToString());
            diagnostico.PacienteId = (string)reader["persona_identificación"];
            diagnostico.Primeros_Sintomas = DateTime.Parse(((object)reader["primeros_sintomas"]).ToString());
            return diagnostico;
        }

        private HistoriaCliente MapHistoria(OracleDataReader reader)
        {
            HistoriaCliente historia = new HistoriaCliente();
            Persona persona = new Persona();
            persona.Identificacion = (string)reader["identificación"];
            persona.Nombres = (string)reader["nombres"];
            persona.Apellidos = (string)reader["apellidos"];
            persona.Edad = int.Parse(((object)reader["edad"]).ToString());
            persona.Sexo = (string)reader["sexo"];
            persona.Direccion = (string)reader["direccion"];
            persona.Correo=new System.Net.Mail.MailAddress(((object)reader["correo"]).ToString());
            persona.Celular = (string)reader["celuar"];
            historia.GuardarPersona(persona);
            historia.Codigo = int.Parse((string)reader["codigo"]);
            return historia;
        }
    }
}
