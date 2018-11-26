namespace Eventures.Web.ViewModels.Orders
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CreateOrderViewModel
    {
        public string EventId { get; set; }

        public string CustomerName { get; set; }

        [Required]
        [Range(1, Int32.MaxValue)]
        [Display(Name = "Tickets")]
        public int TicketsCount { get; set; }
    }
}