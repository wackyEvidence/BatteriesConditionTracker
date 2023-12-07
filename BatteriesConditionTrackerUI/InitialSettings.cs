using BatteriesConditionTracker;
using BatteriesConditionTrackerLib;
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

        private readonly string DefaultTextFilesPath = $"{Application.StartupPath}Data";

        public InitialSettings()
        {
            InitializeComponent();
            usingDefaultDirectory.Enabled = false;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            if (textFilesRadioButton.Checked)
            {
                settings["dbType"].Value = "TextFiles";

                if (usingDefaultDirectory.Checked)
                {
                    if (!Directory.Exists(DefaultTextFilesPath))
                        Directory.CreateDirectory(DefaultTextFilesPath);

                    CreateNecessaryTextFiles(DefaultTextFilesPath);
                    settings["textFilesPath"].Value = DefaultTextFilesPath;
                    settings["textFilesPathConfigured"].Value = "true";
                }
                else
                {
                    var filesDirectory = CreateFolderBrowserDialog();

                    if (filesDirectory.ShowDialog() == DialogResult.OK)
                        ProcessSelectedFolder(settings, filesDirectory);
                    else
                    {
                        MessageBox.Show("Выберите директорию для хранения данных приложения.", "Обязательное действие", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        initialSetupComplete = false;
                    }

                    while (initialSetupComplete != true)
                    {
                        var newfilesDirectory = CreateFolderBrowserDialog();
                        if(newfilesDirectory.ShowDialog() == DialogResult.OK)
                        {
                            ProcessSelectedFolder(settings, newfilesDirectory);
                            initialSetupComplete = true;
                        }
                        MessageBox.Show("Выберите директорию для хранения данных приложения", "Обязательное действие", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else if (postgreRadioButton.Checked)
                settings["dbType"].Value = "PostgreSQL";
            else
                settings["dbType"].Value = "SqlServer";

            settings["dbTypeConfigured"].Value = "true";
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            Close();

            void ProcessSelectedFolder(KeyValueConfigurationCollection settings, FolderBrowserDialog filesDirectory)
            {
                CreateNecessaryTextFiles(filesDirectory.SelectedPath);
                settings["textFilesPath"].Value = filesDirectory.SelectedPath;
                settings["textFilesPathConfigured"].Value = "true";
            }

            static FolderBrowserDialog CreateFolderBrowserDialog()
            {
                var filesDirectory = new FolderBrowserDialog();
                filesDirectory.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                filesDirectory.ShowNewFolderButton = true;
                return filesDirectory;
            }
        }

        private void CreateNecessaryTextFiles(string path)
        {
            if (!File.Exists(path + "\\BatteryExploitationStatuses.csv"))
            {
                var lines = new List<string>()
                {
                    "1,Эксплуатируется",
                    "2,Не эксплуатируется"
                };
                File.WriteAllLines(path + "\\BatteryExploitationStatuses.csv", lines);
            }

            if (!File.Exists(path + "\\BatteryReplacementStatuses.csv"))
            {
                var lines = new List<string>()
                {
                    "1,Требует замены",
                    "2,Не требует замены",
                    "3,Заменен"
                };
                File.WriteAllLines(path + "\\BatteryReplacementStatuses.csv", lines);
            }

            if (!File.Exists(path + "\\Users.csv"))
                File.WriteAllText(path + "\\Users.csv", "1,Матвей,Жаков,Дмитриевич,$2a$11$IQozpg9DGqBELIlnJm./IOKl9cH0ZSqTwNXErzfAXph9LTfUC.YLO,+7(982)977-01-99,admin,,true");

            if (!File.Exists(path + "\\LastReplacementStatusesUpdate.csv"))
                File.WriteAllText(path + "\\LastReplacementStatusesUpdate.csv", $"{DateTime.Now.ToShortDateString()}");
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
