using DrinksDistributor.Forms.WorkItems;
using Microsoft.Practices.CompositeUI;

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
    }
}
