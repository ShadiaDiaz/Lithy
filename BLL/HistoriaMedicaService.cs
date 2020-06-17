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

        public HistoriaCliente ConsultarHistoriaCliente(string id,HistoriaCliente historia)
        {
            try
            {
                conexion.Open();
                repositorio.BuscarHistoria(id, historia);
                repositorio.BuscarDiagnostico(id, historia);
                return historia;
            }
            catch(Exception e)
            {
                return null;
            }
            finally { conexion.Close(); }
        }

    }
}
