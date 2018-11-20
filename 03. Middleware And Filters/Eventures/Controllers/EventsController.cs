using Microsoft.AspNetCore.Authorization;

namespace Eventures.Web.Controllers
{
    using ViewModels.Events;
    using Microsoft.AspNetCore.Mvc;
    
    public class EventsController : Controller
    {
        [Authorize]
        public IActionResult All(EventViewModel model)
        {
            return View();
        }
        
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(EventViewModel model)
        {
            return View();
        }
    }
}