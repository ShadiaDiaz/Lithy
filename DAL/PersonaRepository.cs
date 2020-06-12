using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Entity;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace DAL
{
    public class PersonaRepository
    {
       
        IList<Persona> Personas = new List<Persona>();
        private readonly OracleConnection _connection;
        private ConnectionManager conexion;

        public PersonaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        

        public void Guardar(Persona persona) {

            using(var Comando = _connection.CreateCommand())
            {
                //Comando.CommandText = "Insert Into Persona(Identificación,Nombres,Apellidos,Edad,Sexo,Direccion,Celular,Correo)Values"+
                //    "(:Identificación,:Nombres,:Apellidos,:Edad,:Sexo,:Direccion,:Celular,:Correo)"
                Comando.CommandText = "PAQUETE_PERSONA.Insertar_Persona";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("Identificación", OracleDbType.Varchar2).Value = persona.Identificacion;
                Comando.Parameters.Add("Nombres", OracleDbType.Varchar2).Value = persona.Nombres;
                Comando.Parameters.Add("Apellidos", OracleDbType.Varchar2).Value = persona.Apellidos;
                Comando.Parameters.Add("Edad", OracleDbType.Char).Value = persona.Edad;
                Comando.Parameters.Add("Sexo", OracleDbType.Char).Value = persona.Sexo;
                Comando.Parameters.Add("Direccion", OracleDbType.Varchar2).Value = persona.Direccion;
                Comando.Parameters.Add("Celular", OracleDbType.Varchar2).Value = persona.Celular;
                Comando.Parameters.Add("Correo", OracleDbType.Varchar2).Value = persona.Correo;
                  Comando.ExecuteNonQuery();
              
            }
        }

        public void Modificar(Persona persona)
        {
            using (var Comando = _connection.CreateCommand())
            {

                //Comando.CommandText = "UPDATE persona SET Nombres=:Nombre ,Apellidos=:Apellido ,Edad=:Edad ,Sexo=:Sexo ,Direccion=:Direccion ,Celular=:Celular ,Correo=:Correo where Identificacion="+persona.Identificacion;
                Comando.CommandText = "PAQUETE_PERSONA.Modificar_Persona";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add(":Nombre", OracleDbType.Varchar2).Value = persona.Nombres;
                Comando.Parameters.Add(":Apellido", OracleDbType.Varchar2).Value = persona.Apellidos;
                Comando.Parameters.Add(":Edad", OracleDbType.Int16).Value = persona.Edad;
                Comando.Parameters.Add(":Sexo", OracleDbType.Varchar2).Value = persona.Sexo;
                Comando.Parameters.Add(":Direccion", OracleDbType.Varchar2).Value = persona.Direccion;
                Comando.Parameters.Add(":Celular", OracleDbType.Varchar2).Value = persona.Celular;
                Comando.Parameters.Add(":Correo", OracleDbType.Varchar2).Value = persona.Correo;
                Comando.ExecuteNonQuery();
             
            }
        }

        public List<Persona> Consultar()
        {
            OracleDataReader dataReader;
            List<Persona> Personas = new List<Persona>();

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "PAQUETE_PERSONA.Consultar_Persona";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("Personas", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                dataReader = Comando.ExecuteReader();

                while (dataReader.Read())
                {

                    Personas.Add(Map(dataReader));
                }
                dataReader.Close();
            }

            return Personas;
        }

        public List<Persona> Buscarpersona(string id)
        {
            OracleDataReader dataReader;
            List<Persona> personas = new List<Persona>();

            using (var Comando = _connection.CreateCommand())
            {
              
                Comando.CommandText = "PAQUETE_PERSONA.Buscar_Persona" ;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("xIdentificacion", OracleDbType.Varchar2).Value= id;
                Comando.Parameters.Add("x", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                dataReader = Comando.ExecuteReader();

                while (dataReader.Read())
                {

                    personas.Add(Map(dataReader));
                }

            }

            return personas;
        }

        public Persona Map(OracleDataReader dataReader) {

            Persona persona = new Persona();
            persona.Identificacion = (string)dataReader["Identificación"];
            persona.Nombres = (string)dataReader["Nombres"];
            persona.Apellidos = (string)dataReader["Apellidos"];
            persona.Edad = (int)dataReader["Edad"];
            persona.Sexo = (string)dataReader["Sexo"];
            persona.Direccion = (string)dataReader["Direccion"];
            persona.Celular = (string)dataReader["Celular"];
            persona.Correo = (MailAddress)dataReader["Correo"];
            return persona;

        }
    }
}
