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
    public partial class BatteryClampTypesListForm : Form, IRequester<BatteryClampType>
    {
        private BindingList<BatteryClampType> displayedClampTypes = GlobalConfig.Connection.GetBatteryClampType_All();
        public BatteryClampTypesListForm()
        {
            InitializeComponent();
            WireUpLists();
            AdjustDataGridView();
        }

        private void WireUpLists()
        {
            dataGridView1.DataSource = displayedClampTypes;
        }

        private void AdjustDataGridView()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void ModelCreated(BatteryClampType model)
        {
            displayedClampTypes.Add(model);
        }

        public void ModelUpdated(BatteryClampType model)
        {
            Refresh();
        }

        private void addClampTypeButton_Click(object sender, EventArgs e)
        {
            var clampTypeAddingForm = new BatteryClampTypeForm(FormMode.Adding, this);
            clampTypeAddingForm.ShowDialog();
        }

        private void editClampTypeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var clampTypeModel = displayedClampTypes[dataGridView1.CurrentRow.Index];
                var batteryClampTypeEditingForm = new BatteryClampTypeForm(FormMode.Editing, this, clampTypeModel);
                batteryClampTypeEditingForm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите строку таблицы для редактирования", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteClampTypeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var clampTypeModel = displayedClampTypes[dataGridView1.CurrentRow.Index];
                GlobalConfig.Connection.DeleteBatteryClampType(clampTypeModel);
                displayedClampTypes.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
                MessageBox.Show("Выберите строку таблицы для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
