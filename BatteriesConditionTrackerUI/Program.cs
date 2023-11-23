using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerUI;
using System.Configuration;

namespace BatteriesConditionTracker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            GlobalConfig.InitializeConnection(DatabaseType.SqlServer); 
            ApplicationConfiguration.Initialize();
            if (ConfigurationManager.AppSettings["isConfigured"] == "false")
            {
                Application.Run(new InitialSettings());
            }
            Application.Run(new AuthorizationForm());
        }
    }
}