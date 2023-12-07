using BatteriesConditionTracker;
using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.DataAccess;
using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BatteriesConditionTrackerUI
{
    public partial class InitialSettings : Form
    {
        private bool initialSetupComplete = true;

        public InitialSettings()
        {
            InitializeComponent();
            usingDefaultDirectory.Enabled = false;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            if (postgreRadioButton.Checked)
                settings["dbType"].Value = "PostgreSQL";
            else if (sqlServerRadioButton.Checked)
                settings["dbType"].Value = "SqlServer";
            else
            {
                settings["dbType"].Value = "TextFiles";

                if (usingDefaultDirectory.Checked)
                {
                    if (!Directory.Exists(TextConnector.DefaultTextFilesPath))
                        Directory.CreateDirectory(TextConnector.DefaultTextFilesPath);

                    TextConnector.CreateNecessaryTextFiles(TextConnector.DefaultTextFilesPath);
                    settings["textFilesPath"].Value = TextConnector.DefaultTextFilesPath;
                    settings["textFilesPathConfigured"].Value = "true";
                }
                else
                {
                    var filesDirectory = TextConnector.CreateFolderBrowserDialog();

                    if (filesDirectory.ShowDialog() == DialogResult.OK)
                        TextConnector.ProcessSelectedFolder(settings, filesDirectory);
                    else
                    {
                        MessageBox.Show("Выберите директорию для хранения данных приложения.", "Обязательное действие", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        initialSetupComplete = false;
                    }

                    while (initialSetupComplete != true)
                    {
                        var newfilesDirectory = TextConnector.CreateFolderBrowserDialog();
                        if (newfilesDirectory.ShowDialog() == DialogResult.OK)
                        {
                            TextConnector.ProcessSelectedFolder(settings, newfilesDirectory);
                            initialSetupComplete = true;
                        }
                        MessageBox.Show("Выберите директорию для хранения данных приложения", "Обязательное действие", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    settings["textFilesPathConfigured"].Value = "true";
                }
            }
            settings["dbTypeConfigured"].Value = "true";
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            Close();
        }

        private void postgreRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            usingDefaultDirectory.Enabled = false;
        }

        private void sqlServerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            usingDefaultDirectory.Enabled = false;
        }

        private void textFilesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            usingDefaultDirectory.Enabled = true;
        }
    }
}
