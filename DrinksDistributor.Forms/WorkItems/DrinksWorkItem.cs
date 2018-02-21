using DrinksDistributor.Forms.Views;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.WinForms;

namespace DrinksDistributor.Forms.WorkItems
{
    /// <summary>
    /// WorkItem for Drinks stuff.
    /// </summary>
    public class DrinksWorkItem : WorkItem
    {
        /// <summary>
        /// View Drinks.
        /// </summary>
        private DrinksView _drinksView;

        /// <summary>
        /// Tab smart part.
        /// </summary>
        private TabSmartPartInfo _smartPart;

        /// <summary>
        /// Generate the Drinks view (smart part);
        /// </summary>
        /// <param name="parentWorkspace">The Tab workspace.</param>
        public void Generate(IWorkspace parentWorkspace)
        {
            // TabSmartPart
            _smartPart = new TabSmartPartInfo();
            _smartPart.Title = "Drinks";
            _smartPart.ActivateTab = false;

            _drinksView = this.SmartParts.AddNew<DrinksView>();
            this.Workspaces["DrinksDistributorWorkspace"].Show(_drinksView, _smartPart);

            _drinksView.LoadDrinks();

            this.Activate();
        }
    }
}
