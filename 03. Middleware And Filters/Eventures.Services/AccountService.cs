namespace Eventures.Services
{
    using System.Linq;
    using System.Threading.Tasks;
    using Models;
    using Contracts.Account;
    using Microsoft.AspNetCore.Identity;

    public class AccountService : IAccountService
    {
        private readonly SignInManager<EventuresUser> _signInManager;
        private readonly UserManager<EventuresUser> _userManager;

        public AccountService(SignInManager<EventuresUser> signInManager, UserManager<EventuresUser> userManager)
        {
            this._signInManager = signInManager;
            this._userManager = userManager;
        }

        public async Task<bool> Register(string username, string password, string confirmPassword, string email,
            string firstName, string lastName, string uniqueCitizenNumber)
        {
            if (password != confirmPassword)
            {
                return false;
            }

            var user = new EventuresUser()
            {
                UserName = username,
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                UniqueCitizenNumber = uniqueCitizenNumber
            };

            var result = this._userManager.CreateAsync(user, password).Result;

            if (result.Succeeded)
            {
                if (this._userManager.Users.Count() == 1)
                {
                    await this._userManager.AddToRoleAsync(user, "Admin");
                }
                else
                {
                    await this._userManager.AddToRoleAsync(user, "User");
                }

                this._signInManager.SignInAsync(user, false).Wait();
            }

            return result.Succeeded;
        }

        public bool Login(string username, string password, bool rememberMe)
        {
            var result = this._signInManager.PasswordSignInAsync(username, password, rememberMe, true).Result;

            return result.Succeeded;
        }

        public void Logout()
        {
            this._signInManager.SignOutAsync().Wait();
        }
    }
}