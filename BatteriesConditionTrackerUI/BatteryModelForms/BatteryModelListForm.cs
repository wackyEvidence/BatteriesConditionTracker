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
using BatteriesConditionTrackerUI.Interfaces;

namespace BatteriesConditionTrackerUI
{
    public partial class BatteryModelListForm : Form, IModelRequester<BatteryModel>
    {
        BindingList<BatteryModel> displayedBatteryModels = GlobalConfig.Connection.GetBatteryModel_All();

        public BatteryModelListForm()
        {
            InitializeComponent();
            WireUpLists();
            AdjustDataGridView();
        }

        private void BatteryModelListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void WireUpLists()
        {
            dataGridView1.DataSource = displayedBatteryModels;
        }

        private void AdjustDataGridView()
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Columns[i].Visible = false;

            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        #region IRequester<BatteryModel>
        public void ModelCreated(BatteryModel model)
        {
            displayedBatteryModels.Add(model);
        }

        public void ModelUpdated(BatteryModel model)
        {
            Refresh();
        }
        #endregion

        private void addBatteryModelButton_Click(object sender, EventArgs e)
        {
            var addingForm = new BatteryModelForm(FormMode.Adding, this);
            addingForm.ShowDialog();
        }

        private void editBatteryModelButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var batteryModel = displayedBatteryModels[dataGridView1.CurrentRow.Index];
                var batteryModelEditingForm = new BatteryModelForm(FormMode.Editing, this, batteryModel);
                batteryModelEditingForm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите строку таблицы для редактирования", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteBatteryModelButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var batteryModel = displayedBatteryModels[dataGridView1.CurrentRow.Index];
                GlobalConfig.Connection.DeleteBatteryModel(batteryModel);
                displayedBatteryModels.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
                MessageBox.Show("Выберите строку таблицы для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
