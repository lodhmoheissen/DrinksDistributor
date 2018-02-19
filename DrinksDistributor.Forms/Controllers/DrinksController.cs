using DrinksDistributor.Forms.WorkItems;
using Microsoft.Practices.CompositeUI;

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
    }
}
