using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string DishName { get; set; }
        public decimal Price { get; set; }
    }
}
