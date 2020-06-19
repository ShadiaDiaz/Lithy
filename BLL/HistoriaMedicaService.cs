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
    public  class HistoriaMedicaService
    {
        private readonly ConnectionManager conexion;

        private readonly HistoriaClinicaRepository repositorio;

        List<HistorialMedico> Historials;

        public HistoriaMedicaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new HistoriaClinicaRepository(conexion);
        }

        public IList<Recetario> ConsultarHistoriaClienteRecetario(string id)
        {
                   
            try
            {
                IList<Posologia> posologias = new List<Posologia>();
                IList<Recetario> recetarios = new List<Recetario>();
                conexion.Open();
                posologias = repositorio.BuscarPosologia(id);
                return recetarios = repositorio.BuscarRecetario(id, posologias);
            }
            catch(Exception e)
            {
                return null;
            }
            finally { conexion.Close(); }
        }

        public IList<Diagnostico> ConsultarHistoriaClienteDiagnosticos(string id,IList<Recetario> recetarios)
        {
            conexion.Open();
            return repositorio.BuscarDiagnostico(id, recetarios);
            try
            {

            }
            catch (Exception e)
            {
                return null;
            }
            finally { conexion.Close(); }
        }

    }
}
