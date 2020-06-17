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

    }
}
