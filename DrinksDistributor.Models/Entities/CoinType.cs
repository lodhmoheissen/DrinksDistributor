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
        public int CoinCurrencyId { get; set; }
        [Required, ForeignKey("CoinCurrencyId")]
        public virtual CoinCurrency CoinCurrency { get; set; }

        /// <summary>
        /// Coin type value.
        /// </summary>
        [Required]
        public double Value { get; set; }

        /// <summary>
        /// Coin type name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Returns a string representation of the coin type.
        /// </summary>
        /// <returns>String representation of the coin type.</returns>
        public override string ToString()
        {
            return string.Format("{0};{1};[{2}];{3};{4}", Id, Code, CoinCurrency, Value, Name);
        }
    }
}
