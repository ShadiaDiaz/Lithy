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
    public class RecetarioService
    {
        SqlConnection Conexion;
        RecetarioRepository recetarioRepository;
        List<Recetario> recetario;

        public RecetarioService()
        {
            string cadenaConexion = @"Data Source=LAPTOP-MKRFM1FC\SQLEXPRESS02;Initial Catalog=DB_Lithy;Integrated Security=True";
            Conexion = new SqlConnection(cadenaConexion);
            recetarioRepository = new RecetarioRepository(Conexion);
        }

        public string Guardar(Recetario recetario, string idPaciente)
        {
            try
            {
                Conexion.Open();
                recetarioRepository.Guardar(recetario,idPaciente);
                return "Recetario #" + recetario.Codigo + "Para el paciente " + idPaciente + " registrad@ Exitamente";
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


        public List<Recetario> Buscar(long id)
        {
            try
            {

                Conexion.Open();
                return recetarioRepository.BuscarPaciente(id);


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

        public List<Recetario> Consultar()
        {
            try
            {
                Conexion.Open();
                recetario = new List<Recetario>();
                recetario = recetarioRepository.Consultar();
                Conexion.Close();
                return recetario;
            }
            catch (Exception)
            {

                return null;

            }
        }

        public string NuevoCodigo(long id)
        {

            Conexion.Open();

            string nuevo = recetarioRepository.NuevoCodigo(id);

            Conexion.Close();
            return nuevo;

        }
    }
}
