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
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class MedicamentoRepository
    {
        private readonly OracleConnection _connection;
        private ConnectionManager conexion;
        public MedicamentoRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Medicamento medicamento)
        {

            using (var Comando = _connection.CreateCommand())
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
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "update Medicamento set Nombre=@Nombre ,Presentacion=@Presentacion ,Precio=@Precio  where Codigo=" + medicamento.Codigo ;
                Comando.Parameters.Add("@Nombre", OracleDbType.NVarchar2).Value = medicamento.Nombre;
                Comando.Parameters.Add("@Presentacion", OracleDbType.NVarchar2).Value = medicamento.Presentacion;
                Comando.Parameters.Add("@Precio", OracleDbType.decimal).Value = medicamento.Precio;
         
                Comando.ExecuteNonQuery();
            }
        }
        public List<Medicamento> BuscarMedicina(long cod)
        {
            OracleDataReader dataReader;
            List<Medicamento> medicamentos = new List<Medicamento>();

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Medicamento where codigo=" + cod;

                dataReader = Comando.ExecuteReader();

                while (dataReader.Read())
                {

                    medicamentos.Add(Map(dataReader));
                }

            }

            return medicamentos;
        }
        public List<Medicamento> Consultar()
        {
            OracleDataReader dataReader;
            List<Medicamento> medicamentos = new List<Medicamento>();

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Medicamento";

                dataReader = Comando.ExecuteReader();

                while (dataReader.Read())
                {
                    medicamentos.Add(Map(dataReader));
                }

            }

            return medicamentos;
        }

        

        public Medicamento Map(OracleDataReader dataReader)
        {

            Medicamento medicamento = new Medicamento();
            medicamento.Codigo = (string)dataReader["Codigo"];
            medicamento.Nombre = (string)dataReader["Nombre"];
            medicamento.Presentacion = (string)dataReader["Presentacion"];
            medicamento.Precio = (decimal)dataReader["Precio"];
            return medicamento;

        }
    }
}
