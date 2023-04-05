using System.ComponentModel.DataAnnotations;

namespace Cars.Shared.Entities
{
    public class Customer
    {
        [Key]
        public int PersonId { get; set; }

        [MaxLength(100)]
        public string? FirstName { get; set; }

        [MaxLength(100)]
        public string? LastName { get; set; }

        public int Age { get; set; }

        [MaxLength(100)]
        public string? Occupation { get; set; }

        public MartialStatus MartialStatus { get; set; }
    }
}
