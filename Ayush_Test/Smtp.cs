using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace Ayush_Test
{
    public class Smtp
    {
        public void SendEmail(string emailAddress, string messageSubject, string messageBody)
        {
            try
            {
                MailMessage message = new MailMessage();

                message.From = new MailAddress("ayushkumar74884846@gmail.com");
                message.To.Add(emailAddress);

                message.Subject = messageSubject;
                message.Body = messageBody;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

                client.Credentials = new System.Net.NetworkCredential("ayushkumar74884846@gmail.com", "fesfdwrlnmqlqnom");

                client.EnableSsl = true;

                client.Send(message);


                Console.WriteLine($"Email sent to {emailAddress}");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Error sending email to {emailAddress}: {ex.Message}");
                Console.WriteLine();
            }

        }
    }
}
