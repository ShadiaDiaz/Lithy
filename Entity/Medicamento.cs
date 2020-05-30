using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Medicamento
    {
        
        public string Nombre { get; set; }
        public string Presentacion { get; set; }
        public string Cantidad { get; set; }


        public Medicamento()
        {

        }

        public Medicamento( string nombre, string presentacion,string cantidad)
        {
          
            Nombre = nombre;
            Presentacion = presentacion;
            Cantidad = cantidad;
      
        }
    }
}
