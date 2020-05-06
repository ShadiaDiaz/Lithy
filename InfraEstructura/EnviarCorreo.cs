using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using Entity;


namespace InfraEstructura
{
    public class EnviarCorreo
    {
        string con = "NIALLhoran43";
     
        public MailMessage CrearEmail (Paciente paciente)
        {

            MailMessage email = new MailMessage();
            Attachment attachment = new Attachment("ListaPacientes.pdf");
            email.To.Add(paciente.Correo);
            email.From = new MailAddress("scarleth0413@gmail.com");
            email.Subject = "Registro de Pacientes " + DateTime.Now.ToString("dd / MMM / yy hh:mm:ss");
            email.Body = $"<b>Sr(a) {paciente.Nombres} {paciente.Apellidos} </b> se ha realizado su registro";
            
            email.Attachments.Add(attachment);
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            return email;
        }
        public SmtpClient ConfigurarSMTP()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("scarleth0413@gmail.com",con);

            return smtp;

        }

        public string EnviarEmail(Paciente paciente)
        {
            string resultado = string.Empty;
            try
            {
                SmtpClient smtp = ConfigurarSMTP();
                MailMessage email = CrearEmail(paciente);
                smtp.Send(email);
                email.Dispose();
                resultado = "Correo electronico fue enviado satisfactoriamente";
            }
            catch(Exception e){

                resultado = "Error enviando Correo" + e;

            }
            Console.WriteLine(resultado);
            return resultado;
        }



    }
}
