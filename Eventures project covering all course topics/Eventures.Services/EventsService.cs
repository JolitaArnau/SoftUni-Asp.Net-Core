namespace Eventures.Services
{
    using System;
    using System.Linq;
    using Data;
    using Models;
    using Contracts.Events;

    public class EventsService : IEventsService
    {
        private readonly EventuresDbContext dbContext;
        

        public EventsService(EventuresDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public void CreateEvent(string name, string place, DateTime start, DateTime end, int totalTickets,
            decimal pricePerTicket)
        {
            var @event = new Event()
            {
                Name = name,
                Place = place,
                Start = start,
                End = end,
                TotalTickets = totalTickets,
                PricePerTicket = pricePerTicket
            };

            this.dbContext.Events.Add(@event);
            this.dbContext.SaveChanges();
        }

        public Event[] GetAllEvents()
        {
            return this.dbContext.Events.ToArray();
        }

        public Event GetEventById(string id)
        {
            var @event = this.dbContext.Events.Find(id);

            return @event;
        }
    }
}