using OrderSalesApp.Shared.Entities;

namespace OrderSalesApp.Shared.Services
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrders();
        Task<Order> GetOrderById(int id);
        Task<Order> AddOrder(Order order);
        Task<Order> EditOrder(int id, Order order);
        Task<bool> DeleteOrder(int id);
    }
}
