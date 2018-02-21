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
    /// Class that represents the user control tabbed for Drinks.
    /// Shows the drinks and their cost.
    /// </summary>
    [SmartPart]
    public partial class DrinksView : UserControl
    {
        /// <summary>
        /// Drinks controller.
        /// </summary>
        private DrinksController _drinksController;

        /// <summary>
        /// Drinks controller.
        /// </summary>
        [CreateNew]
        public DrinksController Controller
        {
            get { return _drinksController; }
            set { _drinksController = value; }
        }

        /// <summary>
        /// Main constructor.
        /// </summary>
        public DrinksView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load drinks data to the main data grid.
        /// </summary>
        public void LoadDrinks()
        {
            // Get data.
            List<Drink> allDrinks = _drinksController.LoadDrinks();

            // DataGridView binding.
            dgrdDrinks.DataSource = new BindingList<Drink>(allDrinks);
            dgrdDrinks.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
