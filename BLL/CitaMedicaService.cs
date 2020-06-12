using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data;

namespace BLL
{
   public  class CitaMedicaService
    {
        private readonly ConnectionManager conexion;

        private readonly CitaMedicaRepository repositorio;

        List<CitaMedica> Citas;

        public CitaMedicaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new CitaMedicaRepository(conexion);
        }
        public string Guardar(CitaMedica cita)
        {

            try
            {
                conexion.Open();
                repositorio.Guardar(cita);
                return "Cita registrad@ Exitosamente";
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
        public List<CitaMedica> Consultar()
        {
            try
            {
                conexion.Open();
                Citas = new List<CitaMedica>();
                Citas = repositorio.Consultar();
                conexion.Close();
                return Citas;
            }
            catch (Exception)
            {

                return null;

            }
        }
        public List<CitaMedica> Buscar(string cod)
        {
            try
            {

                conexion.Open();
                return repositorio.BuscarCita(cod);


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
        public string Modificar(CitaMedica citaMedica)
        {
            try
            {
                conexion.Open();
                repositorio.Modidicar(citaMedica);
                return "cita modificad@ Exitamente";
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

    }
}
