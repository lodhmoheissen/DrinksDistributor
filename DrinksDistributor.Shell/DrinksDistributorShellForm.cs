using DrinksDistributor.Forms.WorkItems;
using Microsoft.Practices.CompositeUI.Services;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.WinForms;
using Microsoft.Practices.ObjectBuilder;
using System.Windows.Forms;

namespace DrinksDistributor.Shell
{
    /// <summary>
    /// Class that represents the full CAB GUI as a main container, the shell.
    /// </summary>
    public partial class DrinksDistributorShellForm : Form
    {
        #region PRIVATE MEMBERS

        /// <summary>
        /// Global WorkItem (root).
        /// </summary>
        private ShellWorkItem _rootWorkItem;

        /// <summary>
        /// Generic Workspace.
        /// </summary>
        private IWorkspace _workspace;

        #endregion

        /// <summary>
        /// Main constructor.
        /// </summary>
        public DrinksDistributorShellForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Main constructor for CAB shell form.
        /// </summary>
        [InjectionConstructor]
        public DrinksDistributorShellForm(ShellWorkItem workItem, IWorkItemTypeCatalogService workItemTypeCatalog) : this()
        {
            _rootWorkItem = workItem;

            // Creates the CAB TabWorkspace.
            _workspace = this._rootWorkItem.Workspaces.AddNew<TabWorkspace>("DrinksDistributorWorkspace");

            // Configure the TabWorkspace. It fills all the available space.
            TabWorkspace tabWorkspace = _workspace as TabWorkspace;
            tabWorkspace.Dock = DockStyle.Fill;

            // Display the TabWorkspace by adding it to shell GUI controls.
            this.Controls.Add(tabWorkspace);

            // Initialize Work items for all Views.
            ClientWorkItem clientWorkItem = _rootWorkItem.WorkItems.AddNew<ClientWorkItem>();
            DrinksWorkItem drinksWorkItem = _rootWorkItem.WorkItems.AddNew<DrinksWorkItem>();
            AdminWorkItem adminWorkItem = _rootWorkItem.WorkItems.AddNew<AdminWorkItem>();

            // Generate the tabs and the smartpart tab pages.
            clientWorkItem.Generate(_workspace);
            drinksWorkItem.Generate(_workspace);
            adminWorkItem.Generate(_workspace);
        }
    }
}
