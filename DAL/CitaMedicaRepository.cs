using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity;
using System.Data;

namespace DAL
{
    public class CitaMedicaRepository
    {
        private readonly OracleConnection _connection;
        private ConnectionManager conexion;

        public CitaMedicaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(CitaMedica citaMedica)
        {

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "PAQUETE_CITA.Insertar_Cita";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add(":Cod_Cita", OracleDbType.Varchar2).Value = citaMedica.CitaId;
                Comando.Parameters.Add(":Fecha", OracleDbType.Date).Value = citaMedica.FechaCita;
                Comando.Parameters.Add(":Hora", OracleDbType.Varchar2).Value = citaMedica.Hora;
                Comando.Parameters.Add(":Persona_Id", OracleDbType.Varchar2).Value = citaMedica.PersonaId;
                Comando.ExecuteNonQuery();
            }
        }
        public void Modidicar(CitaMedica citaMedica)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "PAQUETE_CITA.Modificar_Cita";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add(":Fecha", OracleDbType.Date).Value = citaMedica.FechaCita;
                Comando.Parameters.Add(":Hora", OracleDbType.Varchar2).Value = citaMedica.Hora;
                Comando.Parameters.Add(":Persona_Id", OracleDbType.Varchar2).Value = citaMedica.PersonaId;

                Comando.ExecuteNonQuery();
            }
        }
        public List<CitaMedica> BuscarCita(string cod)
        {
            OracleDataReader dataReader;
            List<CitaMedica> citas = new List<CitaMedica>();

            using (var Comando = _connection.CreateCommand())
            {

                Comando.CommandText = "PAQUETE_CITA.Buscar_Cita";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("xCod_cita", OracleDbType.Varchar2).Value = cod;
                Comando.Parameters.Add("x", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                dataReader = Comando.ExecuteReader();

                while (dataReader.Read())
                {

                    citas.Add(Map(dataReader));
                }

            }
            return citas;
        }
        public List<CitaMedica> Consultar()
        {
            OracleDataReader dataReader;
            List<CitaMedica> citas = new List<CitaMedica>();

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "PAQUETE_CITA.Consultar_Cita";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("x", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                dataReader = Comando.ExecuteReader();

                while (dataReader.Read())
                {
                    citas.Add(Map(dataReader));
                }

            }

            return citas;
        }
        public CitaMedica Map(OracleDataReader dataReader)
        {

            CitaMedica cita = new CitaMedica();
            cita.CitaId = (string)dataReader["Cod_cita"];
            cita.FechaCita = (DateTime)dataReader["Fecha"];
            cita.Hora = (string)dataReader["Hora"];
            cita.PersonaId = (string)dataReader["Persona_Id"];
            return cita;
        }
    }
}
