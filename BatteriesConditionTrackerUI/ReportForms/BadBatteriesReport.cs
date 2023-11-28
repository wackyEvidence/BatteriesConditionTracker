using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Filtering;
using BatteriesConditionTrackerLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteriesConditionTrackerUI
{
    public partial class BadBatteriesReport : Form
    {
        private BindingList<ConcreteBattery> availableConcreteBatteries;
        private BindingList<ConcreteBattery> displayedConcreteBatteries;
        private List<BatteryExploitationStatus> availableExploitationStatuses = GlobalConfig.Connection.GetBatteryExploitationStatus_All();
        private List<BatteryReplacementStatus> availableReplacementStatuses = GlobalConfig.Connection.GetBatteryReplacementStatus_All();
        private List<string> availableBrands = GlobalConfig.Connection.GetAvailableBrands_All();
        private List<string> availableCapacities = GlobalConfig.Connection.GetAvailableCapacities_All();
        private BindingList<BatterySubsystem> availableBatterySubsystems = GlobalConfig.Connection.GetBatterySubsystem_All();
        private BindingList<Structure> availableStructures = GlobalConfig.Connection.GetStructure_All();

        public BadBatteriesReport(BindingList<ConcreteBattery> filteredBatteries)
        {
            InitializeComponent();
            availableConcreteBatteries = filteredBatteries;
            WireUpLists();
            AdjustDataGridView();
            AdjustComboBoxes();
            SetLabelValues();
        }

        private void BadBatteriesReport_Load(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
            brandsCheckedListBox.ClearSelected();
            capacitiesCheckedListBox.ClearSelected();
            subsystemCheckedListBox.ClearSelected();
            structuresCheckedListBox.ClearSelected();
        }

        private void WireUpLists()
        {
            displayedConcreteBatteries = availableConcreteBatteries;
            dataGridView.DataSource = displayedConcreteBatteries;

            exploitationStatusComboBox.DataSource = availableExploitationStatuses;
            exploitationStatusComboBox.DisplayMember = "Name";

            replacementStatusComboBox.DataSource = availableReplacementStatuses;
            replacementStatusComboBox.DisplayMember = "Name";

            brandsCheckedListBox.DataSource = availableBrands;
            capacitiesCheckedListBox.DataSource = availableCapacities;

            subsystemCheckedListBox.DataSource = availableBatterySubsystems;
            subsystemCheckedListBox.DisplayMember = "Name";

            structuresCheckedListBox.DataSource = availableStructures;
            structuresCheckedListBox.DisplayMember = "Name";
        }

        private void AdjustDataGridView()
        {
            for (int i = 0; i < dataGridView.ColumnCount; i++)
                dataGridView.Columns[i].Visible = false;

            dataGridView.Columns[1].Visible = true;
            dataGridView.Columns[1].HeaderText = "Модель";
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;


            dataGridView.Columns[4].Visible = true;
            dataGridView.Columns[4].HeaderText = "Объект";
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;


            dataGridView.Columns[5].Visible = true;
            dataGridView.Columns[5].HeaderText = "Подсистема";
            dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void AdjustComboBoxes()
        {
            exploitationStatusComboBox.SelectedItem = null;
            exploitationStatusComboBox.Text = "Статус эксплуатации";
            replacementStatusComboBox.SelectedItem = null;
            replacementStatusComboBox.Text = "Статус замены";
        }

        private void SetLabelValues()
        {
            quantityLabel.Text = displayedConcreteBatteries.Count.ToString();
            var cost = 0;
            foreach (var cb in displayedConcreteBatteries)
                cost += cb.Model.Cost;
            replacementCostLabel.Text = cost.ToString();
        }

        private void exploitationStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filterer.CreateExploitationStatusPredicate(exploitationStatusComboBox.SelectedItem);
            displayedConcreteBatteries = new BindingList<ConcreteBattery>(availableConcreteBatteries.Where(Filterer.FinalFilter).ToList());
            dataGridView.DataSource = displayedConcreteBatteries;
            SetLabelValues();
        }

        private void replacementStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filterer.CreateReplacementStatusPredicate(replacementStatusComboBox.SelectedItem);
            displayedConcreteBatteries = new BindingList<ConcreteBattery>(availableConcreteBatteries.Where(Filterer.FinalFilter).ToList());
            dataGridView.DataSource = displayedConcreteBatteries;
            SetLabelValues();
        }

        private void brandsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filterer.CreateBrandPredicate(brandsCheckedListBox.CheckedItems);
            displayedConcreteBatteries = new BindingList<ConcreteBattery>(availableConcreteBatteries.Where(Filterer.FinalFilter).ToList());
            dataGridView.DataSource = displayedConcreteBatteries;
            SetLabelValues();
        }

        private void capacitiesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filterer.CreateCapacityPredicate(capacitiesCheckedListBox.CheckedItems);
            displayedConcreteBatteries = new BindingList<ConcreteBattery>(availableConcreteBatteries.Where(Filterer.FinalFilter).ToList());
            dataGridView.DataSource = displayedConcreteBatteries;
            SetLabelValues();
        }

        private void subsystemCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filterer.CreateSubsystemPredicate(subsystemCheckedListBox.CheckedItems);
            displayedConcreteBatteries = new BindingList<ConcreteBattery>(availableConcreteBatteries.Where(Filterer.FinalFilter).ToList());
            dataGridView.DataSource = displayedConcreteBatteries;
            SetLabelValues();
        }

        private void structuresCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filterer.CreateStructurePredicate(structuresCheckedListBox.CheckedItems);
            displayedConcreteBatteries = new BindingList<ConcreteBattery>(availableConcreteBatteries.Where(Filterer.FinalFilter).ToList());
            dataGridView.DataSource = displayedConcreteBatteries;
            SetLabelValues();
        }

        private void resetAllFiltersLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdjustComboBoxes();
            brandsCheckedListBox.ClearSelected();
            ClearCheckedListBoxSelection(brandsCheckedListBox);
            capacitiesCheckedListBox.ClearSelected();
            ClearCheckedListBoxSelection(capacitiesCheckedListBox);
            subsystemCheckedListBox.ClearSelected();
            ClearCheckedListBoxSelection(subsystemCheckedListBox);
            structuresCheckedListBox.ClearSelected();
            ClearCheckedListBoxSelection(structuresCheckedListBox);
            displayedConcreteBatteries = availableConcreteBatteries;
            dataGridView.DataSource = displayedConcreteBatteries;
            SetLabelValues();
        }

        // TODO выделить в extension-метод 
        private void ClearCheckedListBoxSelection(CheckedListBox checkedListBox)
        {
            if (checkedListBox.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                    checkedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
