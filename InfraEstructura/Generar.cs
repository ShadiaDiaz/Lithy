using System;
using System.Collections.Generic;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Entity;


namespace InfraEstructura
{
   public  class Generar
    {






        public void FillPDF(string templateFile, List<Posologia> posologia, Persona persona)
        {
            Stream file = new FileStream(@"RecetarioCrear.pdf", FileMode.Create);
            PdfReader reader = new PdfReader(templateFile);
            PdfStamper stamp = new PdfStamper(reader, file);
            stamp.AcroFields.SetField("Identificaciòn", "" + persona.Identificacion);
            stamp.AcroFields.SetField("Nombres", "" + persona.Nombres);
            stamp.AcroFields.SetField("RX", "" + LlenarTabla(posologia).ToString());

            stamp.FormFlattening = false;
            stamp.Close();
        }

        //public void GuardarPdf(List<Persona> persona, string path)
        //{
        //    FileStream fs = new FileStream(path, FileMode.Create);
        //    Document document = new Document(iTextSharp.text.PageSize.LEGAL);
        //    PdfWriter pw = PdfWriter.GetInstance(document, fs);

        //    document.AddTitle("Personas Registradas");
        //    document.AddCreator("Lithy");

        //    document.Open();

        //    document.Add(new Paragraph("Lista de Pacientes"));
        //    document.Add(LlenarTabla(persona));

        //    document.Close();


        //}
        //private PdfPTable LlenarTabla(List<Persona> persona)
        //{
        //    PdfPTable tabla = new PdfPTable(7);
        //    tabla.AddCell(new Paragraph("Identificación"));
        //    tabla.AddCell(new Paragraph("Nombre"));
        //    tabla.AddCell(new Paragraph("Apellido"));
        //    tabla.AddCell(new Paragraph("Sexo"));
        //    tabla.AddCell(new Paragraph("Edad"));
        //    tabla.AddCell(new Paragraph("Dirección"));
        //    tabla.AddCell(new Paragraph("Telefono"));
        //    tabla.AddCell(new Paragraph("Correo"));


        //    foreach (var item in persona){
        //        tabla.AddCell(item.Identificacion);
        //        tabla.AddCell(item.Nombres);
        //        tabla.AddCell(item.Apellidos);
        //        tabla.AddCell(item.Sexo);
        //        tabla.AddCell($"{item.Edad}");
        //        tabla.AddCell(item.Direccion);
        //        tabla.AddCell(item.Celular);
        //        tabla.AddCell($"{item.Correo}");
        //    }

        //    return tabla;

        //}
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
