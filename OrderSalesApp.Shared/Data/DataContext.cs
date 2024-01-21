using Microsoft.EntityFrameworkCore;
using OrderSalesApp.Shared.Entities;


namespace OrderSalesApp.Shared.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) 
        {
            
        }

        public DbSet<Order> Orders { get; set; }
    }
}
