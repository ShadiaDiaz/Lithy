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
            ByteArrayOutputStream streamDoc = new ByteArrayOutputStream();
            PdfReader frente = new PdfReader(streamDoc.ToByteArray());
            PdfStamper stamperDoc = new PdfStamper(frente,file);
            PdfReader reader = new PdfReader(templateFile);
            ByteArrayOutputStream streamFondo = new ByteArrayOutputStream();
            PdfStamper stamperFondo = new PdfStamper(reader, streamFondo);

            stamperFondo.AcroFields.Fields("Identificaciòn", "" + persona.Identificacion);
            stamperFondo.AcroFields.GetField("Nombres", "" + persona.Nombres);
            stamperFondo.AcroFields.Fields("RX", "" + LlenarTabla(posologia).ToString());

            stamperFondo.FormFlattening = false;
            stamperFondo.Close();
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
