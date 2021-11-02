using System.Threading.Tasks;

namespace ASP.NET_Core_Identity.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
