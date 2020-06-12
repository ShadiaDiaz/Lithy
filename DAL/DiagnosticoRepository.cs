using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class DiagnosticoRepository
    {
        private readonly OracleConnection _connection;
        private ConnectionManager conexion;
        List<Diagnostico> diagnostico = new List<Diagnostico>();
   
        public DiagnosticoRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(Diagnostico diagnostico)
        {

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "PAQUETE_DIAGNOSTICO.Insertar_Diagnostico";
                Comando.Parameters.Add(":Codigo", OracleDbType.NVarchar2).Value = diagnostico.Codigo;
                Comando.Parameters.Add(":Fecha", OracleDbType.Date).Value = diagnostico.Fecha;
                Comando.Parameters.Add(":Descripcion", OracleDbType.NVarchar2).Value = diagnostico.Descripción;
                Comando.Parameters.Add(":FechaSintomas", OracleDbType.Date).Value = diagnostico.Primeros_Sintomas;
                Comando.Parameters.Add(":InicioTratamiento", OracleDbType.Date).Value = diagnostico.InicioTratamiento;
                Comando.Parameters.Add(":Paciente", OracleDbType.NVarchar2).Value = diagnostico.PacienteId;
                Comando.ExecuteNonQuery();
            }
        }

        public List<Diagnostico> Consultar()
        {
            OracleDataReader dataReader;
            List<Diagnostico> pacientes = new List<Diagnostico>();

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "Select * from diagnostico";

                dataReader = Comando.ExecuteReader();

                while (dataReader.Read())
                {

                    pacientes.Add(Map(dataReader));
                }

            }

            return pacientes;
        }

        public List<Diagnostico> BuscarPaciente(string id)
        {
            OracleDataReader dataReader;
            List<Diagnostico> diagnostic = new List<Diagnostico>();

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "Select * from diagnostico where codigo=" + id;

                dataReader = Comando.ExecuteReader();

                while (dataReader.Read())
                {

                    diagnostic.Add(Map(dataReader));
                }

            }

            return diagnostic;
        }

        public string NuevoCodigo(string id)
        {
            OracleDataReader dataReader;
            List<Diagnostico> diagnostico = new List<Diagnostico>();

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Diagnostico where codigo like '" + id+"%' order by codigo desc";

                dataReader = Comando.ExecuteReader();

                while (dataReader.Read())
                {

                    diagnostico.Add(Map(dataReader));
                }

            }
            if (diagnostico.Count==0)
            {
                return id+"1";
            }
            else
            {
                Diagnostico diagnostic = diagnostico[0];
                long nuevoCod=long.Parse(diagnostic.Codigo) + 1;
                return nuevoCod.ToString();
            }
            
        }

        public Diagnostico Map(OracleDataReader dataReader)
        {

            Diagnostico diagnostico = new Diagnostico();
            diagnostico.Codigo = (string)dataReader["Codigo"];
            diagnostico.Fecha = (DateTime)dataReader["Fecha"];
            diagnostico.Descripción= (string)dataReader["Descripcion"];
            diagnostico.Primeros_Sintomas = (DateTime)dataReader["FechaSintomas"];
            diagnostico.InicioTratamiento = (DateTime)dataReader["InicioTratamiento"];
            diagnostico.PacienteId = (string)dataReader["Paciente"];
   
           
            return diagnostico;

        }
    }
}
