namespace Chushka.Web.Services.Contracts
{
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.EntityFrameworkCore;
    using Chushka.Models;
    using Chushka.Data;

    public class OrderService : PageModel, IOrderService
    {
        private readonly ChushkaDbContext dbContext;

        public OrderService(ChushkaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Order[] GetAllOrders()
        {
            var orders =
                this.dbContext
                .Orders
                .Include(o => o.Client)
                .Include(o => o.Product)
                .ToArray();

            return orders;
        }

        public IActionResult OrderProduct(Product product, ChushkaUser user)
        {
            var order = new Order()
            {
                Product = product,
                ProductId = product.Id,
                Client = user,
                ClientId = user.Id,
                OrderedOn = DateTime.UtcNow
            };

            this.dbContext.Orders.Add(order);
            this.dbContext.SaveChanges();

            return this.Redirect("/");
        }
    }
}