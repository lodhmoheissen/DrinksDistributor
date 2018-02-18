using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrinksDistributor.Models.Entities
{
    /// <summary>
    /// POCO class that represents a drink.
    /// </summary>
    [Table("Drink", Schema = "dbo")]
    public class Drink
    {
        /// <summary>
        /// Drink identifier.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Drink code.
        /// </summary>
        [Required, MaxLength(8)]
        public string Code { get; set; }

        /// <summary>
        /// Drink name.
        /// </summary>
        [Required, MaxLength(20)]
        public string Name { get; set; }

        /// <summary>
        /// Drink price.
        /// </summary>
        [Required]
        public double Price { get; set; }

        /// <summary>
        /// Drink price currency.
        /// </summary>
        [Required]
        public CoinCurrency PriceCurrency { get; set; }
    }
}
