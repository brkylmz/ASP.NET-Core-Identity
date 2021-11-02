using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Identity.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}