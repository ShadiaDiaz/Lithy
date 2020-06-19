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
    public class PosologiaService
    {
        private readonly ConnectionManager conexion;

        private readonly PosologiaRepository repositorio;
  

        public PosologiaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new PosologiaRepository(conexion);
        }

        public string Guardar(Posologia posologia)
        {

            try
            {
                conexion.Open();
                repositorio.Guardar(posologia);
                return "se han registrad@ Exitosamente";
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
