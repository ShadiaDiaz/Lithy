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
    public class PacienteRepository
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        IList<Paciente> Pacientes = new List<Paciente>();
        private SqlCommand Comando;
        public PacienteRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public void Guardar(Paciente paciente) {

            using(var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Paciente(Cedula,Nombres,Apellidos,Edad,Sexo,Direccion,Celular,Correo)Values " +
                    "(@Cedula,@Nombre,@Apellido,@Edad,@Sexo,@Direccion,@Celular,@Correo)";
                Comando.Parameters.Add("@Cedula", SqlDbType.NVarChar).Value = paciente.Identificacion;
                Comando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = paciente.Nombres;
                Comando.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = paciente.Apellidos;
                Comando.Parameters.Add("@Edad", SqlDbType.Int).Value = paciente.Edad;
                Comando.Parameters.Add("@Sexo", SqlDbType.NVarChar).Value = paciente.Sexo;
                Comando.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = paciente.Direccion;
                Comando.Parameters.Add("@Celular", SqlDbType.NVarChar).Value = paciente.Celular;
                Comando.Parameters.Add("@Correo", SqlDbType.NVarChar).Value = paciente.Correo;
                Comando.ExecuteNonQuery();
            }
        }

        public void Modiicar(Paciente paciente)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "update Paciente set Nombres=@Nombre ,Apellidos=@Apellido ,Edad=@Edad ,Sexo=@Sexo ,Direccion=@Direccion ,Celular=@Celular ,Correo=@Correo where Cedula="+paciente.Identificacion;
                Comando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = paciente.Nombres;
                Comando.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = paciente.Apellidos;
                Comando.Parameters.Add("@Edad", SqlDbType.Int).Value = paciente.Edad;
                Comando.Parameters.Add("@Sexo", SqlDbType.NVarChar).Value = paciente.Sexo;
                Comando.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = paciente.Direccion;
                Comando.Parameters.Add("@Celular", SqlDbType.NVarChar).Value = paciente.Celular;
                Comando.Parameters.Add("@Correo", SqlDbType.NVarChar).Value = paciente.Correo;
                Comando.ExecuteNonQuery();
            }
        }

        public List<Paciente> Consultar()
        {

            List<Paciente> pacientes = new List<Paciente>();

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Paciente";

                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    pacientes.Add(Map(Reader));
                }

            }

            return pacientes;
        }

        public List<Paciente> BuscarPaciente(long id)
        {

            List<Paciente> pacientes = new List<Paciente>();

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Paciente where cedula=" + id;

                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    pacientes.Add(Map(Reader));
                }

            }

            return pacientes;
        }

        public Paciente Map(SqlDataReader reader) {

            Paciente paciente = new Paciente();
            paciente.Identificacion = (string)reader["Cedula"];
            paciente.Nombres = (string)reader["Nombres"];
            paciente.Apellidos = (string)reader["Apellidos"];
            paciente.Edad = (int)reader["Edad"];
            paciente.Sexo = (string)reader["Sexo"];
            paciente.Direccion = (string)reader["Direccion"];
            paciente.Celular = (string)reader["Celular"];
            paciente.Correo = (string)reader["Correo"];
            return paciente;

        }
    }
}
