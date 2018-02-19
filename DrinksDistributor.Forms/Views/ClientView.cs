using DrinksDistributor.Forms.Controllers;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;
using System.Windows.Forms;

namespace DrinksDistributor.Forms.Views
{
    /// <summary>
    /// Class that represents the user control tabbed for Client.
    /// Shows the coins availability.
    /// </summary>
    [SmartPart]
    public partial class ClientView : UserControl
    {
        /// <summary>
        /// Client controller.
        /// </summary>
        private ClientController _controller;

        /// <summary>
        /// Client controller.
        /// </summary>
        [CreateNew]
        public ClientController Controller
        {
            set { _controller = value; }
        }

        /// <summary>
        /// Main constructor.
        /// </summary>
        public ClientView()
        {
            InitializeComponent();
        }
    }
}
