using DrinksDistributor.Forms.Controllers;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;
using System.Windows.Forms;

namespace DrinksDistributor.Forms.Views
{
    /// <summary>
    /// Class that represents the user control tabbed for Admins.
    /// Shows the coins availability.
    /// </summary>
    [SmartPart]
    public partial class AdminView : UserControl
    {
        /// <summary>
        /// Admin controller.
        /// </summary>
        private AdminController _controller;

        /// <summary>
        /// Admin controller.
        /// </summary>
        [CreateNew]
        public AdminController Controller
        {
            set { _controller = value; }
        }

        /// <summary>
        /// Main constructor.
        /// </summary>
        public AdminView()
        {
            InitializeComponent();
        }
    }
}
