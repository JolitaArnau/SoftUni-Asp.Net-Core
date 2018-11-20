namespace Eventures.Models
{
    using System;

    public class Event
    {
        public Event()
        {
            this.Id = new Guid().ToString();
        }
        
        public string Id { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int TotalTickets { get; set; }

        public decimal PricePerTicket { get; set; }
    }
}