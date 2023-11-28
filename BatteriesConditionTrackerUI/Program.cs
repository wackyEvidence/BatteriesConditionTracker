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
            ApplicationConfiguration.Initialize();

            if (ConfigurationManager.AppSettings["dbTypeConfigured"] == "false")
                Application.Run(new InitialSettings());

            GlobalConfig.InitializeConnection();
            
            var lastReplacementStatusesUpdate = GlobalConfig.Connection.GetLastReplacementStatusesUpdateDate();
            if (lastReplacementStatusesUpdate.ToShortDateString() != DateTime.Now.ToShortDateString())
            {
                // TODO Использовать в этом месте async/await
                GlobalConfig.Connection.UpdateReplacementStatuses();
                GlobalConfig.Connection.UpdateReplacementStatusesUpdateDate();
            } 

            var authorizationForm = new AuthorizationForm();
            Application.Run(authorizationForm);

            if (authorizationForm.AuthorizationSuccessful)
                Application.Run(new BatteriesListForm());
            else
                Application.Exit();
            //Application.Run(new BatteriesListForm());
        }
    }
}