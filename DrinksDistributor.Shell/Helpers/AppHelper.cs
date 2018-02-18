using System.Diagnostics;
using System.Reflection;

namespace DrinksDistributor.Shell.Helpers
{
    public class AppHelper
    {
        public static string GetAppVersion()
        {
            string productVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

            return productVersion;
        }
    }
}
