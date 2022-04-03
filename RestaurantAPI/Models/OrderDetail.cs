using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }
        public decimal DishPrice { get; set; }
        public int Quantity { get; set; }
    }
}
