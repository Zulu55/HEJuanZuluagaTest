using Cars.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cars.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        public DbSet<Car> Cars { get; set; }
        
        public DbSet<Customer> Customers { get; set; }
        
        public DbSet<Order> Orders { get; set; }
        
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
