using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstant;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        [Comment("Category identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public required string Name { get; set; }

        public IEnumerable<House> Houses { get; set; } = new List<House>();
    }
}
