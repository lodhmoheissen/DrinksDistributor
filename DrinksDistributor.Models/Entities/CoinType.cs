using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrinksDistributor.Models.Entities
{
    /// <summary>
    /// POCO class that represents a coin type.
    /// </summary>
    [Table("CoinType", Schema = "dbo")]
    public class CoinType
    {
        /// <summary>
        /// Coin type identifier.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Coin type code.
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Coin type currency.
        /// </summary>
        [Required, ForeignKey("CoinCurrencyId")]
        public CoinCurrency Currency { get; set; }

        /// <summary>
        /// Coin type value.
        /// </summary>
        [Required]
        public double Value { get; set; }

        /// <summary>
        /// Coin type name.
        /// </summary>
        public string Name { get; set; }
    }
}
