﻿using System;
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
                Comando.CommandText = "PAQUETE_MEDICAMENTO.Insertar_Medicamento";
                Comando.CommandType = CommandType.StoredProcedure;
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
                Comando.CommandText = "PAQUETE_MEDICAMENTO.Modificar_Medicamento";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = medicamento.Nombre;
                Comando.Parameters.Add(":Presentacion", OracleDbType.NVarchar2).Value = medicamento.Presentacion;
                Comando.Parameters.Add(":Cantidad", OracleDbType.NVarchar2).Value = medicamento.Cantidad;

                Comando.ExecuteNonQuery();
            }
        }
        public Medicamento BuscarMedicina(string nombre)
        {
            OracleDataReader dataReader;

            Medicamento medicamento = null;
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "PAQUETE_MEDICAMENTO.Buscar_Medicamento";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("xNombre", OracleDbType.Varchar2).Value = nombre;
                Comando.Parameters.Add("x", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                dataReader = Comando.ExecuteReader();

                while (dataReader.Read())
                {

                    medicamento = Map(dataReader);
                }

            }

            return medicamento;
        }
        public List<Medicamento> Consultar()
        {
            OracleDataReader dataReader;
            List<Medicamento> medicamentos = new List<Medicamento>();

            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "PAQUETE_MEDICAMENTO.Consultar_Medicamento";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("x", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                dataReader = Comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Medicamento medicamento = Map(dataReader);
                        medicamentos.Add(medicamento);
                    }
                }

            }

            return medicamentos;
        }

        

        public Medicamento Map(OracleDataReader dataReader)
        {

            Medicamento medicamento = new Medicamento();
            medicamento.Nombre = ((object)dataReader["Nombre"]).ToString();
            medicamento.Presentacion = ((object)dataReader["Presentación"]).ToString();
            medicamento.Cantidad = ((object)dataReader["Cantidad"]).ToString();
            return medicamento;

        }
        public List<string> ConsultarRecetario()
        {
            List<string> lista = new List<string>();
            foreach (var item in Consultar())
            {
                lista.Add(item.Nombre);
            }
            return lista;
        }
    }
}
