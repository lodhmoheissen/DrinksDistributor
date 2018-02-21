using Microsoft.Practices.CompositeUI.Collections;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            // DEBUG SHELL
            //DisplaysRootItemCollections();
        }

        /// <summary>
        /// Debug the work items hierarchy.
        /// Useful for CAB issues.
        /// </summary>
        private void DisplaysRootItemCollections()
        {
            Debug.WriteLine("ITEMS:");
            ManagedObjectCollection<object> collItems = RootWorkItem.Items;
            foreach (KeyValuePair<string, object> o in collItems)
            {
                Debug.WriteLine(o.ToString());
            }

            Debug.WriteLine("COMMANDS:");
            ManagedObjectCollection<Command> collCom = RootWorkItem.Commands;
            foreach (KeyValuePair<string, Command> o in collCom)
            {
                Debug.WriteLine(o.ToString());
            }

            Debug.WriteLine("SMARTPARTS:");
            ManagedObjectCollection<object> collSmartPart = RootWorkItem.SmartParts;
            foreach (KeyValuePair<string, object> o in collSmartPart)
            {
                Debug.WriteLine(o.ToString());
            }

            // TODO: Add more collections to monitor.
        }
    }
}
