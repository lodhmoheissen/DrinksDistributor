using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrinksDistributor.Models.Entities
{
    /// <summary>
    /// POCO class that represents coin type stock for the distributor.
    /// </summary>
    [Table("CoinStock", Schema = "dbo")]
    public class CoinStock
    {
        /// <summary>
        /// Coin stock identifier.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Coin type stock.
        /// </summary>
        [Required, ForeignKey("CoinTypeId")]
        public CoinType CoinType { get; set; }

        /// <summary>
        /// Quantity.
        /// </summary>
        [Required]
        public int Quantity { get; set; }
    }
}
