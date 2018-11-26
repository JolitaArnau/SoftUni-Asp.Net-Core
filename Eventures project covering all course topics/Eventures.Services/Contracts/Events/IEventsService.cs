using System;
using Eventures.Models;

namespace Eventures.Services.Contracts.Events
{
    public interface IEventsService
    {
        void CreateEvent(string name, string place, DateTime start, DateTime end, int totalTickets,
            decimal pricePerTicket);

        Event[] GetAllEvents();

        Event GetEventById(string id);
    }
}