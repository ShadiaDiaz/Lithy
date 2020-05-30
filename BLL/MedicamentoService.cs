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
        private readonly ConnectionManager conexion;

        private readonly MedicamentoRepository repositorio;
        MedicamentoRepository medicamentoRepository;
        List<Medicamento> medicamentos;

        public MedicamentoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new MedicamentoRepository(conexion);
        }

        public string Guardar(Medicamento medicamento)
        {

            try
            {
                conexion.Open();
                medicamentoRepository.Guardar(medicamento);
                return "Medicamento " + medicamento.Nombre +  " registrad@ Exitosamente";
            }
            catch (Exception excep)
            {

                return "Error en la conexion " + excep.Message;
            }
            finally
            {
                conexion.Close();
            }
        }
        public string Modificar(Medicamento medicamento)
        {
            try
            {
                conexion.Open();
                medicamentoRepository.Modidicar(medicamento);
                return "Paciente " + medicamento.Nombre + " modificad@ Exitamente";
            }
            catch (Exception excep)
            {

                return "Error en la conexion " + excep.Message;
            }
            finally
            {
                conexion.Close();
            }
        }
        public List<Medicamento> Buscar(long cod)
        {
            try
            {

                conexion.Open();
                return medicamentoRepository.BuscarMedicina(cod);


            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }

        }
        public List<Medicamento> Cosultar()
        {
            try
            {
                conexion.Open();
                medicamentos = new List<Medicamento>();
                medicamentos = medicamentoRepository.Consultar();
                conexion.Close();
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
