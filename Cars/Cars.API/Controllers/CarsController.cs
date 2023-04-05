using Cars.API.Data;
using Cars.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cars.API.Controllers
{
    [ApiController]
    [Route("/api/cars")]
    public class CarsController : ControllerBase
    {
        private readonly DataContext _context;

        public CarsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Cars.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var car = await _context.Cars
                .FirstOrDefaultAsync(c => c.Id == id);
            if (car is null)
            {
                return NotFound();
            }

            return Ok(car);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Car car)
        {
            _context.Add(car);
            try
            {
                await _context.SaveChangesAsync();
                return Ok(car);
            }
            catch (DbUpdateException dbUpdateException)
            {
                return BadRequest(dbUpdateException.InnerException!.Message);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(Car car)
        {
            _context.Update(car);
            try
            {
                await _context.SaveChangesAsync();
                return Ok(car);
            }
            catch (DbUpdateException dbUpdateException)
            {
                return BadRequest(dbUpdateException.InnerException!.Message);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var car = await _context.Cars
                .FirstOrDefaultAsync(c => c.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            _context.Remove(car);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

