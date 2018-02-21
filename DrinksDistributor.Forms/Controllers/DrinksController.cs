using DrinksDistributor.Forms.WorkItems;
using DrinksDistributor.Models;
using DrinksDistributor.Models.Entities;
using Microsoft.Practices.CompositeUI;
using System.Collections.Generic;
using System.Linq;

namespace DrinksDistributor.Forms.Controllers
{
    /// <summary>
    /// MVC Controller for Drinks.
    /// </summary>
    public class DrinksController : Controller
    {
        /// <summary>
        /// Own Drinks WorkItem
        /// </summary>
        public DrinksWorkItem DrinksWorkItem
        {
            get { return base.WorkItem as DrinksWorkItem; }
        }

        /// <summary>
        /// Load the drinks from db.
        /// </summary>
        /// <returns>Drinks available</returns>
        public List<Drink> LoadDrinks()
        {
            List<Drink> list = new List<Drink>();
            using (DrinksDistributorContext dbContext = new DrinksDistributorContext())
            {
                list = dbContext.Drinks.Include("PriceCurrency").ToList(); // 'Include' For lazyloading.
            }
            return list;
        }
    }
}
