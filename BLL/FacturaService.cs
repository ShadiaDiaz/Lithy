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
    public class FacturaService
    {
        SqlConnection Conexion;
        RecetarioRepository recetarioRepository;
        List<Recetario> recetario;

        public FacturaService()
        {
            string cadenaConexion = @"Data Source=LAPTOP-MKRFM1FC\SQLEXPRESS02;Initial Catalog=DB_Lithy;Integrated Security=True";
            Conexion = new SqlConnection(cadenaConexion);
            recetarioRepository = new RecetarioRepository(Conexion);
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
