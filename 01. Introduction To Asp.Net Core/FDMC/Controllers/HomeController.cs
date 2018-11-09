using FDMC.Models;

namespace FDMC.Controllers
{
    using System.Linq;
    using Data;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private FdmcDbContext context;

        public HomeController(FdmcDbContext db)
        {
            this.context = db;
        }

        public IActionResult Index()
        {
            var cats = this.context.Cats
                .Select(e => new CatViewModel()
                {
                    Id = e.Id,
                    Name = e.Name
                }).ToList();

            return View(cats);
        }
        
    }
}