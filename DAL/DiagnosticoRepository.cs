using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class DiagnosticoRepository
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        List<Diagnostico> diagnostico = new List<Diagnostico>();
        private SqlCommand Comando;
        public DiagnosticoRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }

        public void Guardar(Diagnostico diagnostico)
        {

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Diagnostico(Codigo,Fecha,Descripcion,FechaSintomas,InicioTratamiento,Paciente,Estado)Values " +
                    "(@Codigo,@Fecha,@Descripcion,@FechaSintomas,@InicioTratamiento,@Paciente,@Estado)";
                Comando.Parameters.Add("@Codigo", SqlDbType.NVarChar).Value = diagnostico.Codigo;
                Comando.Parameters.Add("@Fecha", SqlDbType.NVarChar).Value = diagnostico.Fecha;
                Comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = diagnostico.Descripcion;
                Comando.Parameters.Add("@FechaSintomas", SqlDbType.NVarChar).Value = diagnostico.Primeros_Sintomas;
                Comando.Parameters.Add("@InicioTratamiento", SqlDbType.Date).Value = diagnostico.InicioTratamiento;
                Comando.Parameters.Add("@Paciente", SqlDbType.NVarChar).Value = diagnostico.PacienteId;
                Comando.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = diagnostico.Estado;
                Comando.ExecuteNonQuery();
            }
        }

        public List<Diagnostico> Consultar()
        {

            List<Diagnostico> pacientes = new List<Diagnostico>();

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from diagnostico";

                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    pacientes.Add(Map(Reader));
                }

            }

            return pacientes;
        }

        public List<Diagnostico> BuscarPaciente(long id)
        {

            List<Diagnostico> diagnostic = new List<Diagnostico>();

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from diagnostico where codigo=" + id;

                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    diagnostic.Add(Map(Reader));
                }

            }

            return diagnostic;
        }

        public string NuevoCodigo(long id)
        {

            List<Diagnostico> diagnostico = new List<Diagnostico>();

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Diagnostico where codigo like '" + id+"%' order by codigo desc";

                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    diagnostico.Add(Map(Reader));
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

        public Diagnostico Map(SqlDataReader reader)
        {

            Diagnostico diagnostico = new Diagnostico();
            diagnostico.Codigo = (string)reader["Codigo"];
            diagnostico.Fecha = (DateTime)reader["Fecha"];
            diagnostico.Primeros_Sintomas = (DateTime)reader["FechaSintomas"];
            diagnostico.PacienteId = (string)reader["Paciente"];
            diagnostico.InicioTratamiento = (DateTime)reader["InicioTratamiento"];
            diagnostico.Estado = (string)reader["Estado"];
            diagnostico.Descripcion = (string)reader["Descripcion"];
            return diagnostico;

        }
    }
}
