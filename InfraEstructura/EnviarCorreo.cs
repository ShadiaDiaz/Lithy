﻿using System;
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
 

        
            private MailMessage email;
            private SmtpClient smtp;
            public EnviarCorreo()
            {
                smtp = new SmtpClient();

            }


            private void ConfigurarEmail( Persona persona)
            {

               Attachment pdf = new Attachment(@"C: \Users\xshad\Downloads\Lithy2\Lithy\PDF");
                email = new MailMessage();
                email.To.Add(persona.Correo);
                email.From = new MailAddress("scarleth0413@gmail.com");
                email.Subject = "Enviar Correo " + DateTime.Now.ToString("dd / MMM / yy hh:mm:ss");
                email.Body = $"<b> Recetario";
                email.IsBodyHtml = true;
                email.Attachments.Add(pdf);
                email.Priority = MailPriority.Normal;


            }
            private void ConfigurarSMTP()
            {
              
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("scarleth0413@gmail.com", "NIALLhoran43");

           

            }

            public string EnviarEmail(Persona persona)
            {
                string resultado = string.Empty;
                try
                {
                    ConfigurarSMTP();
                    ConfigurarEmail(persona);
                    smtp.Send(email);
                    email.Dispose();
                    resultado = "Correo electronico fue enviado satisfactoriamente";
                }
                catch (Exception e)
                {

                    resultado = "Error enviando Correo" + e;

                }
                Console.WriteLine(resultado);
                return resultado;
            }

           private void ConfiEmail(string ruta,string correo,string subject, string body)
           {

            Attachment pdf = new Attachment(ruta);
            email = new MailMessage();
            email.To.Add(correo);
            email.From = new MailAddress("scarleth0413@gmail.com");
            email.Subject = subject + DateTime.Now.ToString("dd / MMM / yy hh:mm:ss");
            email.Body = $"<b> Recetario "+ body +"</b>";
            email.IsBodyHtml = true;
            email.Attachments.Add(pdf);
            email.Priority = MailPriority.Normal;


           }

        public string SendEmail(string ruta, string correo, string subject, string body)
        {
            string resultado = string.Empty;
            try
            {
                ConfigurarSMTP();
                ConfiEmail(ruta,correo,subject,body);
                smtp.Send(email);
                email.Dispose();
                resultado = "Correo electronico fue enviado satisfactoriamente";
            }
            catch (Exception e)
            {

                resultado = "Error enviando Correo" + e;

            }
            Console.WriteLine(resultado);
            return resultado;
        }

    }
    }

