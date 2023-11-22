using BatteriesConditionTrackerLib;
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
    public partial class BatteriesListForm : Form
    {
        private List<BatteryExploitationStatus> availableExploitationStatuses = GlobalConfig.Connection.GetBatteryExploitationStatus_All();
        private List<BatteryReplacementStatus> availableReplacementStatuses = GlobalConfig.Connection.GetBatteryReplacementStatus_All();
        private List<string> availableBrands = new List<string>();
        private List<string> availableCapacities = new List<string>();
        private BindingList<BatterySubsystem> availableBatterySubsystems = new BindingList<BatterySubsystem>();
        private BindingList<Structure> availableStructures = new BindingList<Structure>();

        public BatteriesListForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
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

        private void addUserFilterButton_Click(object sender, EventArgs e)
        {
            var userFilterForm = new UserFilterForm();
            userFilterForm.ShowDialog();
        }

        private void sortSettingsButton_Click(object sender, EventArgs e)
        {
            var userSortForm = new SortForm();
            userSortForm.ShowDialog();
        }

        private void addBatteryButton_Click(object sender, EventArgs e)
        {
            var addingForm = new BatteryAddingForm();
            addingForm.ShowDialog();
        }

        private void editBatteryButton_Click(object sender, EventArgs e)
        {
            var editingForm = new BatteryEditingAndViewForm();
            editingForm.ShowDialog();
        }

        private void аккумуляторыТребующиеЗаменыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reportGenerationForm = new BadBatteriesReportGeneration();
            reportGenerationForm.ShowDialog();
        }

        private void batteryModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var batteryModelsListForm = new BatteryModelListForm();
            batteryModelsListForm.ShowDialog();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var staffListForm = new WorkersListForm();
            staffListForm.ShowDialog();
        }
        private void positionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var positionsListForm = new PositionsListForm();
            positionsListForm.ShowDialog();
        }

        private void structuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var structuresListForm = new StructuresListForm();
            structuresListForm.ShowDialog();
        }

        private void structureTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var structureTypesListForm = new StructureTypesListForm();
            structureTypesListForm.ShowDialog();
        }

        private void batterySubsystemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var subsystemsListForm = new BatterySubsystemsListForm();
            subsystemsListForm.ShowDialog();
        }

        private void batteryClampTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var batteryClampTypesListForm = new BatteryClampTypesListForm();
            batteryClampTypesListForm.ShowDialog();
        }

        private void batteryTechnologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var batteryTechnologiesListForm = new BatteryTechnologiesListForm();
            batteryTechnologiesListForm.ShowDialog();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new About();
            aboutForm.ShowDialog();
        }
    }
}
