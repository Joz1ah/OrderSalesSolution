using Microsoft.EntityFrameworkCore;
using OrderSalesApp.Shared.Data;
using OrderSalesApp.Shared.Entities;

namespace OrderSalesApp.Shared.Services
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _context;

        public OrderService(DataContext context)
        {
            _context = context;
        }

        public async Task<Order> AddOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return order;
        }

        public async Task<bool> DeleteOrder(int id)
        {
            var dbOrder = await _context.Orders.FindAsync(id);
            if (dbOrder != null)
            {
                _context.Remove(dbOrder);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Order> EditOrder(int id, Order order)
        {
            var dbOrder = await _context.Orders.FindAsync(id);
            if (dbOrder != null)
            {
                dbOrder.OrderName = order.OrderName;
                await _context.SaveChangesAsync();  
                return dbOrder;
            }
            throw new Exception("Order not found!");
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task<List<Order>> GetOrders()
        {

         var orders = await _context.Orders.ToListAsync();
         return orders;
        }
    }
}
