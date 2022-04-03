using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string PMethod { get; set; }
        public decimal GTotal { get; set; }


        public Customer Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
