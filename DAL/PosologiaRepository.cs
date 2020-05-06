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
    public class PosologiaRepository
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        List<Recetario> recetario = new List<Recetario>();
        private SqlCommand Comando;
        public PosologiaRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }

        public void Guardar(Posologia posologia, string idRecetario)
        {

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Posologia (CodMedicamento,Dias,Cada,cantidad,CodRecetario)Values " +
                    "(@CodMedicamento,@Dias,@Cada,@Cantidad,@CodRecetario)";
                Comando.Parameters.Add("@CodMedicamento", SqlDbType.NVarChar).Value = posologia.Codigo;
                Comando.Parameters.Add("@Dias", SqlDbType.NVarChar).Value = posologia.CantidadDias;
                Comando.Parameters.Add("@Cada", SqlDbType.NVarChar).Value = posologia.CantidadDias;
                Comando.Parameters.Add("@Cantidad", SqlDbType.NVarChar).Value = posologia.Cantidad;
                Comando.Parameters.Add("@CodRecetario", SqlDbType.NVarChar).Value = idRecetario;

                Comando.ExecuteNonQuery();
            }
        }


    }
}
