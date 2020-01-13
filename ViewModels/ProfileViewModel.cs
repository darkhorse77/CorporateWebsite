using System.Collections.Generic;

namespace CorporateWebsite.ViewModels
{
    public class ProfileViewModel
    {
        public List<string> Roles { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string PhotoUrl { get; set; }
    }
}
