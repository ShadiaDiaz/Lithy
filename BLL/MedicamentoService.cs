using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;



namespace BLL
{
    public class MedicamentoService
    {
        private readonly ConnectionManager conexion;

        private readonly MedicamentoRepository repositorio;
       
        List<Medicamento> medicamentos;

        public MedicamentoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new MedicamentoRepository(conexion);
        }

        public string Guardar(Medicamento medicamento)
        {
           
            conexion.Open();
            repositorio.Guardar(medicamento);
            conexion.Close();
            return "Medicamento " + medicamento.Nombre + " registrad@ Exitosamente";

            try
            {
            }
            catch (Exception excep)
            {

                return "Error en la conexion " + excep.Message;
            }
            finally
            {
                
            }
        }
        public string Modificar(Medicamento medicamento)
        {
            try
            {
                conexion.Open();
                repositorio.Modidicar(medicamento);
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
        public Medicamento Buscar(string nom)
        {
            
            try
            {
                Medicamento medicamento;
                conexion.Open();
                medicamento = repositorio.BuscarMedicina(nom);
               
                return medicamento;




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
        public List<Medicamento> Consultar()
        {
            try
            {
                conexion.Open();
                medicamentos = new List<Medicamento>();
                medicamentos = repositorio.Consultar();
                conexion.Close();
                return medicamentos;
            }
            catch (Exception)
            {

                return null;

            }
        }
        public List<string> ConsultarEnRecetario()
        {
            try
            {
                conexion.Open();

                return repositorio.ConsultarRecetario();

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

        

      

    }
}
