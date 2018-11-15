namespace Chushka.Web.Controllers.Home
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Services.Contracts;

    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                var viewModel = this.productService.GetAllProducts(this.User.Identity.Name);
                return View(viewModel);
            }

            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
