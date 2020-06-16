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
        private readonly ConnectionManager conexion;

        private readonly RecetarioRepository repositorio;
        List<Recetario> recetario;

        public RecetarioService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new RecetarioRepository(conexion);
        }

        public string Guardar(Recetario recetario, string idPaciente)
        {
            try
            {
                conexion.Open();
                repositorio.Guardar(recetario,idPaciente);
                return "Recetario #" + recetario.Codigo + "Para el paciente " + idPaciente + " registrad@ Exitamente";
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


        public List<Recetario> Buscar(string id)
        {
            try
            {

                conexion.Open();
                return repositorio.BuscarPaciente(id);


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

        

        public List<Recetario> Consultar()
        {
            try
            {
                conexion.Open();
                recetario = new List<Recetario>();
                recetario = repositorio.Consultar();
                conexion.Close();
                return recetario;
            }
            catch (Exception)
            {

                return null;

            }
        }

        public string NuevoCodigo(string id)
        {

            conexion.Open();

            string nuevo = repositorio.NuevoCodigo(id);

            conexion.Close();
            return nuevo;

        }
    }
}
