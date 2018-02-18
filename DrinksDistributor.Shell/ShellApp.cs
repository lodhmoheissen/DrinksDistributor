using DrinksDistributor.Models;
using DrinksDistributor.Shell.Forms;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.WinForms;
using System;
using System.Windows.Forms;

namespace DrinksDistributor.Shell
{
    /// <summary>
    /// Shell class for CAB application.
    /// </summary>
    public class ShellApp : FormShellApplication<WorkItem, FormShell>
    {
        /// <summary>
        /// Main entry point method.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DrinksDistributorContext context = new DrinksDistributorContext();

            Application.Run(new FormShell());
        }
    }
}
