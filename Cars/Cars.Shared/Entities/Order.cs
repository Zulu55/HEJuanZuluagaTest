using System.ComponentModel.DataAnnotations;

namespace Cars.Shared.Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public Customer? Customer { get; set; }

        public int PersonId { get; set; }

        public DateTime DateCreated { get; set; }

        public MethodofPurchase MethodofPurchase { get; set; }
    }
}
