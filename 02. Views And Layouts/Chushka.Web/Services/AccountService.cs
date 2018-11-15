namespace Chushka.Web.Services
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;
    using System.Linq;
    using System.Threading.Tasks;
    using Chushka.Models;
    using Contracts;
    using ViewModels.Account;
    using Chushka.Data;

    public class AccountService : PageModel, IAccountService
    {
        private readonly ChushkaDbContext dbContext;
        private readonly UserManager<ChushkaUser> userManager;
        private readonly IEmailSender emailSender;
        private readonly SignInManager<ChushkaUser> signInManager;
        private readonly ILogger<RegisterUserViewModel> logger;

        public AccountService(ChushkaDbContext dbContext, UserManager<ChushkaUser> userManager,
            IEmailSender emailSender, ILogger<RegisterUserViewModel> _logger, SignInManager<ChushkaUser> signInManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
            this.emailSender = emailSender;
            this.signInManager = signInManager;
            this.logger = _logger;
        }

        public IActionResult Login(LoginUserViewModel model)
        {
            return OnLoginPostAsync(model).Result;
        }

        public IActionResult Register(RegisterUserViewModel user)
        {
            return OnRegisterPostAsync(user).Result;
        }

        public IActionResult Logout()
        {
            return this.OnLogoutGetAsync().Result;
        }

        private async Task<IActionResult> OnRegisterPostAsync(RegisterUserViewModel model)
        {
            if (!ModelState.IsValid) return Page();
            var user = new ChushkaUser {UserName = model.Username, FullName = model.FullName, Email = model.Email};
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                if (this.dbContext.Users.Count() == 1)
                {
                    await this.userManager.AddToRoleAsync(user, "Admin");
                }
                else
                {
                    await this.userManager.AddToRoleAsync(user, "User");
                }

                logger.LogInformation("User created a new account with password.");

                var code = await userManager.GenerateEmailConfirmationTokenAsync(user);

                await signInManager.SignInAsync(user, isPersistent: false);
                return this.Redirect("/");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private async Task<IActionResult> OnLoginPostAsync(LoginUserViewModel model)
        {
            if (!ModelState.IsValid) return this.Page();
            var user = this.dbContext.Users.FirstOrDefault(x => x.UserName == model.Username);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return this.Page();
            }

            var result = await signInManager.PasswordSignInAsync(user, model.Password, false, lockoutOnFailure: true);
            if (result.Succeeded)
            {
                logger.LogInformation("User logged in.");
                return this.Redirect("/");
            }

            if (result.IsLockedOut)
            {
                logger.LogWarning("User account locked out.");
                return RedirectToPage("./Lockout");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return this.Page();
            }

            // If we got this far, something failed, redisplay form
        }

        private async Task<IActionResult> OnLogoutGetAsync()
        {
            await signInManager.SignOutAsync();

            return this.Redirect("/");
        }

        public ChushkaUser GetUser(string username)
        {
            var user = this.dbContext.Users.FirstOrDefault(x => x.UserName == username);
            return user;
        }
    }
}