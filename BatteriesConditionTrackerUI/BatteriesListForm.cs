using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Models;
using BatteriesConditionTrackerUI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatteriesConditionTrackerLib.Filtering;
using LinqKit;

namespace BatteriesConditionTrackerUI
{
    public partial class BatteriesListForm : Form, IModelRequester<ConcreteBattery>, IModelListRequester<BatterySubsystem>, IModelListRequester<Structure>
    {
        private BindingList<ConcreteBattery> availableConcreteBatteries = GlobalConfig.Connection.GetConcreteBattery_All();
        private BindingList<ConcreteBattery> displayedConcreteBatteries;
        private List<BatteryExploitationStatus> availableExploitationStatuses = GlobalConfig.Connection.GetBatteryExploitationStatus_All();
        private List<BatteryReplacementStatus> availableReplacementStatuses = GlobalConfig.Connection.GetBatteryReplacementStatus_All();
        private List<string> availableBrands = GlobalConfig.Connection.GetAvailableBrands_All();
        private List<string> availableCapacities = GlobalConfig.Connection.GetAvailableCapacities_All();
        private BindingList<BatterySubsystem> availableBatterySubsystems = GlobalConfig.Connection.GetBatterySubsystem_All();
        private BindingList<Structure> availableStructures = GlobalConfig.Connection.GetStructure_All();

        public BatteriesListForm()
        {
            CompleteBatteryModels();

            InitializeComponent();

            WireUpLists();
            AdjustDataGridView();
            AdjustComboBoxes();
        }

        private void BatteriesListForm_Load(object sender, EventArgs e)
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

        #region IRequester<ConcreteBattery> 

        public void ModelCreated(ConcreteBattery model)
        {
            availableConcreteBatteries.Add(model);

            if (Filterer.FinalFilter(model))
                displayedConcreteBatteries.Add(model);
        }

        public void ModelUpdated(ConcreteBattery model)
        {
            dataGridView.Refresh();
        }

        #endregion

        private void addBatteryButton_Click(object sender, EventArgs e)
        {
            var addingForm = new BatteryAddingForm(this);
            addingForm.ShowDialog();
        }

        private void editBatteryButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var concreteBattery = displayedConcreteBatteries[dataGridView.CurrentRow.Index];
                var concreteBatteryEditingForm = new BatteryEditingAndViewForm(this, concreteBattery, FormMode.Editing);
                concreteBatteryEditingForm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите строку таблицы для редактирования", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteBatteryButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var concreteBattery = displayedConcreteBatteries[dataGridView.CurrentRow.Index];
                GlobalConfig.Connection.DeleteConcreteBattery(concreteBattery);
                availableConcreteBatteries.Remove(concreteBattery);
                displayedConcreteBatteries.RemoveAt(dataGridView.CurrentRow.Index);
            }
            else
                MessageBox.Show("Выберите строку таблицы для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void аккумуляторыТребующиеЗаменыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reportGenerationForm = new BadBatteriesReportGeneration(availableConcreteBatteries);
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

        // TODO Переписать 
        /// <summary>
        /// Костыль, который обходит проблему того, что при MultiMapping максимально доступно 7 типов. Таким образом,
        /// не хватает двух джойнов для того, чтобы Model назначить ClampType и Technology. 
        /// </summary>
        private void CompleteBatteryModels()
        {
            var batteryModels = GlobalConfig.Connection.GetBatteryModel_All();

            foreach (var concreteBattery in availableConcreteBatteries)
            {
                var incompleteBatteryModel = concreteBattery.Model;
                var completeBatteryModel = batteryModels.Where(m => m.Id == incompleteBatteryModel.Id).FirstOrDefault();
                incompleteBatteryModel.Technology = completeBatteryModel.Technology;
                incompleteBatteryModel.ClampType = completeBatteryModel.ClampType;
            }
        }

        public void ModelListUpdated(List<BatterySubsystem> modelList)
        {
            availableBatterySubsystems = new BindingList<BatterySubsystem>(modelList);
        }

        public void ModelListUpdated(List<Structure> modelList)
        {
            availableStructures = new BindingList<Structure>(modelList);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var concreteBattery = availableConcreteBatteries[dataGridView.CurrentRow.Index];
                var concreteBatteryEditingForm = new BatteryEditingAndViewForm(this, concreteBattery, FormMode.Watching);
                concreteBatteryEditingForm.ShowDialog();
            }
        }

        #region Filters 

        private void exploitationStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filterer.CreateExploitationStatusPredicate(exploitationStatusComboBox.SelectedItem);
            displayedConcreteBatteries = new BindingList<ConcreteBattery>(availableConcreteBatteries.Where(Filterer.FinalFilter).ToList());
            dataGridView.DataSource = displayedConcreteBatteries;
        }

        private void replacementStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filterer.CreateReplacementStatusPredicate(replacementStatusComboBox.SelectedItem);
            displayedConcreteBatteries = new BindingList<ConcreteBattery>(availableConcreteBatteries.Where(Filterer.FinalFilter).ToList());
            dataGridView.DataSource = displayedConcreteBatteries;
        }

        private void brandsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filterer.CreateBrandPredicate(brandsCheckedListBox.CheckedItems);
            displayedConcreteBatteries = new BindingList<ConcreteBattery>(availableConcreteBatteries.Where(Filterer.FinalFilter).ToList());
            dataGridView.DataSource = displayedConcreteBatteries;
        }

        private void capacitiesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filterer.CreateCapacityPredicate(capacitiesCheckedListBox.CheckedItems);
            displayedConcreteBatteries = new BindingList<ConcreteBattery>(availableConcreteBatteries.Where(Filterer.FinalFilter).ToList());
            dataGridView.DataSource = displayedConcreteBatteries;
        }

        private void subsystemCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filterer.CreateSubsystemPredicate(subsystemCheckedListBox.CheckedItems);
            displayedConcreteBatteries = new BindingList<ConcreteBattery>(availableConcreteBatteries.Where(Filterer.FinalFilter).ToList());
            dataGridView.DataSource = displayedConcreteBatteries;
        }

        private void structuresCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filterer.CreateStructurePredicate(structuresCheckedListBox.CheckedItems);
            displayedConcreteBatteries = new BindingList<ConcreteBattery>(availableConcreteBatteries.Where(Filterer.FinalFilter).ToList());
            dataGridView.DataSource = displayedConcreteBatteries;
        }
        #endregion

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
        }

        // TODO выделить в extension-метод 
        private void ClearCheckedListBoxSelection(CheckedListBox checkedListBox)
        {
            if(checkedListBox.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                    checkedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
