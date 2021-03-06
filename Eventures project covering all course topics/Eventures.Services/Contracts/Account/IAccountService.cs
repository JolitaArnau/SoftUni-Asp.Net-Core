using System.Threading.Tasks;

namespace Eventures.Services.Contracts.Account
{
    public interface IAccountService
    {
        Task<bool> Register(string username, string password, string confirmPassword, string email, string firstName, string lastName, string uniqueCitizenNumber);

        bool Login(string username, string password, bool rememberMe);

        void Logout();
    }
}