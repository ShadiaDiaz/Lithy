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
    public class MedicamentoRepository
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        private SqlCommand Comando;
        public MedicamentoRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public void Guardar(Medicamento medicamento)
        {

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Medicamento(Codigo,Nombre,Presentacion,Precio)Values " +
                    "(@Codigo,@Nombre,@Presentacion,@Precio)";
                Comando.Parameters.Add("@Codigo", SqlDbType.NVarChar).Value = medicamento.Codigo;
                Comando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = medicamento.Nombre;
                Comando.Parameters.Add("@Presentacion", SqlDbType.NVarChar).Value = medicamento.Presentacion;
                Comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = medicamento.Precio;
                Comando.ExecuteNonQuery();
            }
        }
        public void Modidicar(Medicamento medicamento)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "update Medicamento set Nombre=@Nombre ,Presentacion=@Presentacion ,Precio=@Precio  where Codigo=" + medicamento.Codigo ;
                Comando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = medicamento.Nombre;
                Comando.Parameters.Add("@Presentacion", SqlDbType.NVarChar).Value = medicamento.Presentacion;
                Comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = medicamento.Precio;
         
                Comando.ExecuteNonQuery();
            }
        }
        public List<Medicamento> BuscarMedicina(long cod)
        {

            List<Medicamento> medicamentos = new List<Medicamento>();

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Medicamento where codigo=" + cod;

                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    medicamentos.Add(Map(Reader));
                }

            }

            return medicamentos;
        }
        public List<Medicamento> Consultar()
        {

            List<Medicamento> medicamentos = new List<Medicamento>();

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Medicamento";

                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {
                    medicamentos.Add(Map(Reader));
                }

            }

            return medicamentos;
        }

        

        public Medicamento Map(SqlDataReader reader)
        {

            Medicamento medicamento = new Medicamento();
            medicamento.Codigo = (string)reader["Codigo"];
            medicamento.Nombre = (string)reader["Nombre"];
            medicamento.Presentacion = (string)reader["Presentacion"];
            medicamento.Precio = (decimal)reader["Precio"];
            return medicamento;

        }
    }
}
