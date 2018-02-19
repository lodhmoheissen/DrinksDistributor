using DrinksDistributor.Forms.Views;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.WinForms;

namespace DrinksDistributor.Forms.WorkItems
{
    /// <summary>
    /// WorkItem for Client stuff.
    /// </summary>
    public class ClientWorkItem : WorkItem
    {
        /// <summary>
        /// View Client.
        /// </summary>
        private ClientView _clientView;

        /// <summary>
        /// Tab smart part.
        /// </summary>
        private TabSmartPartInfo _smartPart;

        /// <summary>
        /// Generate the Client view (smart part);
        /// </summary>
        /// <param name="parentWorkspace">The Tab workspace.</param>
        public void Generate(IWorkspace parentWorkspace)
        {
            _smartPart = new TabSmartPartInfo();
            _smartPart.Title = "Client";
            _smartPart.ActivateTab = true;

            _clientView = Items.AddNew<ClientView>();

            parentWorkspace.Show(_clientView, _smartPart);

            this.Activate();
        }
    }
}
