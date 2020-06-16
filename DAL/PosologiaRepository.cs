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
    public class PosologiaRepository
    {
        private readonly OracleConnection _connection;
        private ConnectionManager conexion;
        List<Recetario> recetario = new List<Recetario>();
       
        public PosologiaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(Posologia posologia, string idRecetario)
        {

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "PAQUETE_POSOLOGIA.Insertar_Posologia";
                Comando.Parameters.Add(":Medicamento", OracleDbType.NVarchar2).Value = posologia.Medicamento;
                Comando.Parameters.Add(":Dias", OracleDbType.Char).Value = posologia.CantidadDias;
                Comando.Parameters.Add(":Horas", OracleDbType.NVarchar2).Value = posologia.IntervaloHoras;
                Comando.Parameters.Add(":Cantidad", OracleDbType.Char).Value = posologia.Cantidad;
                Comando.Parameters.Add(":CodRecetario", OracleDbType.Char).Value = idRecetario; ;

               
           

                Comando.ExecuteNonQuery();
            }
        }


    }
}
