using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Medicamento
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Presentacion { get; set; }
        public decimal Precio { get; set; }

        public Medicamento()
        {

        }

        public Medicamento(string codigo, string nombre, string presentacion, decimal precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Presentacion = presentacion;
            Precio = precio;
        }
    }
}
