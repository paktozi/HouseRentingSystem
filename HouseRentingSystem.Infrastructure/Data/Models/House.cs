using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstant;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    public class House
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(HouseTitleMaxLength)]
        public required string Title { get; set; }

        [Required]
        [MaxLength(HouseAddressMaxLength)]
        public required string Address { get; set; }

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        public required string Description { get; set; }

        [Required]
        public required string ImageUrl { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        // [Range(typeof(decimal), HousePricePerMonthMinValue, HousePricePerMonthMaxValue, ConvertValueInInvariantCulture = true)]
        public decimal PricePerMonth { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }


        public Category Category { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Agent))]
        public int AgentId { get; set; }


        public Agent Agent { get; set; } = null!;

        [Comment("User id of the renterer")]
        public string? RenterId { get; set; }



    }
}
