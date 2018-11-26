using System;
using System.Data.Common;
using System.Linq;
using Eventures.Data;
using Eventures.Services.Contracts.Events;
using Microsoft.EntityFrameworkCore;

namespace Eventures.Services
{
    using Models;
    using Contracts.Orders;


    public class OrdersService : IOrdersService
    {
        private readonly EventuresDbContext dbContext;
        private readonly IEventsService eventsService;

        public OrdersService(EventuresDbContext dbContext, IEventsService eventsService)
        {
            this.dbContext = dbContext;
            this.eventsService = eventsService;
        }

        public void OrderTickets(string eventId, string userId, int ticketsCount)
        {
            var @event = this.eventsService.GetEventById(eventId);

            var order = new Order()
            {
                OrderedOn = DateTime.UtcNow,
                EventId = @event.Id,
                CustomerId = userId,
                TicketsCount = ticketsCount
            };

            dbContext.Orders.Add(order);
            this.dbContext.SaveChanges();
        }

        public Order[] GetMyOrders(string userId)
        {
            return this.dbContext
                .Orders
                .Where(o => o.CustomerId == userId)
                .Include(o => o.Event)
                .ToArray();
        }

        public Order[] GetAllOrders()
        {
            return this.dbContext
                .Orders
                .Include(o => o.Event)
                .Include(o => o.Customer)
                .ToArray();
        }
    }
}