using DrinksDistributor.Models.Data;
using DrinksDistributor.Models.Entities;
using System.Data.Entity;

namespace DrinksDistributor.Models
{
    /// <summary>
    /// Class that represents an Entity Framework context for drinks distributor.
    /// </summary>
    public class DrinksDistributorContext : DbContext
    {
        #region DB SETS

        /// <summary>
        /// Coin currencies set.
        /// </summary>
        public DbSet<CoinCurrency> CoinCurrencies { get; set; }

        /// <summary>
        /// Coin types set.
        /// </summary>
        public DbSet<CoinType> CoinTypes { get; set; }

        /// <summary>
        /// Drinks set.
        /// </summary>
        public DbSet<Drink> Drinks { get; set; }

        /// <summary>
        /// Coin stocks set.
        /// </summary>
        public DbSet<CoinStock> CoinStocks { get; set; }

        #endregion

        /// <summary>
        /// Constructor and initializer for database and persistency.
        /// </summary>
        public DrinksDistributorContext() : base("DrinksDistributorDb")
        {
            InitializeDatabase();
        }

        /// <summary>
        /// Initialize the database, if not exists.
        /// </summary>
        private void InitializeDatabase()
        {
            Database.SetInitializer(new DrinksDistributorDbInitializer());
            if (!Database.Exists())
            {
                Database.Initialize(true);
            }
        }
    }
}
