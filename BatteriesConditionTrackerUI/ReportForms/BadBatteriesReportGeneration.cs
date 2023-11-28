using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Models;

namespace BatteriesConditionTrackerUI
{
    public partial class BadBatteriesReportGeneration : Form
    {
        private BindingList<ConcreteBattery> concreteBatteries = new BindingList<ConcreteBattery>();
        private BindingList<ConcreteBattery> filteredBatteries;
        private bool usingComboBox;
        private Dictionary<string, int> comboBoxMap = new Dictionary<string, int>()
        {
            { "сейчас", 0 },
            { "месяц", 30 },
            { "полгода", 182 },
            { "год", 365 },
            { "2 года", 365 * 2 },
            { "3 года", 365 * 3 },
            { "5 лет", 365 * 5 }
        };

        public BadBatteriesReportGeneration(BindingList<ConcreteBattery> availableBatteries)
        {
            InitializeComponent();
            concreteBatteries = availableBatteries;
            comboBox1.SelectedIndex = 0;
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            
            if (usingComboBox)
            {
                var daysToAdd = comboBoxMap[comboBox1.SelectedItem.ToString()];

                Func<ConcreteBattery, bool> predicate = cb =>
                {
                    var dateDiff = (DateTime.Now.AddDays(daysToAdd) - cb.ExploitationStart).Days;
                    var serviceTimeInDays = cb.Model.BufferModeServiceTime * 365;
                    return dateDiff >= serviceTimeInDays || cb.ReplacementStatus.Name == "Требует замены";
                };

                filteredBatteries = new BindingList<ConcreteBattery>(concreteBatteries.Where(predicate).ToList());
            }
            else
            {
                var selectedDate = dateTimePicker.Value;

                Func<ConcreteBattery, bool> predicate = cb =>
                {
                    var maxServiceTime = cb.ExploitationStart.AddDays(cb.Model.BufferModeServiceTime * 365);
                    return maxServiceTime <= selectedDate || cb.ReplacementStatus.Name == "Требует замены";
                };

                filteredBatteries = new BindingList<ConcreteBattery>(concreteBatteries.Where(predicate).ToList());
            }
            
            var reportForm = new BadBatteriesReport(filteredBatteries);
            reportForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            usingComboBox = true; 
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            usingComboBox = false; 
        }
    }
}
