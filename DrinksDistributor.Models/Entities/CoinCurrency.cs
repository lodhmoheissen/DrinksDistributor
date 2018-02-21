using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrinksDistributor.Models.Entities
{
    /// <summary>
    /// POCO class that represents a Coin Currency.
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

        /// <summary>
        /// Coin types related to this Coin Currency. Navigation property also.
        /// </summary>
        public virtual ICollection<CoinType> CoinTypes { get; set; }

        /// <summary>
        /// Returns a string representation of the Coin Currrency.
        /// </summary>
        /// <returns>String representation of the Coin Currrency</returns>
        public override string ToString()
        {
            return string.Format("{0}", Name);
            //return string.Format("{0};{1};{2};{3}", Id, IsoCode3, Symbol, Name);
        }
    }
}
