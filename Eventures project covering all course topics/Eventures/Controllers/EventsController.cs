using System.Security.Claims;
using AutoMapper;
using Eventures.Services.Contracts.Orders;
using Eventures.Web.ViewModels.Orders;

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
        private readonly IOrdersService ordersService;
        private readonly IMapper mapper;
        private readonly ILogger<EventsController> logger;


        public EventsController(IEventsService eventsService, IMapper mapper, ILogger<EventsController> logger, IOrdersService ordersService)
        {
            this.eventsService = eventsService;
            this.ordersService = ordersService;
            this.mapper = mapper;
            this.logger = logger;
        }

        [Authorize]
        public IActionResult All()
        {
            var events = this.eventsService.GetAllEvents();

            var eventViewModels = this.mapper.Map<Event[], IEnumerable<EventViewModel>>(events);

            this.ViewData["Events"] = eventViewModels;
            
            return this.View();
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
        [Authorize]
        [HttpPost]
        public IActionResult OrderTickets(CreateOrderViewModel model)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            this.ordersService.OrderTickets(model.EventId, userId, model.TicketsCount);
            return this.RedirectToAction("Index", "Home");
        }
        
        [Authorize]
        public IActionResult MyEvents()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var orders = this.ordersService.GetMyOrders(userId);
            var ordersViewModel = this.mapper.Map<Order[], IEnumerable<MyOrderViewModel>>(orders);
            return this.View(ordersViewModel);
        }


        
        [Authorize(Roles = "Admin")]
        public IActionResult AllOrders()
        {
            var orders = this.ordersService.GetAllOrders();
            var ordersViewModel = this.mapper.Map<Order[], IEnumerable<AllOrdersViewModel>>(orders);
            return this.View(ordersViewModel);
        }
        
    }
}