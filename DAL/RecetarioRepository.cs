using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace DAL
{
    public class RecetarioRepository
    {

        private SqlConnection Conexion;
        private SqlDataReader Reader;
        List<Recetario> recetario = new List<Recetario>();
        private SqlCommand Comando;
        public RecetarioRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }

        public void Guardar(Recetario recetario, string idPaciente)
        {

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Recetario(Codigo,Fecha,Estado,CodPaciente)Values " +
                    "(@Codigo,@Fecha,@Estado,@CodPaciente)";
                Comando.Parameters.Add("@Codigo", SqlDbType.NVarChar).Value = recetario.Codigo;
                Comando.Parameters.Add("@Fecha", SqlDbType.NVarChar).Value = recetario.Fecha;
                Comando.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = recetario.Estado;
                Comando.Parameters.Add("@CodPaciente", SqlDbType.NVarChar).Value = idPaciente;

                Comando.ExecuteNonQuery();
            }
        }

        public string NuevoCodigo(long id)
        {

            List<Recetario> recetario = new List<Recetario>();

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Recetario where codigo like '" + id + "%' order by codigo desc";

                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    recetario.Add(Map(Reader));
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

        public List<Recetario> BuscarPaciente(long id)
        {

            List<Recetario> pacientes = new List<Recetario>();

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Recetario where codigo=" + id;

                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    pacientes.Add(Map(Reader));
                }

            }

            return pacientes;
        }


        public List<Recetario> Consultar()
        {

            List<Recetario> recetarios = new List<Recetario>();

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Recetario";

                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    recetarios.Add(Map(Reader));
                }

            }

            return recetarios;
        }

        public Recetario Map(SqlDataReader reader)
        {

            Recetario recetario = new Recetario();
            recetario.Codigo = (string)reader["Codigo"];
            recetario.Fecha = (DateTime)reader["Fecha"];
            recetario.Estado = (string)reader["Estado"];
            return recetario;

        }
    }
}
