using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
namespace TransporteRodriguez
{
    public  class EnviarMail
    {
        private string estamos;
        private const string Usuario= "transportereclamos123@gmail.com";
        private const string Pass = "kwptzmlwrfyndosa";
        public string Estamos { get => estamos; set => estamos = value; }

        public EnviarMail() { }
        //EQUIS ES EL MANEJADOR DEL EVENTO - POR ESO TIENE LA MISMA FIRMA
        public void  equis(object sender, EventArgs e)
        {
            estamos = "äaa";
        }
        public void Enviarcorreo(Usuario cliente)
        {
            
                StringBuilder cadena = new StringBuilder();

                cadena.AppendLine("**** ALERTA ****");
                cadena.AppendLine($"Fecha recepcion {DateTime.Now.ToString()}");
                cadena.AppendLine($"Cliente: {cliente.Nombre}");
                cadena.AppendLine("No pudo reservar un viaje.");
                cadena.AppendLine($"Comunicarse a su correo {cliente.Mail} para ofrecer opciones\n" +
                     $"y que pueda concretar su viaje.");

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("transportereclamos123@gmail.com");
                mail.To.Add("julian_rodriguez99@hotmail.com");
                mail.Subject = "RECLAMOS AUTOMATICO";
                mail.Body = cadena.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(Usuario, Pass);
                smtp.EnableSsl = true;
                smtp.Send(mail);
        }
    }

}
