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
            // DataGridView binding, with auto resize.
            List<Drink> allDrinks = _drinksController.LoadDrinks();
            dgrdDrinks.DataSource = new BindingList<Drink>(allDrinks);
            dgrdDrinks.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
