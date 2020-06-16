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
    public  class HistoriaClinicaRepository
    {
        private readonly OracleConnection _connection;
        private ConnectionManager conexion;

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
       
    }
}
