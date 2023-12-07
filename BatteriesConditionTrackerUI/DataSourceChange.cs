using BatteriesConditionTrackerLib.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteriesConditionTracker
{
    public partial class DataSourceChange : Form
    {
        public DataSourceChange()
        {
            InitializeComponent();
            SelectCurrentDataSource();
            AdjustTextFilesAside();
        }

        private void AdjustTextFilesAside()
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            if (settings["textFilesPathConfigured"].Value == "true")
                usingDefaultDirectory.Visible = false;
            else
                changeTextFilesDirectory.Visible = false;

            if (!textFilesRadioButton.Checked)
            {
                usingDefaultDirectory.Enabled = false;
                changeTextFilesDirectory.Enabled = false;
            }
        }

        private void SelectCurrentDataSource()
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            switch (settings["dbType"].Value)
            {
                case "TextFiles":
                    textFilesRadioButton.Checked = true;
                    break;
                case "PostgreSQL":
                    postgreRadioButton.Checked = true;
                    break;
                case "SqlServer":
                    sqlServerRadioButton.Checked = true;
                    break;
                default:
                    throw new Exception("Неверно указан источник данных в config приложения!");
            }
        }

        private void changeTextFilesDirectory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dialog = MessageBox.Show("Для изменения источника данных нужно перезапустить приложение. Продолжить?", "Изменения источника данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            if (DialogResult.OK == dialog)
            {
                var folderBrowserDialog = TextConnector.CreateFolderBrowserDialog();

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    TextConnector.ProcessSelectedFolder(settings, folderBrowserDialog);

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                Application.Restart();
            }
            else
                Close();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Для изменения источника данных нужно перезапустить приложение. Продолжить?", "Изменения источника данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            if (DialogResult.OK == dialog)
            {
                if(postgreRadioButton.Checked)
                {
                    settings["dbType"].Value = "PostgreSQL";
                }
                else if (sqlServerRadioButton.Checked)
                {
                    settings["dbType"].Value = "SqlServer";
                }
                else
                {
                    settings["dbType"].Value = "TextFiles";

                    if (usingDefaultDirectory.Visible)
                    {
                        // ни разу не был указан путь для текстовых файлов
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
                            var directoryChosen = true; 

                            if (filesDirectory.ShowDialog() == DialogResult.OK)
                                TextConnector.ProcessSelectedFolder(settings, filesDirectory);
                            else
                            {
                                MessageBox.Show("Выберите директорию для хранения данных приложения.", "Обязательное действие", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                directoryChosen = false;
                            }

                            while (directoryChosen != true)
                            {
                                var newfilesDirectory = TextConnector.CreateFolderBrowserDialog();
                                if (newfilesDirectory.ShowDialog() == DialogResult.OK)
                                {
                                    TextConnector.ProcessSelectedFolder(settings, newfilesDirectory);
                                    directoryChosen = true;
                                }
                                MessageBox.Show("Выберите директорию для хранения данных приложения", "Обязательное действие", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            settings["textFilesPathConfigured"].Value = "true";
                        }
                    }
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                Application.Restart();
            }
            else
                Close();
        }

        private void postgreRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(usingDefaultDirectory.Visible)
                usingDefaultDirectory.Enabled = false;
            changeTextFilesDirectory.Enabled = false;   
        }

        private void sqlServerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(usingDefaultDirectory.Visible)
                usingDefaultDirectory.Enabled = false;
            changeTextFilesDirectory.Enabled = false;
        }

        private void textFilesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(usingDefaultDirectory.Visible)
                usingDefaultDirectory.Enabled = true;
            changeTextFilesDirectory.Enabled = true;    
        }
    }
}
