using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrinksDistributor.Models.Entities
{
    /// <summary>
    /// POCO class that represents a coin currency.
    /// </summary>
    [Table("CoinCurrency", Schema = "dbo")]
    public class CoinCurrency
    {
        /// <summary>
        /// Coin currency identifier.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Coin currency code.
        /// </summary>
        [Required, MaxLength(3)]
        public string IsoCode3 { get; set; }

        /// <summary>
        /// Coin currency symbol.
        /// </summary>
        [Required, MaxLength(3)]
        public string Symbol { get; set; }

        /// <summary>
        /// Coin currency name.
        /// </summary>
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
