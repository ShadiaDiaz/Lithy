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
                Comando.CommandText = "Insert Into Medicamento(Nombre,Presentacion,Cantidad)Values " +
                    "(:Codigo,:Nombre,:Presentacion,:Cantidad)";
                Comando.Parameters.Add(":Nombre", OracleDbType.NVarchar2).Value = medicamento.Nombre;
                Comando.Parameters.Add(":Presentacion", OracleDbType.NVarchar2).Value = medicamento.Presentacion;
                Comando.Parameters.Add(":Cantidad", OracleDbType.NVarchar2).Value = medicamento.Cantidad;
                Comando.ExecuteNonQuery();
            }
        }
        public void Modidicar(Medicamento medicamento)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "update Medicamento set Presentacion=:Presentacion, Cantidad=:Cantidad   where Nombre=" + medicamento.Nombre ;
                Comando.Parameters.Add(":Presentacion", OracleDbType.NVarchar2).Value = medicamento.Presentacion;
                Comando.Parameters.Add(":Cantidad", OracleDbType.NVarchar2).Value = medicamento.Cantidad;

                Comando.ExecuteNonQuery();
            }
        }
        public List<Medicamento> BuscarMedicina(string nombre)
        {
            OracleDataReader dataReader;
            List<Medicamento> medicamentos = new List<Medicamento>();

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Medicamento where nombre=" + nombre;

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
            medicamento.Nombre = (string)dataReader["Nombre"];
            medicamento.Presentacion = (string)dataReader["Presentacion"];
            medicamento.Cantidad = (string)dataReader["Cantidad"];
            return medicamento;

        }
    }
}
