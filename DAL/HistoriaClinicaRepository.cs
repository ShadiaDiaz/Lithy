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

        

        public IList<Diagnostico> BuscarDiagnostico(string id, IList<Recetario> recetarios)
        {
            IList<Diagnostico> diagnosticos = new List<Diagnostico>();
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
                    foreach (var item in recetarios)
                    {
                        if (item.Codigo == diagnostico.Codigo)
                        {
                            diagnostico.AgregarRecetario(item);
                            diagnosticos.Add(diagnostico);
                        }
                    }
                    
                }
               
            }
            return diagnosticos;
        }

        public IList<Recetario> BuscarRecetario(string id,IList<Posologia> posologias)
        {
            IList<Recetario> recetarios = new List<Recetario>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_HISTORIA.ConsultarHistoriaDiagnostico";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("historias", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("x_persona", OracleDbType.Varchar2).Value = id;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Recetario recetario = MAPrecetario(Reader);
                    foreach (var item in posologias)
                    {
                        if (item.CodRecetario == recetario.Codigo)
                        {
                            recetario.AgregarPosologia(item);
                        }
                    }
                    recetarios.Add(recetario);
                }
            }
            return recetarios;
        }

        public IList<Posologia> BuscarPosologia(string id)
        {
            IList<Posologia> posologias = new List<Posologia>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "PAQUETE_HISTORIA.ConsultarHistoriaPosologia";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("historias", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("x_persona", OracleDbType.Varchar2).Value = id;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Posologia posologia = MapPosologia(Reader);
                    posologias.Add(posologia);
                }
            }
            return posologias;
        }

        private Posologia MapPosologia(OracleDataReader reader)
        {
            Posologia posologia = new Posologia();
            posologia.CodRecetario = ((object)reader["idrecetario"]).ToString();
            Medicamento medicamento = new Medicamento();
            medicamento.Nombre = (string)reader["medicamento"];
            posologia.AgregarMedicamento(medicamento);
            posologia.CantidadDias = int.Parse(((object)reader["dias"]).ToString());
            posologia.IntervaloHoras = int.Parse(((object)reader["horas"]).ToString());
            posologia.Cantidad = (string)reader["cantidad"];
            return posologia;
        }
        private Diagnostico MapDiagnostico(OracleDataReader reader)
        {
            Diagnostico diagnostico = new Diagnostico();
            diagnostico.Codigo = ((object)reader["codigo"]).ToString();
            diagnostico.Descripción = (string)reader["descripción"];
            diagnostico.Fecha = DateTime.Parse(((object)reader["fecha"]).ToString());
            diagnostico.InicioTratamiento = DateTime.Parse(((object)reader["inicio_tratamiento"]).ToString());
            diagnostico.PacienteId = (string)reader["persona_identificación"];
            diagnostico.Primeros_Sintomas = DateTime.Parse(((object)reader["primeros_sintomas"]).ToString());
            return diagnostico;
        }

        private Recetario MAPrecetario(OracleDataReader reader)
        {
            Recetario recetario = new Recetario();
            recetario.Codigo = ((object)reader["codigo"]).ToString();
            recetario.codPaciente = (string)reader["persona_identificación"];
            recetario.Fecha = DateTime.Parse(((object)reader["fecha"]).ToString());
            return recetario;
        }

       
    }
}
