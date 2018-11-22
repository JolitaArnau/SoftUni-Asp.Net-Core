using AutoMapper;

namespace Eventures.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using System.Collections.Generic;
    using Filters;
    using Microsoft.Extensions.Logging;
    using Eventures.Models;
    using Services.Contracts.Events;
    using ViewModels.Events;

    public class EventsController : Controller
    {
        private readonly IEventsService eventsService;
        private readonly IMapper mapper;
        private readonly ILogger<EventsController> logger;


        public EventsController(IEventsService eventsService, IMapper mapper, ILogger<EventsController> logger)
        {
            this.eventsService = eventsService;
            this.mapper = mapper;
            this.logger = logger;
        }

        [Authorize]
        public IActionResult All()
        {
            var events = this.eventsService.GetAllEvents();

            var eventViewModels = this.mapper.Map<Event[], IEnumerable<EventViewModel>>(events);

            return View(eventViewModels);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return this.View();
        }

        [ServiceFilter(typeof(EventsLogFilter))]
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(CreateEventViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            this.eventsService.CreateEvent(model.Name, model.Place, model.Start, model.End, model.TotalTickets,
                model.PricePerTicket);
            this.logger.LogInformation($"Event created: {model.Name}", model);

            return this.RedirectToAction("All", "Events");
        }
    }
}