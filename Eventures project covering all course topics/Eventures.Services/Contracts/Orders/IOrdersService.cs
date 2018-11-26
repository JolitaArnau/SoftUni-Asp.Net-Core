namespace Eventures.Services.Contracts.Orders
{
    using Models;
    
    public interface IOrdersService
    {
        void OrderTickets(string eventId, string userId, int ticketsCount);

        Order[] GetMyOrders(string userId);

        Order[] GetAllOrders();
    }
}