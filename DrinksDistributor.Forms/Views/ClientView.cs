using DrinksDistributor.Forms.Controllers;
using DrinksDistributor.Models.Entities;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DrinksDistributor.Forms.Views
{
    /// <summary>
    /// Class that represents the user control tabbed for Client.
    /// </summary>
    [SmartPart]
    public partial class ClientView : UserControl
    {
        /// <summary>
        /// Client controller.
        /// </summary>
        private ClientController _clientController;

        /// <summary>
        /// Client controller.
        /// </summary>
        [CreateNew]
        public ClientController ClientController
        {
            get { return _clientController; }
            set { _clientController = value; }
        }

        /// <summary>
        /// Main constructor.
        /// </summary>
        public ClientView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load drinks data to the main data grid.
        /// </summary>
        public void LoadDrinks()
        {
            // Get data.
            List<Drink> allDrinks = _clientController.LoadDrinks();

            // DataGridView binding.
            dgrdDrinks.DataSource = new BindingList<Drink>(allDrinks);
            dgrdDrinks.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Combobox selection binding.
            //cbxSelectDrink.DataSource = new BindingSource(new BindingList<Drink>(_clientController.LoadDrinks()), null);
            //cbxSelectDrink.DisplayMember = "Name";
            //cbxSelectDrink.ValueMember = "Id";
        }
    }
}
