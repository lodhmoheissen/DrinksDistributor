using DrinksDistributor.Forms.WorkItems;
using DrinksDistributor.Models;
using DrinksDistributor.Models.Entities;
using Microsoft.Practices.CompositeUI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DrinksDistributor.Forms.Controllers
{
    /// <summary>
    /// MVC Controller for Client.
    /// </summary>
    public class ClientController : Controller
    {
        /// <summary>
        /// Own Client WorkItem
        /// </summary>
        public ClientWorkItem ClientWorkItem
        {
            get { return base.WorkItem as ClientWorkItem; }
        }

        /// <summary>
        /// Load drinks from db.
        /// </summary>
        /// <returns>Drinks available.</returns>
        public List<Drink> LoadDrinks()
        {
            List<Drink> list = new List<Drink>();
            using (DrinksDistributorContext dbContext = new DrinksDistributorContext())
            {
                list = dbContext.Drinks.Include("PriceCurrency").ToList();
            }
            return list;
        }

        /// <summary>
        /// Load coin stocks from db to calculate coin change.
        /// </summary>
        /// <returns>Coin stocks available.</returns>
        public List<CoinStock> LoadCoinStocks()
        {
            List<CoinStock> list = new List<CoinStock>();
            using (DrinksDistributorContext dbContext = new DrinksDistributorContext())
            {
                list = dbContext.CoinStocks.Include("CoinType").ToList();
            }
            return list;
        }

        /// <summary>
        /// Update coin stocks from db to calculate .
        /// </summary>
        /// <returns> available.</returns>
        public void UpdateCoinStocksQuantities(Dictionary<double, int> stockToUpdate)
        {
            using (DrinksDistributorContext dbContext = new DrinksDistributorContext())
            {
                foreach (var coinType in stockToUpdate)
                {
                    var coinStock = dbContext.CoinStocks.SingleOrDefault(cs => cs.CoinType.Value == coinType.Key);
                    if (coinStock != null)
                    {
                        try
                        {
                            // Update quantity
                            coinStock.Quantity = (coinStock.Quantity - coinType.Value);
                            dbContext.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Recursively make the coin change.
        /// </summary>
        /// <param name="target">Amount to change</param>
        /// <param name="coins">Available coins</param>
        /// <returns></returns>
        public IEnumerable<List<double>> GetChange(double target, IQueryable<double> coins)
        {
            var availableCoins = from c in coins where c <= target select c;
            if (!availableCoins.Any())
            {
                yield return new List<double>();
            }
            else
            {
                foreach (var thisCoin in availableCoins)
                {
                    foreach (var result in GetChange(target - thisCoin, from c in availableCoins where c <= thisCoin select c))
                    {
                        result.Add(thisCoin);
                        yield return result;
                    }
                }
            }
        }
    }
}
