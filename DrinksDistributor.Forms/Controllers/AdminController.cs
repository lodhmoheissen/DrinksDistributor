using DrinksDistributor.Forms.WorkItems;
using Microsoft.Practices.CompositeUI;

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
    }
}
