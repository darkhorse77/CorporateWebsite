using Microsoft.AspNetCore.Identity;

namespace CorporateWebsite.Models
{
    public class User : IdentityUser
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
    }
}
