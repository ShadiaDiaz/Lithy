using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace DAL
{
    public class RecetarioRepository
    {

        private readonly OracleConnection _connection;
        private ConnectionManager conexion;
        List<Recetario> recetario = new List<Recetario>();
   
        public RecetarioRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(Recetario recetario, string idPaciente)
        {

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "Insert Into Recetario(Codigo,Fecha,Posologia,CodPaciente)Values " +
                    "(:Codigo,:Fecha,:Estado,:CodPaciente)";
                Comando.Parameters.Add(":Codigo", OracleDbType.Char).Value = recetario.Codigo;
                Comando.Parameters.Add(":Fecha", OracleDbType.Date).Value = recetario.Fecha;
                Comando.Parameters.Add(":Posologia", OracleDbType.NVarchar2).Value = recetario.Posologias;
                Comando.Parameters.Add(":CodPaciente", OracleDbType.NVarchar2).Value = idPaciente;

                Comando.ExecuteNonQuery();
            }
        }

        public string NuevoCodigo(string id)
        {
            OracleDataReader dataReader;
            List<Recetario> recetario = new List<Recetario>();

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Recetario where codigo like '" + id + "%' order by codigo desc";

                dataReader = Comando.ExecuteReader();

                while (dataReader.Read())
                {

                    recetario.Add(Map(dataReader));
                }

            }
            if (recetario.Count == 0)
            {
                return id + "1";
            }
            else
            {
                Recetario receta = recetario[0];
                long nuevoCod = long.Parse(receta.Codigo) + 1;
                return nuevoCod.ToString();
            }

        }

        public List<Recetario> BuscarPaciente(string id)
        {
            OracleDataReader dataReader;
            List<Recetario> pacientes = new List<Recetario>();

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Recetario where codigo=" + id;

                dataReader = Comando.ExecuteReader();

                while (dataReader.Read())
                {

                    pacientes.Add(Map(dataReader));
                }

            }

            return pacientes;
        }


        public List<Recetario> Consultar()
        {
            OracleDataReader dataReader;
            List<Recetario> recetarios = new List<Recetario>();

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Recetario";

                dataReader = Comando.ExecuteReader();

                while (dataReader.Read())
                {

                    recetarios.Add(Map(dataReader));
                }

            }

            return recetarios;
        }

        public Recetario Map(OracleDataReader dataReader)
        {

            Recetario recetario = new Recetario();
            recetario.Codigo = (string)dataReader["Codigo"];
            recetario.Fecha = (DateTime)dataReader["Fecha"];
            return recetario;

        }
    }
}
