using AutoMapper;

namespace Eventures.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using ViewModels.Account;
    using Services.Contracts.Account;
    using Eventures.Models;


    public class AccountController : Controller
    {
        private readonly IAccountService accountService;
        private readonly SignInManager<EventuresUser> signInManager;
        private readonly UserManager<EventuresUser> userManager;
        private readonly IMapper mapper;


        public AccountController(IAccountService accountService, SignInManager<EventuresUser> signInManager,
            UserManager<EventuresUser> userManager, IMapper mapper
        )
        {
            this.accountService = accountService;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.mapper = mapper;
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

        [HttpGet]
        public IActionResult Lockout()
        {
            return this.View();
        }

        public IActionResult ExternalLogin(string provider)
        {
            var returnUrl = "/";
            var redirectUrl = Url.Action(nameof(this.ExternalLoginCallback), "Account", new {returnUrl});
            var properties = this.signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return this.Challenge(properties, provider);
        }

        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
            if (remoteError != null)
            {
                return this.RedirectToAction(nameof(Login));
            }

            var info = await this.signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return this.RedirectToAction(nameof(Login));
            }

            var result = await this.signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey,
                isPersistent: false, bypassTwoFactor: true);
            if (result.Succeeded)
            {
                return this.RedirectToLocal(returnUrl);
            }

            if (result.IsLockedOut)
            {
                return this.RedirectToAction(nameof(Lockout));
            }
            else
            {
                this.ViewData["ReturnUrl"] = returnUrl;
                this.ViewData["LoginProvider"] = info.LoginProvider;
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
                return this.View("ExternalLogin", new ExternalLoginConfirmationViewModel {Email = email});
            }
        }

        [HttpPost]
        public async Task<IActionResult> ExternalLoginConfirmation(ExternalLoginConfirmationViewModel model,
            string returnUrl = null)
        {
            if (this.ModelState.IsValid)
            {
                var info = await this.signInManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    throw new ApplicationException("Error loading external login information during confirmation.");
                }

                var user = new EventuresUser {UserName = model.Email, Email = model.Email};
                var result = await this.userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    if (this.userManager.Users.Count() == 1)
                    {
                        await this.userManager.AddToRoleAsync(user, "Admin");
                    }
                    else
                    {
                        await this.userManager.AddToRoleAsync(user, "User");
                    }

                    result = await this.userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        await this.signInManager.SignInAsync(user, isPersistent: false);
                        return this.RedirectToLocal(returnUrl);
                    }
                }

                this.AddErrors(result);
            }

            ViewData["ReturnUrl"] = returnUrl;
            return this.View(nameof(ExternalLogin), model);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                this.ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (this.Url.IsLocalUrl(returnUrl))
            {
                return this.Redirect(returnUrl);
            }
            else
            {
                return this.RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }


        public IActionResult Logout()
        {
            this.accountService.Logout();
            return this.RedirectToAction("Index", "Home");
        }
    }
}