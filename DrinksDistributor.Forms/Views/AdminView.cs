using DrinksDistributor.Forms.Controllers;
using DrinksDistributor.Models.Entities;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DrinksDistributor.Forms.Views
{
    /// <summary>
    /// Class that represents the user control tabbed for Admins.
    /// </summary>
    [SmartPart]
    public partial class AdminView : UserControl
    {
        /// <summary>
        /// Admin controller.
        /// </summary>
        private AdminController _adminController;

        /// <summary>
        /// Admin controller.
        /// </summary>
        [CreateNew]
        public AdminController Controller
        {
            get { return _adminController; }
            set { _adminController = value; }
        }

        /// <summary>
        /// Main constructor.
        /// </summary>
        public AdminView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load coin stocks data to the main data grid.
        /// </summary>
        public void LoadCoinStocks()
        {
            // DataGridView binding, with auto resize.
            List<CoinStock> allCoinStocks = _adminController.LoadCoinStocks();
            dgrdCoinStocks.DataSource = new BindingList<CoinStock>(allCoinStocks);
            dgrdCoinStocks.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// When user click on the button to refresh coin stocks.
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event args</param>
        private void btnRefreshCoinStocks_Click(object sender, System.EventArgs e)
        {
            LoadCoinStocks();
        }
    }
}
