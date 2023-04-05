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
    }
}
