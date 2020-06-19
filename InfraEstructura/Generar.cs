using System;
using System.Collections.Generic;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Entity;
using NPOI.Util;

namespace InfraEstructura
{
   public  class Generar
    {






        public void FillPDF(string templateFile, List<Posologia> posologia, Persona persona,string cod)
        {
            Stream file = new FileStream(@"C:\Users\xshad\Downloads\Lithy2\Lithy\PDFRecetario" + cod+".pdf", FileMode.Create);
            PdfReader reader = new PdfReader(templateFile);
            PdfStamper stamp = new PdfStamper(reader, file);
            stamp.AcroFields.SetField("Identificaciòn", "" + persona.Identificacion);
            stamp.AcroFields.SetField("Nombres", "" + persona.Nombres);
            stamp.AcroFields.SetField("RX", "" + LlenarTabla(posologia).ToString());

            stamp.FormFlattening = false;
            stamp.Close();
            reader.Close();
            file.Close();
            
        }

       
        private PdfPTable LlenarTabla(List<Posologia> posologia)
        {
            PdfPTable tabla = new PdfPTable(4);
            tabla.AddCell(new Paragraph("Nombre"));
            tabla.AddCell(new Paragraph("Dias"));
            tabla.AddCell(new Paragraph("Horas"));
            tabla.AddCell(new Paragraph("Cantidad"));
            foreach (var item in posologia)
            {

                tabla.AddCell($"{item.Medicamento}");
                tabla.AddCell($"{ item.CantidadDias}");
                tabla.AddCell($"{item.IntervaloHoras}");
                tabla.AddCell(item.Cantidad);
            }

            return tabla;

        }


    public class Respuesta
        {
            public IList<Persona> ListaPacientes { get; set; }
            public string Mensaje { get; set; }
            public bool IsError { get; set; }
        }

    }
}
