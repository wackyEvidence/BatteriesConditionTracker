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
    public partial class StructuresListForm : Form, IModelRequester<Structure>
    {
        private BindingList<Structure> displayedStructures = GlobalConfig.Connection.GetStructure_All();

        public StructuresListForm()
        {
            InitializeComponent();
            WireUpLists();
            AdjustDataGridView();
        }

        private void StructuresListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void WireUpLists()
        {
            dataGridView1.DataSource = displayedStructures;
        }

        private void AdjustDataGridView()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        #region IRequester<Structure> 
        public void ModelCreated(Structure model)
        {
            displayedStructures.Add(model);
        }

        public void ModelUpdated(Structure model)
        {
            Refresh();
        }
        #endregion

        private void addStructureButton_Click(object sender, EventArgs e)
        {
            var structureAddingForm = new StructureForm(FormMode.Adding, this);
            structureAddingForm.ShowDialog();
        }

        private void editStructureButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var structureModel = displayedStructures[dataGridView1.CurrentRow.Index];
                var structureEditingForm = new StructureForm(FormMode.Editing, this, structureModel);
                structureEditingForm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите строку таблицы для редактирования", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteStructureButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var structureModel = displayedStructures[dataGridView1.CurrentRow.Index];
                GlobalConfig.Connection.DeleteStructure(structureModel);
                displayedStructures.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
                MessageBox.Show("Выберите строку таблицы для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
