using DrinksDistributor.Forms.Controllers;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;
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
        private DrinksController _controller;

        /// <summary>
        /// Drinks controller.
        /// </summary>
        [CreateNew]
        public DrinksController Controller
        {
            set { _controller = value; }
        }

        /// <summary>
        /// Main constructor.
        /// </summary>
        public DrinksView()
        {
            InitializeComponent();
        }
    }
}
