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

        public void Guardar(Recetario recetario)
        {
            using (var Comando = _connection.CreateCommand())
            {
                foreach (var item in recetario.Posologias)
                {

                    Comando.CommandText = "PAQUETE_POSOLOGIA.Insertar_Posologia";
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add(":Medicamento", OracleDbType.Varchar2).Value = item.Medicamento.Nombre;
                    Comando.Parameters.Add(":Dias", OracleDbType.Int32).Value = item.CantidadDias;
                    Comando.Parameters.Add(":Horas", OracleDbType.Int32).Value = item.IntervaloHoras;
                    Comando.Parameters.Add(":Cantidad", OracleDbType.Varchar2).Value = item.Cantidad;
                    Comando.Parameters.Add(":CodRecetario", OracleDbType.Int32).Value = int.Parse(recetario.Codigo);
                    Comando.ExecuteNonQuery();

                }
            }
        }


    }
}
