namespace FDMC.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Data;
    using Models;
    
    public class CatsController : Controller
    {
        private FdmcDbContext context;

        public CatsController(FdmcDbContext db)
        {
            this.context = db;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CatAddBindingModel model)
        {
            if (this.ModelState.IsValid)
            {
                var cat = new Cat()
                {
                    Name = model.Name,
                    Breed = model.Breed,
                    ImageUrl = model.ImageUrl
                };

                this.context.Cats.Add(cat);
                context.SaveChanges();

                return RedirectToAction("Details", "Cats", new {id = cat.Id});
            }

            return this.View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var cat = context.Cats.Find(id);

            if (cat != null)
            {
                var model = new CatDetailsViewModel()
                {
                    Name = cat.Name,
                    Breed = cat.Breed,
                    ImageUrl = cat.ImageUrl
                };

                return this.View(model);
            }

            return NotFound();
        }
  
    }
}