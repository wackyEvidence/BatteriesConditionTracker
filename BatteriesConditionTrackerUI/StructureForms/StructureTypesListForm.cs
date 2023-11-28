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
    public partial class StructureTypesListForm : Form, IModelRequester<StructureType>
    {
        private BindingList<StructureType> displayedStructureTypes = GlobalConfig.Connection.GetStructureType_All();

        public StructureTypesListForm()
        {
            InitializeComponent();
            WireUpLists();
            AdjustDataGridView();
        }

        private void StructureTypesListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void WireUpLists()
        {
            dataGridView1.DataSource = displayedStructureTypes;
        }

        private void AdjustDataGridView()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        #region IRequester<StructureType>
        public void ModelCreated(StructureType model)
        {
            displayedStructureTypes.Add(model);
        }

        public void ModelUpdated(StructureType model)
        {
            Refresh();
        }
        #endregion

        private void addStructureTypeButton_Click(object sender, EventArgs e)
        {
            var structureTypeAddingForm = new StructureTypeForm(FormMode.Adding, this);
            structureTypeAddingForm.ShowDialog();
        }

        private void editStructureTypeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var structureTypeModel = displayedStructureTypes[dataGridView1.CurrentRow.Index];
                var structureTypeEditingForm = new StructureTypeForm(FormMode.Editing, this, structureTypeModel);
                structureTypeEditingForm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите строку таблицы для редактирования", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteStructureTypeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var structureTypeModel = displayedStructureTypes[dataGridView1.CurrentRow.Index];
                GlobalConfig.Connection.DeleteStructureType(structureTypeModel);
                displayedStructureTypes.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
                MessageBox.Show("Выберите строку таблицы для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
