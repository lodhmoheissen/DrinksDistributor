using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrinksDistributor.Models.Entities
{
    /// <summary>
    /// POCO class that represents Coin Stock for the distributor.
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
        /// Coin type stock. Navigation property also.
        /// </summary>
        public int CoinTypeId { get; set; }
        [Required, ForeignKey("CoinTypeId")]
        public virtual CoinType CoinType { get; set; }

        /// <summary>
        /// Quantity available for the coin.
        /// </summary>
        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// Returns a string representation of the coin stock.
        /// </summary>
        /// <returns>String representation of the coin stock</returns>
        //public override string ToString()
        //{
        //    return string.Format("{0};[{1}];{2}", Id, CoinType, Quantity);
        //}
    }
}
