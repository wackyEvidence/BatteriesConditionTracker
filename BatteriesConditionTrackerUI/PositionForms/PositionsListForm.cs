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
    public partial class PositionsListForm : Form, IRequester<Position>
    {
        private BindingList<Position> displayedPositions = GlobalConfig.Connection.GetPosition_All();

        public PositionsListForm()
        {
            InitializeComponent();
            WireUpLists();
            AdjustDataGridView();
        }

        private void WireUpLists()
        {
            dataGridView1.DataSource = displayedPositions;
        }

        private void AdjustDataGridView()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        #region IRequester<Position>
        public void ModelCreated(Position model)
        {
            displayedPositions.Add(model);
        }

        public void ModelUpdated(Position model)
        {
            Refresh();
        }
        #endregion

        private void addPositionButton_Click(object sender, EventArgs e)
        {
            var positionAddingForm = new PositionForm(FormMode.Adding, this);
            positionAddingForm.ShowDialog();
        }

        private void editPositionButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var positionModel = displayedPositions[dataGridView1.CurrentRow.Index];
                var positionEditingForm = new PositionForm(FormMode.Editing, this, positionModel);
                positionEditingForm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите строку таблицы для редактирования", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deletePositionButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var positionModel = displayedPositions[dataGridView1.CurrentRow.Index];
                GlobalConfig.Connection.DeletePosition(positionModel);
                displayedPositions.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
                MessageBox.Show("Выберите строку таблицы для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
