using System.ComponentModel.DataAnnotations;

namespace Cars.Shared.Entities
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Make { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Model { get; set; } = null!;

        public int Year { get; set; }

        public int Doors { get; set; }

        [Required]
        public string Color { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
