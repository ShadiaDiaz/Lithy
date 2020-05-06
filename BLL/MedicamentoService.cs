using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace BLL
{
    public class MedicamentoService
    {
        SqlConnection Conexion;
        MedicamentoRepository medicamentoRepository;
        List<Medicamento> medicamentos;

        public MedicamentoService()
        {
            string cadenaConexion = @"Data Source=LAPTOP-MKRFM1FC\SQLEXPRESS02;Initial Catalog=DB_Lithy;Integrated Security=True";
            Conexion = new SqlConnection(cadenaConexion);
            medicamentoRepository = new MedicamentoRepository(Conexion);
        }

        public string Guardar(Medicamento medicamento)
        {

            try
            {
                Conexion.Open();
                medicamentoRepository.Guardar(medicamento);
                return "Medicamento " + medicamento.Nombre +  " registrad@ Exitosamente";
            }
            catch (Exception excep)
            {

                return "Error en la conexion " + excep.Message;
            }
            finally
            {
                Conexion.Close();
            }
        }
        public string Modificar(Medicamento medicamento)
        {
            try
            {
                Conexion.Open();
                medicamentoRepository.Modidicar(medicamento);
                return "Paciente " + medicamento.Nombre + " modificad@ Exitamente";
            }
            catch (Exception excep)
            {

                return "Error en la conexion " + excep.Message;
            }
            finally
            {
                Conexion.Close();
            }
        }
        public List<Medicamento> Buscar(long cod)
        {
            try
            {

                Conexion.Open();
                return medicamentoRepository.BuscarMedicina(cod);


            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Conexion.Close();
            }

        }
        public List<Medicamento> Cosultar()
        {
            try
            {
                Conexion.Open();
                medicamentos = new List<Medicamento>();
                medicamentos = medicamentoRepository.Consultar();
                Conexion.Close();
                return medicamentos;
            }
            catch (Exception)
            {

                return null;

            }
        }

        

        public List<string> CosultarRecetario()
        {
            List<string> lista = new List<string>();
            foreach (var item in this.Cosultar())
            {
                lista.Add(item.Codigo + ";" + item.Nombre);
            }
            return lista;
        }

    }
}
