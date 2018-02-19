using DrinksDistributor.Forms.Views;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.WinForms;
using System.Drawing;

namespace DrinksDistributor.Forms.WorkItems
{
    /// <summary>
    /// WorkItem for Admin stuff.
    /// </summary>
    public class AdminWorkItem : WorkItem
    {
        /// <summary>
        /// View Admin.
        /// </summary>
        private AdminView _adminView;

        /// <summary>
        /// Tab smart part.
        /// </summary>
        private TabSmartPartInfo _smartPart;

        /// <summary>
        /// Generate the Admin view (smart part);
        /// </summary>
        /// <param name="parentWorkspace">The Tab workspace.</param>
        public void Generate(IWorkspace parentWorkspace)
        {
            _smartPart = new TabSmartPartInfo();
            _smartPart.Title = "Admin";
            _smartPart.ActivateTab = false;

            _adminView = Items.AddNew<AdminView>();

            parentWorkspace.Show(_adminView, _smartPart);

            this.Activate();
        }
    }
}
