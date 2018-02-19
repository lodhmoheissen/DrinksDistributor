using DrinksDistributor.Models;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.WinForms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DrinksDistributor.Shell
{
    /// <summary>
    /// Shell class for CAB application.
    /// </summary>
    public class DrinksDistributorShellApp : FormShellApplication<ShellWorkItem, DrinksDistributorShellForm>
    {
        /// <summary>
        /// Main entry point method.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // Ensure all our thread exceptions are handled.
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);

            // Initialize the database context.
            //DrinksDistributorContext context = new DrinksDistributorContext();

            // Run the shell.
            new DrinksDistributorShellApp().Run();
        }

        /// <summary>
        /// Shows an exception into a message box.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event args.</param>
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, e.Exception.GetType().ToString());
        }

        /// <summary>
        /// Method that does things after shell was created.
        /// </summary>
        protected override void AfterShellCreated()
        {
            base.AfterShellCreated();
        }
    }
}
