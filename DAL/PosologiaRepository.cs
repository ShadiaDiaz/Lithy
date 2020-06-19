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

        public void Guardar(Posologia posologia)
        {
            using (var Comando = _connection.CreateCommand())
            {
                
                

                    Comando.CommandText = "PAQUETE_POSOLOGIA.Insertar_Posologia";
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add(":Medicamento", OracleDbType.Varchar2).Value = posologia.Medicamento.Nombre;
                    Comando.Parameters.Add(":Dias", OracleDbType.Varchar2).Value = posologia.CantidadDias;
                    Comando.Parameters.Add(":Horas", OracleDbType.Varchar2).Value = posologia.IntervaloHoras;
                    Comando.Parameters.Add(":Cantidad", OracleDbType.Varchar2).Value = posologia.Cantidad;
                    Comando.Parameters.Add(":IdRecetario", OracleDbType.Int32).Value = posologia.Recetario.Codigo;
                    Comando.ExecuteNonQuery();


                
            }
        }


    }
}
