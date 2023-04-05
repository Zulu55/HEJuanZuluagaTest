using System.ComponentModel.DataAnnotations;

namespace Cars.Shared.Entities
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        public Order? Order { get; set; }

        public int OrderId { get; set; }

        public int ProductNumber { get; set; }

        public int ProductId { get; set; }

        public int ProductOrigin { get; set; }
    }
}
