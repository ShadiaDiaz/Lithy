using System;
using System.Collections.Generic;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Entity;
using DAL;

namespace InfraEstructura
{
   public  class Generar
    {




       

        public void FillPDF(string templateFile, List<Posologia>posologia, Paciente paciente)
        {
            Stream file = new FileStream(@"RecetarioCrear.pdf", FileMode.Create);
            PdfReader reader = new PdfReader(templateFile);
         PdfStamper stamp = new PdfStamper(reader, file);
         stamp.AcroFields.SetField("Identificaciòn", ""+paciente.Identificacion);
         stamp.AcroFields.SetField("Nombres", ""+paciente.Nombres);
         stamp.AcroFields.SetField("RX", ""+LlenarTabla(posologia).ToString());
         
         stamp.FormFlattening = false;
         stamp.Close(); 
        }
      
        //public void GuardarPdf(List<Paciente> paciente, string ruta)
        //    {
        //        FileStream fs = new FileStream(@ruta, FileMode.Create);
        //        Document document = new Document(iTextSharp.text.PageSize.LEGAL);
        //        PdfWriter pw = PdfWriter.GetInstance(document, fs);

        //        document.AddTitle("Diagnostico");
        //        document.AddCreator("Lithy");

        //        document.Open();

        //        document.Add(new Paragraph("Lista de Pacientes"));
        //        document.Add(LlenarTabla(paciente));

        //        document.Close();


        //    }
        private PdfPTable LlenarTabla(List<Posologia> posologia)
        {
            PdfPTable tabla = new PdfPTable(7);
            tabla.AddCell(new Paragraph("Codigo"));
            tabla.AddCell(new Paragraph("Nombre"));
            tabla.AddCell(new Paragraph("Dias"));
            tabla.AddCell(new Paragraph("Horas"));
            tabla.AddCell(new Paragraph("Cantidad"));
          

            foreach(var item in posologia){
                tabla.AddCell(item.Codigo);
                tabla.AddCell(item.Nombre);
                tabla.AddCell($"{ item.CantidadDias}");
                tabla.AddCell($"{item.IntervaloHoras}");
                tabla.AddCell(item.Cantidad);
            }

            return tabla;

        }

        public class Respuesta
        {
            public IList<Paciente> ListaPacientes { get; set; }
            public string Mensaje { get; set; }
            public bool IsError { get; set; }
        }

    }
}
