namespace CorporateWebsite.ViewModels
{
    public abstract class BaseUserModel
    {
        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
    }

    public class CreateUserViewModel : BaseUserModel
    {     
        public string Password { get; set; }       
    }

    public class EditUserViewModel : BaseUserModel
    {
        public string Id { get; set; }
    }
}
