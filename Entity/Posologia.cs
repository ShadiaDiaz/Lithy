﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Posologia
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int CantidadDias { get; set; }
        public int IntervaloHoras { get; set; }
        public string Cantidad { get; set; }
        public Medicamento Medicamento { get; set; }

        public Posologia()
        {

        }

        public Posologia(string codigo,int cantidadDias, int intervaloHoras, string cantidad, Medicamento medicamento)
        {
            Codigo = codigo;
            CantidadDias = cantidadDias;
            IntervaloHoras = intervaloHoras;
            Cantidad = cantidad;
            Medicamento = medicamento;
        }
    }
}
