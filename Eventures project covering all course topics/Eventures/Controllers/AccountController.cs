namespace Eventures.Web.Controllers
{
    using ViewModels.Account;
    using Microsoft.AspNetCore.Mvc;
    using Services.Contracts.Account;


    public class AccountController : Controller
    {
        private readonly IAccountService accountService;


        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var isRegistered = this.accountService.Register(model.Username, model.Password, model.ConfirmPassword,
                model.Email,
                model.FirstName, model.LastName, model.UniqueCitizenNumber).GetAwaiter().GetResult();

            if (!isRegistered)
            {
                return this.View();
            }


            return this.RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var isLogin = this.accountService.Login(model.Username, model.Password, model.RememberMe);

            if (!isLogin)
            {
                return this.View();
            }

            return this.RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            this.accountService.Logout();
            return this.RedirectToAction("Index", "Home");
        }
    }
}