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
        SqlConnection Conexion;
        PosologiaRepository posologiaRepository;
        List<Paciente> pacientes;

        public PosologiaService()
        {
            string cadenaConexion = @"Data Source=LAPTOP-MKRFM1FC\SQLEXPRESS02;Initial Catalog=DB_Lithy;Integrated Security=True";
            Conexion = new SqlConnection(cadenaConexion);
            posologiaRepository = new PosologiaRepository(Conexion);
        }

        public string Guardar(Posologia posologia, string id)
        {

            try
            {
                Conexion.Open();
                posologiaRepository.Guardar(posologia,id);
                return "Posologia #" + posologia.Codigo + "Para el paciente " + posologia + " registrad@ Exitamente";
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
    }
}
