using DrinksDistributor.Forms.Controllers;
using DrinksDistributor.Models.Entities;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

            // DataGridView binding, with auto resize.
            dgrdDrinks.DataSource = new BindingList<Drink>(allDrinks);
            dgrdDrinks.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Combobox selection binding.
            cbxSelectDrink.DataSource = new BindingList<Drink>(allDrinks);
            cbxSelectDrink.DisplayMember = "Name";
            cbxSelectDrink.ValueMember = "Id";
            cbxSelectDrink.SelectedIndex = -1; // To fix...
        }

        /// <summary>
        /// When user select a drink in combobox.
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event args</param>
        private void cbxSelectDrink_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedDrink = cbxSelectDrink.SelectedItem as Drink;
            if (selectedDrink != null)
            {
                tbxAmountMoneyDrink.Text = selectedDrink.Price.ToString();
            }
        }

        /// <summary>
        /// When client pay its drink and wait for coin change.
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event args</param>
        private void btnPayDrink_Click(object sender, System.EventArgs e)
        {
            string strInputAmount = tbxInputMoney.Text;
            double inputAmount = -1;

            var drinkSelected = cbxSelectDrink.SelectedItem as Drink;

            if (double.TryParse(strInputAmount, out inputAmount))
            {
                if (inputAmount <= 5.00)
                {
                    if (drinkSelected != null)
                    {
                        if (inputAmount >= drinkSelected.Price)
                        {
                            double diff = (inputAmount - drinkSelected.Price);
                            // Exact amount.
                            if (diff == 0.00)
                            {
                                MessageBox.Show("Payment OK. You got coin change : " + diff,
                                    "Payment OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            // Coin change.
                            else
                            {
                                // The different available coin type in coin stock
                                List<CoinStock> availableCoinStock = _clientController.LoadCoinStocks();
                                List<double> availableCoinTypeValues = availableCoinStock
                                    .Select(x => x.CoinType.Value).Distinct().ToList();

                                // Get all the coin changes solutions recursively.
                                IEnumerable<List<double>> solutionsForChange =
                                    _clientController.GetChange(diff, availableCoinTypeValues.AsQueryable()).OrderBy(x => x.Count);

                                // Take the best solution depending on the coin stock.
                                bool canCoinChange = false;
                                Dictionary<double, int> finalSolution = new Dictionary<double, int>();

                                foreach (var solution in solutionsForChange)
                                {
                                    Dictionary<double, int> tempSolution =
                                        solution.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

                                    // Confront the solution to the stock (quantities).
                                    bool isQuantityAvailable = true;
                                    foreach (var coinOfAType in tempSolution)
                                    {
                                        var correspCoinStock = availableCoinStock
                                            .FirstOrDefault
                                            (
                                                cs => cs.CoinType.Value == coinOfAType.Key
                                                && cs.Quantity >= coinOfAType.Value);
                                        if (correspCoinStock == null)
                                        {
                                            isQuantityAvailable = false;
                                            break;
                                        }
                                    }

                                    // If solution quantity matches the coin stocks.
                                    if (isQuantityAvailable)
                                    {
                                        canCoinChange = true;
                                        finalSolution = tempSolution;
                                        break;
                                    }
                                }

                                // Update the stock / show message.
                                if (canCoinChange)
                                {
                                    _clientController.UpdateCoinStocksQuantities(finalSolution);
                                    string finalMsg = "Payment OK. Coin change transaction :" + Environment.NewLine;
                                    foreach (var coinType in finalSolution.OrderBy(x => x.Key))
                                    {
                                        finalMsg += string.Format("- {0} x {1}{2}", coinType.Key, coinType.Value, Environment.NewLine);
                                    }
                                    MessageBox.Show(finalMsg, "Coin change OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                // Show error when no coin availability.
                                else
                                {
                                    MessageBox.Show("Coin stock are not available to coin change", "No stocks", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("You can do better than that with a simple coin", "A bigger coin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bad drink selection. Maybe a bug...", "Bad drink", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (inputAmount > 5.00 && inputAmount < 100.00)
                {
                    MessageBox.Show("A coin superior to 5 CHF?   :)", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (inputAmount > 100.00)
                {
                    MessageBox.Show("You can't pay by bill or card yet...", "Big amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(string.Format("Amount tapped '{0}' is invalid", strInputAmount),
                    "Bad input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
