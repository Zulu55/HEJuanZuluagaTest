using Cars.Shared.Entities;

namespace Cars.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCarsAsync();
        }

        private async Task CheckCarsAsync()
        {
            if (!_context.Cars.Any())
            {
                _context.Cars.Add(new Car { Make = "Audi", Model = "R8", Year = 2018, Doors = 2, Color = "Red", Price = 79995 });
                _context.Cars.Add(new Car { Make = "Tesla", Model = "3", Year = 2018, Doors = 4, Color = "Black", Price = 54995 });
                _context.Cars.Add(new Car { Make = "Porsche", Model = " 911 991", Year = 2020, Doors = 2, Color = "White", Price = 155000 });
                _context.Cars.Add(new Car { Make = "Mercedes-Benz", Model = "GLE 63S", Year = 2021, Doors = 5, Color = "Blue", Price = 83995 });
                _context.Cars.Add(new Car { Make = "BMW", Model = "X6 M", Year = 2020, Doors = 5, Color = "Silver", Price = 62995 });
            }

            await _context.SaveChangesAsync();
        }
    }
}
