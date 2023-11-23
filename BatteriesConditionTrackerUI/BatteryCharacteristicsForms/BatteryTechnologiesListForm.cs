using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Models;
using BatteriesConditionTrackerUI.Interfaces;
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
    public partial class BatteryTechnologiesListForm : Form, IRequester<BatteryTechnology>
    {
        private BindingList<BatteryTechnology> displayedBatteryTechnologies = GlobalConfig.Connection.GetBatteryTechnology_All();

        public BatteryTechnologiesListForm()
        {
            InitializeComponent();
            WireUpLists();
            AdjustDataGridView();
        }

        private void WireUpLists()
        {
            dataGridView1.DataSource = displayedBatteryTechnologies;
        }

        private void AdjustDataGridView()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        #region IRequester<BatteryTechnology>
        public void ModelCreated(BatteryTechnology model)
        {
            displayedBatteryTechnologies.Add(model);
        }

        public void ModelUpdated(BatteryTechnology model)
        {
            Refresh();
        }
        #endregion

        private void addBatteryTechnologyButton_Click(object sender, EventArgs e)
        {

            var batteryTechnologyAddingForm = new BatteryTechnologyForm(FormMode.Adding, this);
            batteryTechnologyAddingForm.ShowDialog();
        }

        private void editBatteryTechnologyButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var batteryTechnologyModel = displayedBatteryTechnologies[dataGridView1.CurrentRow.Index];
                var batteryTechnologyEditingForm = new BatteryTechnologyForm(FormMode.Editing, this, batteryTechnologyModel);
                batteryTechnologyEditingForm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите строку таблицы для редактирования", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteBatteryTechnologyButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var batteryTechnologyModel = displayedBatteryTechnologies[dataGridView1.CurrentRow.Index];
                GlobalConfig.Connection.DeleteBatteryTechnology(batteryTechnologyModel);
                displayedBatteryTechnologies.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
                MessageBox.Show("Выберите строку таблицы для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
