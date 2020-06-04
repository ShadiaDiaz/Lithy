using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Posologia
    {

        public Medicamento Medicamento { get; set; }
        public int CantidadDias { get; set; }
        public int IntervaloHoras { get; set; }
        public string Cantidad { get; set; }
       

        public Posologia()
        {

        }

        public Posologia(Medicamento medicamento,int cantidadDias, int intervaloHoras, string cantidad)
        {
            Medicamento = medicamento;
            CantidadDias = cantidadDias;
            IntervaloHoras = intervaloHoras;
            Cantidad = cantidad;
          
        }
    }
}
