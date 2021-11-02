using System;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Core_Identity.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
