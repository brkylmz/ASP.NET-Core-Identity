using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ASP.NET_Core_Identity.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            SmtpClient sc = new SmtpClient
            {
                Port = 587,
                Host = "smtp.gmail.com",
                EnableSsl = true,
                Credentials = new NetworkCredential("abc@gmail.com", "Şifre")
            };

            MailMessage mail = new MailMessage
            {
                From = new MailAddress("abc@gmail.com", "Ekranda Görünecek İsim")
            };

            mail.To.Add(email);

            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = message;

            sc.Send(mail);

            return Task.CompletedTask;
        }
    }
}
