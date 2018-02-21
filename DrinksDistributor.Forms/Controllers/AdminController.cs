using DrinksDistributor.Forms.WorkItems;
using DrinksDistributor.Models;
using DrinksDistributor.Models.Entities;
using Microsoft.Practices.CompositeUI;
using System.Collections.Generic;
using System.Linq;

namespace DrinksDistributor.Forms.Controllers
{
    /// <summary>
    /// MVC Controller for Admin.
    /// </summary>
    public class AdminController : Controller
    {
        /// <summary>
        /// Own Admin WorkItem
        /// </summary>
        public AdminWorkItem AdminWorkItem
        {
            get { return base.WorkItem as AdminWorkItem; }
        }

        /// <summary>
        /// Load the coin stocks from db.
        /// </summary>
        /// <returns>Coin stocks from db</returns>
        public List<CoinStock> LoadCoinStocks()
        {
            List<CoinStock> list = new List<CoinStock>();
            using (DrinksDistributorContext dbContext = new DrinksDistributorContext())
            {
                list = dbContext.CoinStocks.Include("CoinType").ToList(); // 'Include' For lazyloading.
            }
            return list;
        }
    }
}
