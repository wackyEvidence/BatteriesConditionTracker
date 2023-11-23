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
    public partial class BatterySubsystemsListForm : Form, IRequester<BatterySubsystem>
    {
        private BindingList<BatterySubsystem> displayedButterySubsystems = GlobalConfig.Connection.GetBatterySubsystem_All();

        public BatterySubsystemsListForm()
        {
            InitializeComponent();
            WireUpLists();
            AdjustDataGridView();
        }

        private void WireUpLists()
        {
            dataGridView1.DataSource = displayedButterySubsystems;
        }

        private void AdjustDataGridView()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        #region IRequster<BatterySubsystem>
        public void ModelCreated(BatterySubsystem model)
        {
            displayedButterySubsystems.Add(model);  
        }

        public void ModelUpdated(BatterySubsystem model)
        {
            Refresh(); 
        }
        #endregion

        private void addSubsystemButton_Click(object sender, EventArgs e)
        {
            var subsystemAddingForm = new BatterySubsystemForm(FormMode.Adding, this);
            subsystemAddingForm.ShowDialog();
        }

        private void editSubsystemButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var batterySubsystemModel = displayedButterySubsystems[dataGridView1.CurrentRow.Index];
                var subsystemEditingForm = new BatterySubsystemForm(FormMode.Editing, this, batterySubsystemModel);
                subsystemEditingForm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите строку таблицы для редактирования", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteSubsystemButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var batterySubsystemModel = displayedButterySubsystems[dataGridView1.CurrentRow.Index];
                GlobalConfig.Connection.DeleteBatterySubsystem(batterySubsystemModel);
                displayedButterySubsystems.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
                MessageBox.Show("Выберите строку таблицы для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
