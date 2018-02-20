using DrinksDistributor.Forms.WorkItems;
using DrinksDistributor.Models;
using DrinksDistributor.Models.Entities;
using Microsoft.Practices.CompositeUI;
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

        public List<Drink> LoadDrinks()
        {
            List<Drink> list = new List<Drink>();
            using (DrinksDistributorContext dbContext = new DrinksDistributorContext())
            {
                list = dbContext.Drinks.Include("PriceCurrency").ToList();
            }
            return list;
        }
    }
}
