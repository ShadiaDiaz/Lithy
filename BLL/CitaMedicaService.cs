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
        
    }
}
