using System.Diagnostics;
using System.Reflection;

namespace DrinksDistributor.Shell.Helpers
{
    /// <summary>
    /// Class that represents an application helper.
    /// </summary>
    public class AppHelper
    {
        /// <summary>
        /// Returns the application version.
        /// </summary>
        /// <returns>Application version</returns>
        public static string GetAppVersion()
        {
            return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
        }
    }
}
