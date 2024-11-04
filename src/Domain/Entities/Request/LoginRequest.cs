

namespace Domain.Entities.Request
{
    public class LoginRequest
    {
        public LoginRequest(string userName, string password, string companyDB)
        {
            UserName = userName;
            Password = password;
            CompanyDB = companyDB;
        }

        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;       
        public string CompanyDB { get; set; } = string.Empty;      
    }
}